import React, { useState, useEffect } from 'react'
import { marked } from 'marked'

function Memory() {
  const [fileTree, setFileTree] = useState([])
  const [selectedFile, setSelectedFile] = useState(null)
  const [fileContent, setFileContent] = useState('')
  const [searchQuery, setSearchQuery] = useState('')
  const [searchResults, setSearchResults] = useState([])
  const [expandedDirs, setExpandedDirs] = useState(new Set(['', 'skills', 'memory', 'templates', 'research']))

  useEffect(() => {
    fetchFileTree()
  }, [])

  const fetchFileTree = async () => {
    try {
      const res = await fetch('/api/files')
      if (res.ok) {
        const data = await res.json()
        setFileTree(data.tree)
      }
    } catch (err) {
      console.error('Failed to fetch file tree:', err)
    }
  }

  const fetchFileContent = async (path) => {
    try {
      const res = await fetch(`/api/memory/${path}`)
      if (res.ok) {
        const data = await res.json()
        setFileContent(data.content)
        setSelectedFile(path)
      }
    } catch (err) {
      console.error('Failed to fetch file:', err)
    }
  }

  const handleSearch = async (e) => {
    e.preventDefault()
    if (!searchQuery.trim()) return
    
    try {
      const res = await fetch(`/api/search?q=${encodeURIComponent(searchQuery)}`)
      if (res.ok) {
        const data = await res.json()
        setSearchResults(data.results)
      }
    } catch (err) {
      console.error('Search failed:', err)
    }
  }

  const toggleDir = (path) => {
    const newExpanded = new Set(expandedDirs)
    if (newExpanded.has(path)) {
      newExpanded.delete(path)
    } else {
      newExpanded.add(path)
    }
    setExpandedDirs(newExpanded)
  }

  const getFileIcon = (name) => {
    if (name.endsWith('.md')) return '📝'
    if (name.endsWith('.json')) return '⚙️'
    if (name.endsWith('.js') || name.endsWith('.jsx')) return '📜'
    if (name.endsWith('.css')) return '🎨'
    if (name.endsWith('.html')) return '🌐'
    return '📄'
  }

  const renderTree = (entries, parentPath = '') => {
    return entries.map(entry => {
      const fullPath = parentPath ? `${parentPath}/${entry.name}` : entry.name
      
      if (entry.type === 'directory') {
        const isExpanded = expandedDirs.has(fullPath)
        return (
          <div key={fullPath} className="tree-dir">
            <div 
              className="tree-item dir-item"
              onClick={() => toggleDir(fullPath)}
            >
              <span className="tree-icon">{isExpanded ? '📂' : '📁'}</span>
              <span className="tree-name">{entry.name}</span>
            </div>
            {isExpanded && entry.children && (
              <div className="tree-children">
                {renderTree(entry.children, fullPath)}
              </div>
            )}
          </div>
        )
      } else {
        return (
          <div 
            key={fullPath}
            className={`tree-item file-item ${selectedFile === fullPath ? 'selected' : ''}`}
            onClick={() => fetchFileContent(fullPath)}
          >
            <span className="tree-icon">{getFileIcon(entry.name)}</span>
            <span className="tree-name">{entry.name}</span>
            <span className="tree-size">{(entry.size / 1024).toFixed(1)}KB</span>
          </div>
        )
      }
    })
  }

  const renderMarkdown = (content) => {
    const html = marked(content)
    return { __html: html }
  }

  return (
    <div className="memory-page">
      <div className="memory-header">
        <h2>◉ Memory Browser</h2>
        <form className="search-bar" onSubmit={handleSearch}>
          <input
            type="text"
            placeholder="Search workspace..."
            value={searchQuery}
            onChange={(e) => setSearchQuery(e.target.value)}
          />
          <button type="submit">Search</button>
        </form>
      </div>

      <div className="memory-content">
        <div className="file-tree-panel">
          <div className="panel-header">
            <span className="mono">WORKSPACE/</span>
          </div>
          <div className="tree-list">
            {renderTree(fileTree)}
          </div>
        </div>

        <div className="file-viewer-panel">
          {searchResults.length > 0 ? (
            <div className="search-results">
              <h3>Search Results for "{searchQuery}"</h3>
              {searchResults.map((result, idx) => (
                <div key={idx} className="search-result-item">
                  <div 
                    className="result-file"
                    onClick={() => {
                      fetchFileContent(result.file)
                      setSearchResults([])
                    }}
                  >
                    {getFileIcon(result.file)} {result.file}
                  </div>
                  {result.matches.map((match, mIdx) => (
                    <div key={mIdx} className="result-match">
                      <span className="line-num">{match.line}:</span>
                      <span className="line-text">{match.text}</span>
                    </div>
                  ))}
                </div>
              ))}
            </div>
          ) : selectedFile ? (
            <div className="file-viewer">
              <div className="file-header">
                <span className="file-path mono">{selectedFile}</span>
              </div>
              <div 
                className="file-content markdown-body"
                dangerouslySetInnerHTML={renderMarkdown(fileContent)}
              />
            </div>
          ) : (
            <div className="empty-state">
              <p>Select a file from the tree to view</p>
              <p className="hint">Or use search to find content across all files</p>
            </div>
          )}
        </div>
      </div>

      <style>{`
        .memory-page {
          padding: 1.5rem;
          height: calc(100vh - 64px);
          display: flex;
          flex-direction: column;
        }

        .memory-header {
          display: flex;
          justify-content: space-between;
          align-items: center;
          margin-bottom: 1rem;
          padding-bottom: 1rem;
          border-bottom: 1px solid var(--border-color);
        }

        .memory-header h2 {
          font-family: var(--font-mono);
          font-size: 1.2rem;
          margin: 0;
        }

        .search-bar {
          display: flex;
          gap: 0.5rem;
        }

        .search-bar input {
          background: var(--bg-tertiary);
          border: 1px solid var(--border-color);
          color: var(--text-primary);
          padding: 0.5rem 1rem;
          font-family: var(--font-mono);
          font-size: 0.9rem;
          width: 300px;
        }

        .search-bar input:focus {
          outline: none;
          border-color: var(--accent-green);
        }

        .search-bar button {
          background: var(--accent-green);
          color: var(--bg-primary);
          border: none;
          padding: 0.5rem 1rem;
          font-family: var(--font-mono);
          font-weight: 600;
          cursor: pointer;
        }

        .memory-content {
          display: flex;
          gap: 1rem;
          flex: 1;
          overflow: hidden;
        }

        .file-tree-panel {
          width: 300px;
          background: var(--bg-secondary);
          border: 1px solid var(--border-color);
          overflow-y: auto;
        }

        .panel-header {
          padding: 0.75rem 1rem;
          background: var(--bg-tertiary);
          border-bottom: 1px solid var(--border-color);
          font-size: 0.85rem;
          color: var(--text-muted);
        }

        .tree-list {
          padding: 0.5rem;
        }

        .tree-item {
          display: flex;
          align-items: center;
          gap: 0.5rem;
          padding: 0.35rem 0.5rem;
          cursor: pointer;
          font-size: 0.85rem;
          font-family: var(--font-mono);
        }

        .tree-item:hover {
          background: var(--bg-tertiary);
        }

        .tree-item.selected {
          background: var(--accent-green);
          color: var(--bg-primary);
        }

        .dir-item {
          font-weight: 500;
        }

        .tree-children {
          margin-left: 1rem;
          border-left: 1px solid var(--border-color);
          padding-left: 0.5rem;
        }

        .tree-icon {
          font-size: 1rem;
        }

        .tree-name {
          flex: 1;
          overflow: hidden;
          text-overflow: ellipsis;
          white-space: nowrap;
        }

        .tree-size {
          color: var(--text-muted);
          font-size: 0.75rem;
        }

        .file-viewer-panel {
          flex: 1;
          background: var(--bg-secondary);
          border: 1px solid var(--border-color);
          overflow-y: auto;
        }

        .file-header {
          padding: 0.75rem 1rem;
          background: var(--bg-tertiary);
          border-bottom: 1px solid var(--border-color);
          font-size: 0.85rem;
        }

        .file-content {
          padding: 1.5rem;
          line-height: 1.6;
        }

        .file-content h1,
        .file-content h2,
        .file-content h3 {
          color: var(--accent-green);
          margin-top: 1.5rem;
          margin-bottom: 0.75rem;
        }

        .file-content code {
          background: var(--bg-tertiary);
          padding: 0.2rem 0.4rem;
          font-family: var(--font-mono);
          font-size: 0.9em;
        }

        .file-content pre {
          background: var(--bg-tertiary);
          padding: 1rem;
          overflow-x: auto;
        }

        .file-content pre code {
          background: none;
          padding: 0;
        }

        .file-content table {
          width: 100%;
          border-collapse: collapse;
          margin: 1rem 0;
        }

        .file-content th,
        .file-content td {
          border: 1px solid var(--border-color);
          padding: 0.5rem;
          text-align: left;
        }

        .file-content th {
          background: var(--bg-tertiary);
        }

        .empty-state {
          display: flex;
          flex-direction: column;
          align-items: center;
          justify-content: center;
          height: 100%;
          color: var(--text-muted);
        }

        .empty-state .hint {
          font-size: 0.85rem;
          margin-top: 0.5rem;
        }

        .search-results {
          padding: 1.5rem;
        }

        .search-results h3 {
          margin-bottom: 1rem;
          color: var(--accent-green);
        }

        .search-result-item {
          margin-bottom: 1.5rem;
          padding-bottom: 1rem;
          border-bottom: 1px solid var(--border-color);
        }

        .result-file {
          font-family: var(--font-mono);
          font-weight: 500;
          color: var(--accent-blue);
          cursor: pointer;
          margin-bottom: 0.5rem;
        }

        .result-file:hover {
          text-decoration: underline;
        }

        .result-match {
          margin-left: 1rem;
          font-size: 0.85rem;
          margin-bottom: 0.25rem;
        }

        .line-num {
          color: var(--text-muted);
          margin-right: 0.5rem;
        }

        .line-text {
          color: var(--text-secondary);
        }
      `}</style>
    </div>
  )
}

export default Memory
