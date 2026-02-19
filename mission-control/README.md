# GOKU — Mission Control Dashboard

*Session 1 Complete* | *v0.1.0-alpha*

## What This Is
Your operational command center. Everything Goku does, visible in one place. Dark. Dense. Operator-grade.

## Stack
- **Frontend:** React 18 + Vite (port 3000)
- **Backend:** Node.js + Express (port 3001)
- **Styling:** Custom CSS, JetBrains Mono + Inter fonts
- **File Watching:** chokidar for real-time workspace monitoring

## Quick Start

```bash
cd ~/.openclaw/workspace/mission-control/
npm run dev
```

This starts both frontend and backend concurrently:
- Dashboard: http://localhost:3000
- API: http://localhost:3001

## Session 1 Deliverables ✅

### Frontend
- [x] React + Vite scaffolding
- [x] Dark mission-control aesthetic (CSS variables, scanlines, green accents)
- [x] Sidebar navigation with 5 pages
- [x] **Home Page:**
  - Agent Status Bar (tier, models, heartbeat)
  - Quick Stats Row (4 cards)
  - Activity Feed (reads from daily logs)
  - Pending Decisions panel

### Backend
- [x] Express server with CORS
- [x] `/api/health` — Health check
- [x] `/api/status` — Goku's current status
- [x] `/api/activity` — Parse daily logs for activity feed
- [x] `/api/tasks` — List pending/done tasks
- [x] `/api/tasks` (POST) — Create new task
- [x] `/api/memory/*` — Read any workspace file
- [x] `/api/list/*` — List directory contents
- [x] File watcher scaffolding (ready for Telegram bridge)

### DevOps
- [x] Concurrent dev script (frontend + backend)
- [x] Proxy config (frontend → backend API)
- [x] Security: Path validation on file reads

## Session 2 Roadmap

1. **Kanban Board** — Task management with drag-drop
2. **Task Creation Modal** — Two-way control (you → Goku)
3. **Domains Page** — 6 domain cards with detail view
4. **Memory Browser** — File tree + markdown viewer
5. **Telegram Bridge** — Auto-notify on new tasks
6. **Real-time Updates** — SSE for file changes

## API Endpoints

```
GET  /api/health          → { status: "ok" }
GET  /api/status          → Goku's current state
GET  /api/activity        → Recent activity from logs
GET  /api/tasks           → { pending: [], done: [] }
POST /api/tasks           → Create new task
GET  /api/memory/*        → Read file contents
GET  /api/list/*          → List directory
```

## File Structure

```
mission-control/
├── frontend/
│   ├── src/
│   │   ├── components/
│   │   │   └── Sidebar.jsx
│   │   ├── pages/
│   │   │   └── Home.jsx
│   │   ├── App.jsx
│   │   ├── main.jsx
│   │   └── index.css
│   ├── index.html
│   ├── package.json
│   └── vite.config.js
├── backend/
│   ├── server.js
│   ├── fileWatcher.js
│   └── package.json
└── package.json
```

## Environment

Requires:
- Node.js 18+
- Workspace at `~/.openclaw/workspace/`

## Design Tokens

| Token | Value | Usage |
|-------|-------|-------|
| `--bg-primary` | `#0a0a0f` | Page background |
| `--bg-secondary` | `#111118` | Cards, sidebar |
| `--accent-green` | `#00ff88` | Primary accent, online status |
| `--accent-blue` | `#0088ff` | Secondary, links |
| `--accent-amber` | `#ffaa00` | Warnings, pending |
| `--accent-red` | `#ff3344` | Critical, offline |
| `--font-mono` | JetBrains Mono | Data, code |
| `--font-sans` | Inter | Prose, UI |

## Known Issues

- Browser screenshot unavailable (Chrome extension not connected)
- File watcher runs standalone, not integrated with backend yet
- No persistent storage (pure file-based)

## Next Steps

1. Test the dashboard at http://localhost:3000
2. Report any visual/functional issues
3. Prioritize Session 2 features

---

Built by Goku | Tier 1 BUILDER | Session 1 of 3
