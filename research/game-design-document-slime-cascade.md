# Game Design Document — Slime Cascade

**Version:** 1.0  
**Date:** February 19, 2026  
**Developer:** Lluc Ferrando  
**Platform:** Android (Google Play Store)  
**Engine:** Unity 2D  
**Timeline:** 10 weeks (Feb 19 → May 31, 2026)

---

## 1. Game Title & Tagline

**Title:** Slime Cascade  
**Working Title:** Project Cascade  
**Tagline:** *"Drop. Bounce. Merge. Explode."*  
**Alternative Tagline:** *"Physics meets satisfaction."*

---

## 2. Core Gameplay

### 2.1 The Hook
Every drop creates a cascade of satisfying physics: slime balls bounce through pegs, colors merge with satisfying pops, and chain reactions clear the board in spectacular fashion. Engineered for the TikTok algorithm.

### 2.2 Core Loop

```
1. AIM → Player aims slime drop from top
2. DROP → Slime falls, bounces through peg field
3. LAND → Slime settles at bottom
4. MATCH → 3+ adjacent same-color slimes merge
5. CASCADE → Merges cause chain reactions
6. CLEAR → Board clears, points awarded
7. REPEAT → New slime appears, continue
```

### 2.3 Mechanics Deep Dive

#### Slime Physics
- **Shape:** Perfect circles (CircleCollider2D)
- **Bounce:** Unity 2D physics with bouncy material (friction: 0.1, bounciness: 0.7)
- **Gravity:** Standard Unity gravity (adjustable per level)
- **Sleep Threshold:** 0.05 (prevents endless micro-bouncing)

#### Peg Field
- **Layout:** Procedurally generated per level
- **Types:**
  - Standard peg (fixed, circular)
  - Bumper peg (adds extra bounce)
  - Moving peg (oscillates horizontally)
  - Breakable peg (destroys after N hits)

#### Color Matching
- **Colors:** 4 base colors (Red, Blue, Green, Yellow)
- **Match Rule:** 3+ touching slimes of same color merge
- **Merge Animation:**
  - Slimes squash together (0.3s)
  - Particle burst at merge point
  - Satisfying "pop" sound
  - Screen shake (subtle, 0.1s)

#### Chain Reactions
- When slimes merge, they shrink and disappear
- This creates gaps
- Physics causes upper slimes to fall
- New matches may form → cascade continues
- **Combo Multiplier:** 2x, 3x, 4x+ for consecutive matches

#### Scoring
- **Base match:** 100 points × slime size
- **Chain bonus:** ×2, ×3, ×4 for cascades
- **Style bonus:** Long bounces, precise shots
- **Clear bonus:** Empty board = 1000 points

#### Game Over
- Trigger: Any slime touches the top line
- Grace: 3-second warning (line flashes red)
- Final score displayed with share button

---

## 3. Platform & Technical Requirements

### 3.1 Target Platform
- **Primary:** Android (Google Play Store)
- **Minimum API:** Android 8.0 (API 26)
- **Target API:** Android 14 (API 34)

### 3.2 Performance Targets
- **FPS:** Locked 60fps
- **Load Time:** <3 seconds to gameplay
- **APK Size:** <50MB
- **Memory:** <150MB RAM usage

### 3.3 Device Support
- **Minimum:** Mid-tier Android (Snapdragon 660 equivalent)
- **Target:** Flagship from 2022+
- **Test Devices:** [To be confirmed]

---

## 4. Art Style Direction

### 4.1 Visual Philosophy
**"Juicy minimalism"** — Clean, readable, satisfying

### 4.2 Color Palette

**Background:** Near-black `#0a0a0f` (Mission Control aesthetic continuity)

**Slime Colors:**
- Red: `#ff4757` (bright, energetic)
- Blue: `#3742fa` (calm, trustworthy)
- Green: `#2ed573` (growth, money)
- Yellow: `#ffa502` (warning, attention)

**UI Colors:**
- Primary: Electric green `#00ff88`
- Secondary: White `#ffffff`
- Accent: Amber `#ffaa00` (warnings)

### 4.3 Slime Visuals
- **Base:** Solid color circles
- **Highlight:** Subtle gradient (top-left lighter)
- **Shine:** Small white specular highlight (gives "wet" look)
- **Squash/Stretch:** Scale Y 0.8-1.2 on impact/bounce (juice)
- **Merge Glow:** White glow pulse on merge

### 4.4 Peg Visuals
- **Standard:** White circle, subtle drop shadow
- **Bumper:** Yellow/orange, glows on hit
- **Moving:** Animated position
- **Breakable:** Cracks appear with each hit

### 4.5 Particle Effects
- **Merge Pop:** 12 particles, same color as slime
- **Bounce Spark:** Small white sparks on hard impacts
- **Chain Lightning:** White arc between merging slimes

### 4.6 UI Design
- **Score:** Large, top-center, electric green
- **Next Slime:** Preview next color (top-right)
- **Combo Counter:** Appears during chains, fades out
- **Menu:** Minimal, pause button only during gameplay

---

## 5. Audio Direction

### 5.1 Philosophy
**ASMR + Arcade** — Satisfying, rhythmic, dopamine-triggering

### 5.2 Sound Categories

#### Slime Sounds
- **Bounce (light):** Soft "bloop" — pitch varies by velocity
- **Bounce (hard):** Deeper "thud" — screen shake accompanies
- **Merge:** Satisfying "pop" with reverb tail
- **Chain reaction:** Escalating pitch pops ( musical)

#### UI Sounds
- **Button press:** Clean click
- **Score increment:** Digital chime
- **Game over:** Descending tone
- **High score:** Victory fanfare (simple, 3 notes)

#### Background
- **Music:** Optional lo-fi beats (can be disabled)
- **Ambient:** Subtle slime "gloop" atmosphere

### 5.3 Technical
- **Engine:** Unity Audio Mixer
- **Format:** WAV (uncompressed for responsiveness)
- **Priority:** SFX > Music (can mute music, keep SFX)

---

## 6. UI/UX Design Principles

### 6.1 One-Handed Play
- **Aim:** Drag anywhere on screen
- **Drop:** Release to shoot
- **No other inputs needed**

### 6.2 Visual Feedback
- Every action has immediate visual response
- Slimes squash on impact
- Screen shakes on big merges
- Score counts up (animated)

### 6.3 Clarity
- Board state readable at glance
- Colorblind mode (symbols on slimes)
- Clear danger zone (top line)

### 6.4 Flow
- **Main Menu:** Play, Settings, Leaderboard
- **Gameplay:** Aim → Drop → Result → Repeat
- **Game Over:** Score, Share, Retry, Menu

### 6.5 Sessions
- **Target session:** 2-5 minutes
- **Pause:** Anytime, instant resume
- **Progress:** Saved automatically

---

## 7. Technical Architecture

### 7.1 Unity Setup

**Version:** 2022.3 LTS (Long Term Support)

**Packages:**
- 2D Animation
- 2D Physics
- Input System (new)
- Mobile Notifications (optional)
- Advertisement (Unity Ads or Google AdMob)

**Scene Structure:**
```
MainScene
├── Camera
├── Canvas (UI)
│   ├── ScoreText
│   ├── NextSlimePreview
│   └── PauseButton
├── GameBoard
│   ├── SlimeContainer
│   ├── PegContainer
│   └── DangerLine
├── ParticlePool
├── AudioManager
└── GameManager (singleton)
```

### 7.2 Core Components

#### Slime.cs
```csharp
public class Slime : MonoBehaviour
{
    public SlimeColor color;
    public int size; // 1 = normal, 2 = big, 3 = huge
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Bounce sound, squash animation
    }
    
    void CheckForMatches()
    {
        // Find adjacent same-color slimes
        // If >= 3, trigger merge
    }
}
```

#### Peg.cs
```csharp
public class Peg : MonoBehaviour
{
    public PegType type;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (type == PegType.Bumper)
            // Add extra force
        if (type == PegType.Breakable)
            // Reduce health, maybe break
    }
}
```

#### GameManager.cs
```csharp
public class GameManager : MonoBehaviour
{
    // State management
    // Score tracking
    // Level progression
    // Ad triggers
}
```

### 7.3 Physics Settings

**Physics2D Settings:**
- Gravity: -9.81 (default)
- Velocity Iterations: 8
- Position Iterations: 3
- Sleep Threshold: 0.05

**Material (Slime):**
- Friction: 0.1
- Bounciness: 0.7

**Material (Peg):**
- Friction: 0.4
- Bounciness: 0.5

### 7.4 Optimization

**Object Pooling:**
- Slimes pre-allocated (50 instances)
- Particles pre-allocated
- Pegs static (no pooling needed)

**Mobile Optimization:**
- Target 60fps
- Batching: Static pegs batched
- Max slimes on screen: 100 (merge when exceeded)

---

## 8. Scope Definition

### 8.1 IN (Must Have for May 31)

**Core Gameplay:**
- [ ] Basic slime physics (drop, bounce, land)
- [ ] Color matching (3+ merge)
- [ ] Chain reactions
- [ ] Score system
- [ ] Game over condition

**Content:**
- [ ] 20 handcrafted levels
- [ ] 3 slime colors minimum (stretch to 4)
- [ ] 3 peg types (standard, bumper, moving)

**Tech:**
- [ ] 60fps on mid-tier Android
- [ ] Clean UI (score, next slime, pause)
- [ ] Sound effects (bounce, merge, game over)

**Monetization:**
- [ ] Interstitial ads (every 3 games)
- [ ] Rewarded ads (continue after game over)

**Polish:**
- [ ] Juice (particles, screen shake, squash/stretch)
- [ ] ASMR-quality sounds
- [ ] Main menu + game over screens

### 8.2 OUT (Post-Launch or Cut)

**Features:**
- [ ] Multiplayer
- [ ] Level editor
- [ ] Social features (friends, chat)
- [ ] Complex narrative
- [ ] 3D graphics
- [ ] Advanced AI

**Content:**
- [ ] 100+ levels (launch with 20, add later)
- [ ] Multiple worlds/themes
- [ ] Character customization
- [ ] Power-ups (would add complexity)

**Tech:**
- [ ] Online leaderboards (use local only)
- [ ] Cloud saves (local only for launch)
- [ ] Analytics (add later if needed)

---

## 9. Week-by-Week Milestone Plan

### Week 1 (Feb 19-25): Foundation
**Focus:** Project setup, core physics
**Deliverables:**
- [ ] Unity project created
- [ ] Basic slime prefab (physics working)
- [ ] Basic peg field
- [ ] Slime drops and bounces
- [ ] Slime lands and stays

**Success:** Can drop a slime, it bounces and lands.

### Week 2 (Feb 26-Mar 4): Matching
**Focus:** Color matching system
**Deliverables:**
- [ ] 3-4 slime colors
- [ ] Adjacency detection
- [ ] Merge animation
- [ ] Score system
- [ ] Basic particles

**Success:** Can create matches, see merge animation.

### Week 3 (Mar 5-11): Chains & Juice
**Focus:** Chain reactions, visual polish
**Deliverables:**
- [ ] Chain reaction system
- [ ] Combo multiplier
- [ ] Screen shake
- [ ] Better particles
- [ ] Sound effects (placeholder)

**Success:** Chain reactions work, game feels satisfying.

### Week 4 (Mar 12-18): Game Loop
**Focus:** Complete game loop, UI
**Deliverables:**
- [ ] Game over detection
- [ ] Score display
- [ ] Next slime preview
- [ ] Main menu
- [ ] Game over screen

**Success:** Can play full game from menu to game over.

### Week 5 (Mar 19-25): Levels & Progression
**Focus:** Level design, difficulty curve
**Deliverables:**
- [ ] 10 handcrafted levels
- [ ] Level select
- [ ] Progressive difficulty
- [ ] Peg variety (bumper, moving)

**Success:** 10 levels playable, difficulty ramps well.

### Week 6 (Mar 26-Apr 1): Audio & Polish
**Focus:** ASMR audio, visual polish
**Deliverables:**
- [ ] All sound effects (final)
- [ ] Background music (optional)
- [ ] Visual polish pass
- [ ] Animation improvements

**Success:** Audio is satisfying, visuals polished.

### Week 7 (Apr 2-8): Ads & Monetization
**Focus:** Ad integration
**Deliverables:**
- [ ] Unity Ads or AdMob integrated
- [ ] Interstitial ads working
- [ ] Rewarded ads for continues
- [ ] Test on device

**Success:** Ads show, don't break gameplay.

### Week 8 (Apr 9-15): Content & Levels
**Focus:** More levels, final content
**Deliverables:**
- [ ] 20 total levels
- [ ] Final level tuning
- [ ] Colorblind mode
- [ ] Settings menu

**Success:** 20 levels complete, all features in.

### Week 9 (Apr 16-22): Testing & Bugs
**Focus:** QA, bug fixes, optimization
**Deliverables:**
- [ ] Playtest on 3+ devices
- [ ] Bug fixes
- [ ] Performance optimization
- [ ] 60fps locked

**Success:** No critical bugs, runs smoothly.

### Week 10 (Apr 23-29): Store Prep
**Focus:** Play Store submission
**Deliverables:**
- [ ] Screenshots (5)
- [ ] Store description
- [ ] Feature graphic
- [ ] Privacy policy
- [ ] APK signed and uploaded

**Success:** Game submitted to Play Store.

### Week 11-12 (Apr 30-May 31): BUFFER
**Do not touch unless critical bugs found.**

---

## 10. Risk Register

| Risk | Likelihood | Impact | Mitigation |
|------|------------|--------|------------|
| **Physics finickiness** | High | High | Simple circles only, extensive testing, generous collision |
| **Scope creep** | High | High | Ruthless IN/OUT list, weekly scope checks |
| **Performance issues** | Medium | High | Profile early, object pool, limit max slimes |
| **Audio quality poor** | Medium | Medium | Use professional SFX packs if needed |
| **Ad integration breaks** | Low | Medium | Test ads early, have fallback |
| **Health flare during crunch** | Low | High | Build buffer weeks, prioritize rest |
| **Unity physics edge cases** | Medium | Medium | Simple physics, avoid complex scenarios |

---

## 11. Monetization Strategy

### 11.1 Model
**Free with Ads** — No upfront cost, monetize through advertising.

### 11.2 Ad Types

**Interstitial (Full-screen):**
- Trigger: Every 3 game over screens
- Frequency: ~1 per 5-7 minutes of play
- Skip: Non-skippable (5 seconds)

**Rewarded (Opt-in):**
- Trigger: Game over → "Watch ad to continue?"
- Reward: Continue current game
- Limit: Max 2 continues per game

**Banner:**
- Decision: **NO** — ruins aesthetic
- Alternative: Occasional interstitial only

### 11.3 Revenue Projections
**Conservative:** $50-200/month (first 6 months)
**Optimistic:** $500+/month (if viral)

**Reality:** This is a university project. Revenue is bonus, learning is primary.

---

## 12. Viral/Distribution Strategy

### 12.1 TikTok/Shorts Strategy
**Goal:** Every gameplay session creates shareable moments.

**Clip-Worthy Moments:**
- Long chain reactions (5+ merges)
- Near-miss saves
- Epic bounce sequences
- Perfect clear (empty board)

**Built-in Feature:** "Clip Mode"
- Auto-captures last 15 seconds on request
- One-tap export to TikTok/Reels/Shorts
- Vertical 9:16 crop
- Watermark: "Slime Cascade — Link in bio"

### 12.2 Launch Strategy
1. **Soft Launch:** Friends/family test
2. **Reddit:** r/IndieGaming, r/AndroidGaming
3. **TikTok:** Post clips, hashtag #SlimeCascade
4. **Discord:** Indie game dev communities

### 12.3 ASO (App Store Optimization)
**Title:** Slime Cascade — Physics Puzzle  
**Keywords:** puzzle, physics, satisfying, ASMR, casual, merge  
**Description:** Emphasize "satisfying physics" and "perfect for short breaks"

---

## 13. Success Metrics

### 13.1 Technical
- [ ] 60fps on mid-tier Android
- [ ] <50MB APK size
- [ ] <3 second load time
- [ ] Zero crashes in 100 test plays

### 13.2 Design
- [ ] Playtester understands core mechanic in <30 seconds
- [ ] Average session >3 minutes
- [ ] Chain reactions feel "magical"
- [ ] Audio is satisfying (ASMR quality)

### 13.3 Academic
- [ ] Submitted before May 31 deadline
- [ ] Demonstrates design thinking
- [ ] Unique concept (not generic clone)
- [ ] Clean code and documentation

### 13.4 Commercial (Stretch)
- [ ] 100+ downloads in first month
- [ ] 3.5+ star rating
- [ ] Featured on r/IndieGaming

---

## 14. Open Questions

1. **Exact Unity version?** → Confirm with Lluc
2. **Ad provider?** → Unity Ads vs AdMob
3. **Audio source?** → Generate, buy pack, or commission?
4. **Colorblind mode priority?** → Nice to have vs must have?
5. **Analytics?** → Unity Analytics or none?

---

## 15. Appendix

### A. Reference Games
- **Peggle:** Bounce physics reference
- **Puyo Puyo:** Color matching reference
- **Voodoo games:** Viral/mobile polish reference

### B. Tools & Assets
- **Engine:** Unity 2022.3 LTS
- **Audio:** bfxr (generation) or SFX pack
- **Font:** Inter (Google Fonts, free)

### C. Documentation
- Unity 2D Physics Manual
- Google Play Console Help
- Mobile Game Optimization Guide

---

*Document Version: 1.0*  
*Last Updated: 2026-02-19*  
*Next Review: End of Week 1 (Feb 25)*
