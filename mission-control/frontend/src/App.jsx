import React, { useState, useEffect } from 'react'
import { Routes, Route } from 'react-router-dom'
import Sidebar from './components/Sidebar'
import Home from './pages/Home'

function App() {
  const [gokuStatus, setGokuStatus] = useState({
    online: true,
    tier: 'TIER 1 BUILDER',
    activeTask: 'Building Mission Control Dashboard',
    lastHeartbeat: '2min ago',
    models: {
      kimi: true,
      claude: true,
      gemini: true
    }
  })

  useEffect(() => {
    // Poll backend for status every 5 seconds
    const pollStatus = async () => {
      try {
        const res = await fetch('/api/status')
        if (res.ok) {
          const data = await res.json()
          setGokuStatus(data)
        }
      } catch (err) {
        console.log('Backend not ready yet')
      }
    }

    pollStatus()
    const interval = setInterval(pollStatus, 5000)
    return () => clearInterval(interval)
  }, [])

  return (
    <div className="app">
      <Sidebar />
      <main className="main-content">
        <Routes>
          <Route path="/" element={<Home status={gokuStatus} />} />
        </Routes>
      </main>
    </div>
  )
}

export default App
