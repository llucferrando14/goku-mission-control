import express from 'express'
import cors from 'cors'
import fs from 'fs/promises'
import path from 'path'
import { fileURLToPath } from 'url'

const __filename = fileURLToPath(import.meta.url)
const __dirname = path.dirname(__filename)

const app = express()
const PORT = 3001

// Workspace root (where Goku's files live)
const WORKSPACE = path.join(process.env.HOME || '/home/llucferrando', '.openclaw/workspace')

app.use(cors())
app.use(express.json())

// Health check
app.get('/api/health', (req, res) => {
  res.json({ status: 'ok', timestamp: new Date().toISOString() })
})

// Get Goku's current status
app.get('/api/status', async (req, res) => {
  try {
    // Read today's log for latest activity
    const today = new Date().toISOString().split('T')[0]
    const logPath = path.join(WORKSPACE, 'memory', 'daily', `${today}.md`)
    
    let lastActivity = 'Unknown'
    try {
      const logContent = await fs.readFile(logPath, 'utf-8')
      // Extract last event timestamp (simple regex)
      const timeMatch = logContent.match(/(\d{2}:\d{2}) GMT/)
      if (timeMatch) {
        lastActivity = timeMatch[1]
      }
    } catch (e) {
      // Log doesn't exist yet
    }

    res.json({
      online: true,
      tier: 'TIER 1 BUILDER',
      activeTask: 'Building Mission Control Dashboard',
      lastHeartbeat: 'Just now',
      lastActivity,
      models: {
        kimi: true,
        claude: true,
        gemini: true
      },
      workspace: WORKSPACE,
      timestamp: new Date().toISOString()
    })
  } catch (err) {
    res.status(500).json({ error: err.message })
  }
})

// Get recent activity from daily logs
app.get('/api/activity', async (req, res) => {
  try {
    const today = new Date().toISOString().split('T')[0]
    const logPath = path.join(WORKSPACE, 'memory', 'daily', `${today}.md`)
    
    try {
      const content = await fs.readFile(logPath, 'utf-8')
      // Parse simple activity entries from markdown
      const activities = []
      const lines = content.split('\n')
      
      for (const line of lines) {
        // Look for time patterns like "01:42 GMT+1"
        const timeMatch = line.match(/(\d{2}:\d{2}) GMT/)
        if (timeMatch) {
          // Check for action indicators
          let icon = '◉'
          let text = line.trim()
          
          if (line.includes('✅')) icon = '✅'
          else if (line.includes('📁')) icon = '📁'
          else if (line.includes('⚡')) icon = '⚡'
          else if (line.includes('🔰')) icon = '🔰'
          else if (line.includes('📝')) icon = '📝'
          
          // Clean up the text
          text = text.replace(/^[\s\-\*•]*/, '').replace(/\d{2}:\d{2} GMT.*$/, '')
          
          activities.push({
            time: timeMatch[1],
            icon,
            text: text.substring(0, 60) + (text.length > 60 ? '...' : ''),
            model: 'Kimi',
            duration: '—'
          })
        }
      }
      
      res.json(activities.slice(-20).reverse())
    } catch (e) {
      // Return fallback if no log
      res.json([
        { time: '--:--', icon: '◉', text: 'No activity logged yet', model: '—', duration: '—' }
      ])
    }
  } catch (err) {
    res.status(500).json({ error: err.message })
  }
})

// List all tasks
app.get('/api/tasks', async (req, res) => {
  try {
    const tasksDir = path.join(WORKSPACE, 'tasks')
    const pendingDir = path.join(tasksDir, 'pending')
    const doneDir = path.join(tasksDir, 'done')
    
    const [pendingFiles, doneFiles] = await Promise.all([
      fs.readdir(pendingDir).catch(() => []),
      fs.readdir(doneDir).catch(() => [])
    ])
    
    const pending = await Promise.all(
      pendingFiles
        .filter(f => f.endsWith('.md'))
        .map(async f => {
          const content = await fs.readFile(path.join(pendingDir, f), 'utf-8')
          return { id: f, status: 'pending', content: content.substring(0, 200) }
        })
    )
    
    const done = await Promise.all(
      doneFiles
        .filter(f => f.endsWith('.md'))
        .map(async f => {
          const content = await fs.readFile(path.join(doneDir, f), 'utf-8')
          return { id: f, status: 'done', content: content.substring(0, 200) }
        })
    )
    
    res.json({ pending, done })
  } catch (err) {
    res.status(500).json({ error: err.message })
  }
})

// Create new task
app.post('/api/tasks', async (req, res) => {
  try {
    const { title, domain, priority, description, model } = req.body
    
    const taskId = `task-${Date.now()}.md`
    const taskPath = path.join(WORKSPACE, 'tasks', 'pending', taskId)
    
    const content = `---
title: ${title}
domain: ${domain}
priority: ${priority}
model: ${model || 'auto'}
created: ${new Date().toISOString()}
status: pending
---

${description || 'No description provided.'}
`
    
    await fs.writeFile(taskPath, content)
    
    res.json({ success: true, id: taskId, path: taskPath })
  } catch (err) {
    res.status(500).json({ error: err.message })
  }
})

// Read any workspace file
app.get('/api/memory/*', async (req, res) => {
  try {
    const filePath = req.params[0]
    // Security: ensure path stays within workspace
    const fullPath = path.join(WORKSPACE, filePath)
    const resolvedPath = path.resolve(fullPath)
    const resolvedWorkspace = path.resolve(WORKSPACE)
    
    if (!resolvedPath.startsWith(resolvedWorkspace)) {
      return res.status(403).json({ error: 'Access denied' })
    }
    
    const content = await fs.readFile(resolvedPath, 'utf-8')
    res.json({ path: filePath, content })
  } catch (err) {
    res.status(404).json({ error: 'File not found' })
  }
})

// List directory contents
app.get('/api/list/*', async (req, res) => {
  try {
    const dirPath = req.params[0] || ''
    const fullPath = path.join(WORKSPACE, dirPath)
    const resolvedPath = path.resolve(fullPath)
    const resolvedWorkspace = path.resolve(WORKSPACE)
    
    if (!resolvedPath.startsWith(resolvedWorkspace)) {
      return res.status(403).json({ error: 'Access denied' })
    }
    
    const entries = await fs.readdir(resolvedPath, { withFileTypes: true })
    res.json({
      path: dirPath,
      entries: entries.map(e => ({
        name: e.name,
        type: e.isDirectory() ? 'directory' : 'file'
      }))
    })
  } catch (err) {
    res.status(404).json({ error: 'Directory not found' })
  }
})

// Get full file tree
app.get('/api/files', async (req, res) => {
  try {
    async function buildTree(dirPath, relativePath = '') {
      const fullPath = path.join(WORKSPACE, dirPath)
      const entries = await fs.readdir(fullPath, { withFileTypes: true })
      
      const children = await Promise.all(
        entries.map(async entry => {
          const entryRelativePath = path.join(relativePath, entry.name)
          if (entry.isDirectory()) {
            const subChildren = await buildTree(entryRelativePath, entryRelativePath)
            return {
              name: entry.name,
              type: 'directory',
              path: entryRelativePath,
              children: subChildren
            }
          } else {
            const stats = await fs.stat(path.join(fullPath, entry.name))
            return {
              name: entry.name,
              type: 'file',
              path: entryRelativePath,
              size: stats.size,
              modified: stats.mtime
            }
          }
        })
      )
      
      return children
    }
    
    const tree = await buildTree('')
    res.json({ tree })
  } catch (err) {
    res.status(500).json({ error: err.message })
  }
})

// Search across workspace
app.get('/api/search', async (req, res) => {
  try {
    const query = req.query.q?.toLowerCase()
    if (!query) {
      return res.json({ results: [] })
    }
    
    const results = []
    
    async function searchDir(dirPath, relativePath = '') {
      const fullPath = path.join(WORKSPACE, dirPath)
      const entries = await fs.readdir(fullPath, { withFileTypes: true })
      
      for (const entry of entries) {
        const entryRelativePath = path.join(relativePath, entry.name)
        
        if (entry.isDirectory()) {
          await searchDir(entryRelativePath, entryRelativePath)
        } else if (entry.name.endsWith('.md') || entry.name.endsWith('.json') || entry.name.endsWith('.txt')) {
          try {
            const content = await fs.readFile(path.join(fullPath, entry.name), 'utf-8')
            if (content.toLowerCase().includes(query)) {
              // Find context around match
              const lines = content.split('\n')
              const matches = []
              lines.forEach((line, idx) => {
                if (line.toLowerCase().includes(query)) {
                  matches.push({
                    line: idx + 1,
                    text: line.trim().substring(0, 100)
                  })
                }
              })
              
              if (matches.length > 0) {
                results.push({
                  file: entryRelativePath,
                  matches: matches.slice(0, 3) // Max 3 matches per file
                })
              }
            }
          } catch (e) {
            // Skip files that can't be read
          }
        }
      }
    }
    
    await searchDir('')
    res.json({ query, results })
  } catch (err) {
    res.status(500).json({ error: err.message })
  }
})

app.listen(PORT, () => {
  console.log(`⚡ Mission Control backend running on port ${PORT}`)
  console.log(`📁 Watching workspace: ${WORKSPACE}`)
})
