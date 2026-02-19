import React, { useState, useEffect } from 'react'
import { marked } from 'marked'

function Home({ status }) {
  const [activities, setActivities] = useState([])
  const [stats, setStats] = useState({
    tasksToday: 12,
    tasksPending: 2,
    kimiUsage: 67,
    claudeUsage: 23,
    geminiUsage: 10,
    activeDomain: 'Mission Control 🎮',
    healthStatus: 'No alerts'
  })

  useEffect(() => {
    fetchActivities()
  }, [])

  const fetchActivities = async () => {
    try {
      const res = await fetch('/api/activity')
      if (res.ok) {
        const data = await res.json()
        setActivities(data)
      } else {
        // Fallback: parse from today's log
        setActivities(getFallbackActivities())
      }
    } catch (err) {
      setActivities(getFallbackActivities())
    }
  }

  const getFallbackActivities = () => [
    { time: '01:47', icon: '✅', text: 'Created game-market-brief-2026-02-19.md', model: 'Kimi', duration: '0.2s' },
    { time: '01:45', icon: '📁', text: 'Created skills/game/SKILL.md', model: 'Kimi', duration: '0.1s' },
    { time: '01:43', icon: '⚡', text: 'Tier 1 BUILDER upgrade complete', model: 'Kimi', duration: '—' },
    { time: '01:42', icon: '📂', icon: '📂', text: 'Workspace structure initialized', model: 'Kimi', duration: '0.3s' },
    { time: '01:40', icon: '🔰', text: 'Goku onboarding sequence received', model: 'Kimi', duration: '—' },
  ]

  const getDomainEmoji = (text) => {
    if (text.includes('game') || text.includes('Game')) return '🎮'
    if (text.includes('mission')) return '🎮'
    return '◉'
  }

  return (
    <div className="home-page">
      {/* Agent Status Bar */}
      <header className="agent-status-bar">
        <div className="status-left">
          <span className="status-indicator">
            <span className="status-dot online"></span>
            <span className="mono text-green">GOKU — {status.tier}</span>
            <span className="text-muted">[ONLINE]</span>
          </span>
          <span className="divider">|</span>
          <span className="model-status">
            <span className={status.models.kimi ? 'text-green' : 'text-muted'}>Kimi router ✓</span>
            <span className={status.models.claude ? 'text-green' : 'text-muted'}>Claude CLI ✓</span>
            <span className={status.models.gemini ? 'text-green' : 'text-muted'}>Gemini CLI ✓</span>
          </span>
        </div>
        <div className="status-right">
          <span className="mono text-secondary">Active: "{status.activeTask}"</span>
          <span className="divider">|</span>
          <span className="text-muted">Last heartbeat: {status.lastHeartbeat}</span>
        </div>
      </header>

      <div className="home-content">
        {/* Quick Stats Row */}
        <section className="stats-row">
          <div className="stat-card">
            <div className="stat-label">Tasks Today</div>
            <div className="stat-value mono">
              <span className="text-green">{stats.tasksToday}</span>
              <span className="text-muted"> / {stats.tasksPending} pending</span>
            </div>
          </div>
          <div className="stat-card">
            <div className="stat-label">Model Usage</div>
            <div className="stat-value mono">
              <span className="text-green">Kimi {stats.kimiUsage}%</span>
              <span className="text-secondary"> | Claude {stats.claudeUsage}%</span>
              <span className="text-muted"> | Gemini {stats.geminiUsage}%</span>
            </div>
          </div>
          <div className="stat-card">
            <div className="stat-label">Active Domain</div>
            <div className="stat-value">{stats.activeDomain}</div>
          </div>
          <div className="stat-card">
            <div className="stat-label">Health</div>
            <div className="stat-value">
              <span className="text-green">{stats.healthStatus}</span>
            </div>
          </div>
        </section>

        {/* Main Grid */}
        <div className="home-grid">
          {/* Activity Feed */}
          <section className="activity-feed card">
            <div className="section-header">
              <h3>◉ Recent Activity</h3>
              <span className="badge badge-green">LIVE</span>
            </div>
            <div className="activity-list">
              {activities.map((activity, i) => (
                <div key={i} className="activity-item">
                  <span className="activity-time mono">{activity.time}</span>
                  <span className="activity-icon">{activity.icon}</span>
                  <span className="activity-text">{activity.text}</span>
                  <span className="activity-model mono">{activity.model}</span>
                  <span className="activity-duration mono text-muted">{activity.duration}</span>
                </div>
              ))}
            </div>
          </section>

          {/* Pending Decisions */}
          <section className="pending-decisions card">
            <div className="section-header">
              <h3>◐ Pending Decisions</h3>
              <span className="badge badge-amber">1</span>
            </div>
            <div className="decisions-list">
              <div className="decision-card">
                <div className="decision-title">Select Game Concept</div>
                <div className="decision-context">3 concepts proposed. Choose 1, 2, or 3 to proceed with design doc.</div>
                <div className="decision-meta">
                  <span className="text-muted">From: Goku</span>
                  <span className="text-muted">16 min ago</span>
                </div>
                <button className="btn btn-primary">Decide →</button>
              </div>
            </div>
          </section>
        </div>
      </div>

      <style>{`
        .home-page {
          min-height: 100vh;
        }

        .agent-status-bar {
          position: fixed;
          top: 0;
          left: var(--sidebar-width);
          right: 0;
          height: var(--header-height);
          background: var(--bg-secondary);
          border-bottom: 1px solid var(--border-color);
          display: flex;
          align-items: center;
          justify-content: space-between;
          padding: 0 1.5rem;
          z-index: 50;
        }

        .status-left, .status-right {
          display: flex;
          align-items: center;
          gap: 1rem;
        }

        .status-indicator {
          display: flex;
          align-items: center;
          gap: 0.5rem;
        }

        .model-status {
          display: flex;
          gap: 1rem;
          font-family: var(--font-mono);
          font-size: 0.8rem;
        }

        .divider {
          color: var(--border-color);
        }

        .home-content {
          padding: calc(var(--header-height) + 1.5rem) 1.5rem 1.5rem;
        }

        .stats-row {
          display: grid;
          grid-template-columns: repeat(4, 1fr);
          gap: 1rem;
          margin-bottom: 1.5rem;
        }

        .stat-card {
          background: var(--bg-secondary);
          border: 1px solid var(--border-color);
          padding: 1rem;
          transition: border-color var(--transition-fast);
        }

        .stat-card:hover {
          border-color: var(--accent-green-dim);
        }

        .stat-label {
          font-family: var(--font-mono);
          font-size: 0.75rem;
          color: var(--text-muted);
          text-transform: uppercase;
          letter-spacing: 0.1em;
          margin-bottom: 0.5rem;
        }

        .stat-value {
          font-size: 1rem;
          font-weight: 500;
        }

        .home-grid {
          display: grid;
          grid-template-columns: 2fr 1fr;
          gap: 1.5rem;
        }

        .section-header {
          display: flex;
          align-items: center;
          justify-content: space-between;
          margin-bottom: 1rem;
          padding-bottom: 0.75rem;
          border-bottom: 1px solid var(--border-color);
        }

        .section-header h3 {
          font-family: var(--font-mono);
          font-size: 0.9rem;
          font-weight: 500;
          color: var(--text-primary);
        }

        .activity-list {
          display: flex;
          flex-direction: column;
          gap: 0.5rem;
        }

        .activity-item {
          display: flex;
          align-items: center;
          gap: 0.75rem;
          padding: 0.5rem 0;
          font-size: 0.85rem;
          border-bottom: 1px solid var(--bg-tertiary);
        }

        .activity-item:last-child {
          border-bottom: none;
        }

        .activity-time {
          color: var(--text-muted);
          font-size: 0.8rem;
          min-width: 3rem;
        }

        .activity-icon {
          min-width: 1.5rem;
          text-align: center;
        }

        .activity-text {
          flex: 1;
        }

        .activity-model {
          color: var(--accent-blue);
          font-size: 0.8rem;
          min-width: 5rem;
          text-align: right;
        }

        .activity-duration {
          font-size: 0.8rem;
          min-width: 3rem;
          text-align: right;
        }

        .decisions-list {
          display: flex;
          flex-direction: column;
          gap: 1rem;
        }

        .decision-card {
          background: var(--bg-tertiary);
          border: 1px solid var(--border-color);
          padding: 1rem;
          transition: border-color var(--transition-fast);
        }

        .decision-card:hover {
          border-color: var(--accent-amber);
        }

        .decision-title {
          font-weight: 500;
          margin-bottom: 0.5rem;
        }

        .decision-context {
          font-size: 0.85rem;
          color: var(--text-secondary);
          margin-bottom: 0.75rem;
        }

        .decision-meta {
          display: flex;
          justify-content: space-between;
          font-size: 0.75rem;
          margin-bottom: 0.75rem;
        }

        @media (max-width: 1024px) {
          .stats-row {
            grid-template-columns: repeat(2, 1fr);
          }
          .home-grid {
            grid-template-columns: 1fr;
          }
        }
      `}</style>
    </div>
  )
}

export default Home
