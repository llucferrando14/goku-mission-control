import chokidar from 'chokidar'
import fs from 'fs/promises'
import path from 'path'
import { fileURLToPath } from 'url'

const __filename = fileURLToPath(import.meta.url)
const __dirname = path.dirname(__filename)

const WORKSPACE = path.join(process.env.HOME || '/home/llucferrando', '.openclaw/workspace')

// Initialize file watcher
const watcher = chokidar.watch(WORKSPACE, {
  ignored: /(^|[\/\\])\../, // ignore dotfiles
  persistent: true,
  ignoreInitial: true
})

console.log('👁 File watcher initialized')
console.log(`   Watching: ${WORKSPACE}`)

// Event handlers
watcher
  .on('add', async filePath => {
    const relativePath = path.relative(WORKSPACE, filePath)
    console.log(`[ADD] ${relativePath}`)
    
    // If it's a new task, could notify Telegram here
    if (relativePath.includes('tasks/pending/')) {
      console.log(`   → New task detected: ${path.basename(filePath)}`)
      // TODO: Send Telegram notification
    }
  })
  .on('change', filePath => {
    const relativePath = path.relative(WORKSPACE, filePath)
    console.log(`[CHANGE] ${relativePath}`)
  })
  .on('unlink', filePath => {
    const relativePath = path.relative(WORKSPACE, filePath)
    console.log(`[DELETE] ${relativePath}`)
  })
  .on('error', error => console.error('Watcher error:', error))

// Graceful shutdown
process.on('SIGINT', () => {
  console.log('\n👁 Closing file watcher...')
  watcher.close()
  process.exit(0)
})
