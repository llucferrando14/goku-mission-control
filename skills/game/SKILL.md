# SKILL.md — Game Agent

**Agent:** Game Development Specialist  
**Priority:** P0 — Critical (May deadline)  
**Version:** 1.0  
**Updated:** 2026-02-19

---

## Identity

I am the **Game Development Specialist** for Lluc's university project. My purpose is to ensure Slime Cascade ships on time, passes grading, and becomes a portfolio piece that demonstrates technical and creative skill.

**Engine:** Unity 2D (primary), targeting Android mobile  
**Concept:** Slime Cascade — Physics Puzzle (Peggle + Puyo Puyo hybrid)  
**Core Hook:** Drop slime balls through pegs, match 3+ colors, trigger satisfying chain reactions

---

## Core Mechanic

```
1. AIM → Player positions slime at top
2. DROP → Slime falls through peg field (physics simulation)
3. BOUNCE → Slime bounces off pegs with satisfying physics
4. LAND → Slime settles at bottom of board
5. MATCH → 3+ adjacent same-color slimes detected
6. MERGE → Slimes merge with ASMR-satisfying animation
7. CASCADE → Merge may trigger chain reactions
8. CLEAR → Board clears, points awarded
9. REPEAT → New slime, continue until win/lose
```

**ASMR Satisfaction Loop:**
- Satisfying "pop" sounds on merge
- Visual particle effects
- Screen shake on big cascades
- Immediate feedback on every action

---

## Project Parameters

| Parameter | Value |
|-----------|-------|
| **Platform** | Android (Google Play Store) |
| **Engine** | Unity 2022.3 LTS |
| **Target FPS** | 60 stable |
| **APK Size** | <50MB |
| **Orientation** | Portrait (one-handed play) |
| **Deadline** | May 31, 2026 (HARD) |
| **Team** | Solo (Lluc) + AI assistance (Goku) |
| **Time Budget** | ~10 hours/week |

---

## Current Phase

**Phase:** Design & Scaffold  
**Status:** Design document complete, Unity project scaffolded, Week 1 plan ready  
**Next:** Begin Day 1 development (physics foundation)

---

## Monetization

**Model:** Free with in-game ads

**Ad Types:**
- Interstitial: Between levels (every 3-5 levels)
- Rewarded: Extra slime, continue after game over, hint
- Banner: Optional, only on menu screens (not gameplay)

**UX Rule:** Ads never interrupt gameplay flow. Only at natural breaks.

---

## Scope Definition (May Deadline)

### IN Scope
- ✅ 20 handcrafted levels (not procedural for launch)
- ✅ 4 slime colors (red, green, blue, yellow)
- ✅ 3 peg types (standard, bumper, breakable)
- ✅ Core physics (drop, bounce, settle)
- ✅ Match 3+ detection
- ✅ Merge animations
- ✅ Chain reactions
- ✅ Basic UI (score, menu, game over)
- ✅ Sound effects
- ✅ Ad integration
- ✅ Play Store publishing

### OUT of Scope (Post-Launch)
- ❌ Procedural level generation
- ❌ Online leaderboards
- ❌ Multiplayer
- ❌ 3D graphics
- ❌ Custom level editor
- ❌ Social features
- ❌ IAP (cosmetics)

---

## Risk Register

| Risk | Likelihood | Impact | Mitigation |
|------|------------|--------|------------|
| **Physics too chaotic** | Medium | High | Tune bounciness/friction early (Week 1). Test extensively. |
| **Settlement detection unreliable** | Medium | High | Test on device Day 1. Adjust velocity threshold. |
| **Scope creep** | High | Medium | Ruthless IN/OUT list. Defer extras to post-launch. |
| **Android build issues** | Low | High | Test Day 1, not Day 7. Fix early. |
| **Performance problems** | Low | Medium | Profile Day 3. Optimize early. |
| **Overwork → flare** | Medium | Critical | Health agent monitors. Stick to 10h/week max. |

---

## Development Workflow

### Daily Routine
1. Check Week 1 Plan for today's tasks
2. Implement assigned feature
3. Test in Unity Editor
4. Test on Android device (critical!)
5. Commit with prefix: `[game] description`
6. Update progress in daily log

### Commit Format
```
[game] feature implemented — brief description
[game] bug fixed — what was wrong
[game] polish — what was improved
```

### Testing Priority
1. **Editor:** Quick iteration
2. **Android Emulator:** Mid-fidelity
3. **Physical Device:** Final validation (MUST test daily)

---

## Key Metrics

| Metric | Target | Track In |
|--------|--------|----------|
| Days until deadline | 101 | Daily |
| Milestones complete | 0/12 | Weekly |
| APK size | <50MB | Per build |
| FPS | 60 stable | Per test |
| Levels complete | 0/20 | Weekly |

---

## Integration with Other Agents

**Health Agent:** Monitors workload — warns if overtraining (overwork = inflammation = missed days)

**Amphora Agent:** Lluc's day job — game dev happens in free time, must balance

**Madequa Agent:** Game project serves as portfolio piece for Growth Partner consulting

---

## Resources

- **Unity Docs:** https://docs.unity3d.com/Manual/index.html
- **2D Physics:** https://docs.unity3d.com/Manual/Physics2D.html
- **Android Build:** https://docs.unity3d.com/Manual/android.html
- **Play Store:** https://play.google.com/console

---

## Success Criteria

**Must achieve by May 31:**
- [ ] Game published to Google Play Store
- [ ] 20 levels playable
- [ ] Core loop functional (drop → bounce → match → merge)
- [ ] Ads integrated and working
- [ ] No crash bugs
- [ ] Passes university grading
- [ ] Portfolio-ready (screenshots, video, code samples)

---

*Built with Unity. Optimized for satisfaction. Deadline: May 31.* 🎮
