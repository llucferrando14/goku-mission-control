# Slime Cascade

**Physics Puzzle Game | Unity 2D | Android**

*Drop. Bounce. Merge. Explode.*

---

## Project Overview

Slime Cascade is a mobile physics puzzle game where players drop colored slime balls through a field of pegs, creating satisfying chain reactions as colors match and merge.

- **Platform:** Android (Google Play Store)
- **Engine:** Unity 2022.3 LTS
- **Timeline:** 10 weeks (Feb 19 → May 31, 2026)
- **Target:** 60fps, <50MB APK, one-handed play

---

## Quick Links

- 📄 [Design Document](../../research/game-design-document-slime-cascade.md)
- 🎮 [Week 1 Plan](../memory/projects/game-project/week-01-plan.md)
- 🐛 [Issue Tracker](../../TASK_QUEUE.md)

---

## Project Structure

```
slime-cascade/
├── Assets/
│   ├── Scripts/
│   │   ├── Core/          # Game logic
│   │   │   ├── GameManager.cs
│   │   │   ├── SlimeController.cs
│   │   │   ├── PegBoard.cs
│   │   │   ├── ColorMatcher.cs
│   │   │   └── ChainReaction.cs
│   │   ├── UI/            # Interface
│   │   │   ├── ScoreDisplay.cs
│   │   │   ├── GameOver.cs
│   │   │   └── MainMenu.cs
│   │   └── Ads/           # Monetization
│   │       └── AdManager.cs
│   ├── Prefabs/           # Reusable objects
│   ├── Scenes/            # Unity scenes
│   └── Art/               # Sprites, animations
├── Docs/                  # Documentation
└── README.md              # This file
```

---

## Setup Instructions

### Prerequisites
- Unity 2022.3 LTS or newer
- Android Build Support module
- JDK 11+
- Android SDK

### Open Project
1. Open Unity Hub
2. Add project from `~/.openclaw/workspace/projects/slime-cascade/`
3. Open with Unity 2022.3 LTS

### Build Settings
1. File → Build Settings
2. Switch Platform → Android
3. Player Settings:
   - Package Name: `com.llucferrando.slimecascade`
   - Minimum API Level: 24 (Android 7.0)
   - Target API Level: 34 (Android 14)
   - Scripting Backend: IL2CPP
   - Target Architectures: ARM64

---

## Core Dependencies

### Unity Packages (Built-in)
- 2D Physics (Physics2D)
- Input System (new)
- UI Toolkit (optional)

### Third-Party (if needed)
- **DOTween** (animation) - free version
- **TextMeshPro** (text rendering) - built-in

---

## Development Workflow

### Daily Routine
1. Check [Week Plan](../memory/projects/game-project/week-01-plan.md)
2. Implement assigned feature
3. Test on device/emulator
4. Commit with prefix: `[game] description`
5. Update progress in TASK_QUEUE.md

### Testing
- **Editor:** Quick iteration
- **Android Emulator:** Mid-fidelity
- **Physical Device:** Final validation (critical!)

---

## Build & Deploy

### Development Build
```bash
# In Unity
File → Build Settings → Build
Output: APK for testing
```

### Release Build
```bash
# Final APK for Play Store
File → Build Settings → Build
Enable: Minify, IL2CPP, ARM64 only
Expected size: <50MB
```

### Play Store Upload
1. Build AAB (Android App Bundle)
2. Google Play Console → Create Release
3. Upload AAB
4. Fill store listing (screenshots, description)
5. Submit for review

---

## Key Metrics

| Metric | Target | Current |
|--------|--------|---------|
| APK Size | <50MB | TBD |
| FPS | 60 stable | TBD |
| Load Time | <3s | TBD |
| Crash Rate | <1% | TBD |
| Levels | 20 | 0/20 |

---

## Team

- **Developer:** Lluc Ferrando
- **AI Assistant:** Goku
- **Advisor:** University Professor [TBD]

---

## License

© 2026 Lluc Ferrando. All rights reserved.

---

*Built with Unity. Optimized for satisfaction.* 🎮
