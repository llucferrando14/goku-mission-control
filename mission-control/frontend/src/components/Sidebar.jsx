import React from 'react'
import { NavLink } from 'react-router-dom'

function Sidebar() {
  const navItems = [
    { path: '/', icon: '⚡', label: 'Home' },
    { path: '/kanban', icon: '▣', label: 'Kanban' },
    { path: '/domains', icon: '◈', label: 'Domains' },
    { path: '/memory', icon: '◉', label: 'Memory' },
    { path: '/settings', icon: '◐', label: 'Settings' },
  ]

  return (
    <aside className="sidebar">
      <div className="sidebar-header">
        <div className="logo">
          <span className="logo-icon">◉</span>
          <span className="logo-text">GOKU</span>
        </div>
        <div className="logo-subtitle">MISSION CONTROL</div>
      </div>

      <nav className="sidebar-nav">
        {navItems.map((item) => (
          <NavLink
            key={item.path}
            to={item.path}
            className={({ isActive }) => 
              isActive ? 'nav-item active' : 'nav-item'
            }
          >
            <span className="nav-icon">{item.icon}</span>
            <span className="nav-label">{item.label}</span>
          </NavLink>
        ))}
      </nav>

      <div className="sidebar-footer">
        <div className="version">v1.0.0</div>
        <div className="status-line">
          <span className="status-dot online"></span>
          <span className="mono text-secondary">SYSTEM ONLINE</span>
        </div>
      </div>

      <style>{`
        .sidebar {
          width: var(--sidebar-width);
          background: var(--bg-secondary);
          border-right: 1px solid var(--border-color);
          display: flex;
          flex-direction: column;
          position: fixed;
          height: 100vh;
          z-index: 100;
        }

        .sidebar-header {
          padding: 1.5rem;
          border-bottom: 1px solid var(--border-color);
        }

        .logo {
          display: flex;
          align-items: center;
          gap: 0.75rem;
        }

        .logo-icon {
          font-size: 1.5rem;
          color: var(--accent-green);
          text-shadow: 0 0 12px var(--accent-green);
        }

        .logo-text {
          font-family: var(--font-mono);
          font-size: 1.5rem;
          font-weight: 600;
          letter-spacing: 0.1em;
          color: var(--text-primary);
        }

        .logo-subtitle {
          font-family: var(--font-mono);
          font-size: 0.65rem;
          letter-spacing: 0.2em;
          color: var(--text-muted);
          margin-top: 0.25rem;
          margin-left: 2.25rem;
        }

        .sidebar-nav {
          flex: 1;
          padding: 1rem 0;
        }

        .nav-item {
          display: flex;
          align-items: center;
          gap: 1rem;
          padding: 0.875rem 1.5rem;
          color: var(--text-secondary);
          text-decoration: none;
          font-family: var(--font-mono);
          font-size: 0.9rem;
          border-left: 2px solid transparent;
          transition: all var(--transition-fast);
        }

        .nav-item:hover {
          color: var(--text-primary);
          background: var(--bg-tertiary);
        }

        .nav-item.active {
          color: var(--accent-green);
          background: var(--bg-tertiary);
          border-left-color: var(--accent-green);
        }

        .nav-icon {
          font-size: 1.1rem;
          width: 1.5rem;
          text-align: center;
        }

        .sidebar-footer {
          padding: 1rem 1.5rem;
          border-top: 1px solid var(--border-color);
        }

        .version {
          font-family: var(--font-mono);
          font-size: 0.75rem;
          color: var(--text-muted);
          margin-bottom: 0.5rem;
        }

        .status-line {
          display: flex;
          align-items: center;
          gap: 0.5rem;
          font-size: 0.75rem;
        }

        .main-content {
          flex: 1;
          margin-left: var(--sidebar-width);
          min-height: 100vh;
          background: var(--bg-primary);
        }
      `}</style>
    </aside>
  )
}

export default Sidebar
