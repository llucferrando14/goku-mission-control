# Slime Cascade — Week 1 Milestone Plan

**Dates:** February 19-25, 2026  
**Goal:** Core Physics Foundation + First Playable Prototype  
**Deadline:** Sunday Feb 25, EOD

---

## 📋 Week Overview

| Day | Focus | Deliverable | Success Criteria |
|-----|-------|-------------|------------------|
| **Wed 19** | Project Setup | Unity project configured, folder structure | Project opens without errors |
| **Thu 20** | Core Physics (Part 1) | Slime dropping + peg collisions | Slime falls, bounces off pegs |
| **Fri 21** | Core Physics (Part 2) | Slime settling + queue system | Slimes stack at bottom, settle correctly |
| **Sat 22** | Color Matching | Match detection algorithm | 3+ touching same-color slimes detected |
| **Sun 23** | Chain Reactions | Cascade system + scoring | Matches trigger chain reactions |
| **Mon 24** | UI Foundation | Score display + game flow | Can play full round, see score |
| **Tue 25** | Polish & Buffer | Visual feedback + bug fixes | Smooth gameplay, no critical bugs |

---

## 🎯 Day-by-Day Breakdown

### **Wednesday, Feb 19 — PROJECT SETUP** ✅
**Status:** Complete (done by Goku)

- ✅ Unity project structure scaffolded
- ✅ Core script stubs written (GameManager, SlimeController, PegBoard, ColorMatcher, ChainReaction)
- ✅ README.md with setup instructions
- ✅ Git repo linked

**Next:** Open in Unity, verify no compilation errors

---

### **Thursday, Feb 20 — CORE PHYSICS (PART 1)**
**Focus:** SlimeController implementation + basic peg collisions

**Morning:**
- [ ] Open project in Unity 2022.3 LTS
- [ ] Fix any compilation errors in stubs
- [ ] Create basic slime prefab (CircleCollider2D, Rigidbody2D, SpriteRenderer)
- [ ] Implement SlimeController.Initialize() and basic color assignment

**Afternoon:**
- [ ] Implement SlimeController.Drop() - apply gravity, initial velocity
- [ ] Create basic peg prefab (static CircleCollider2D)
- [ ] Test: Slime drops from top, falls through gravity

**Evening:**
- [ ] Implement OnCollisionEnter2D() for bounce feedback
- [ ] Test: Slime bounces off pegs realistically
- [ ] Commit: `[game] day 2 - slime physics and peg collisions`

**Success Criteria:**
- Can spawn slime at top
- Slime falls naturally with gravity
- Slime bounces off pegs with satisfying physics

---

### **Friday, Feb 21 — CORE PHYSICS (PART 2)**
**Focus:** Slime settling + queue management

**Morning:**
- [ ] Implement velocity checking in FixedUpdate()
- [ ] Implement HasSettled() detection (velocity < threshold)
- [ ] Implement SlimeController.Settle() - change state, scale down

**Afternoon:**
- [ ] Create SlimeQueue system (next slime preview)
- [ ] Implement aim/aiming indicator
- [ ] Test: Can aim left/right, drop slime in different positions

**Evening:**
- [ ] Prevent slimes from settling on top of each other (stacking)
- [ ] Implement basic bottom boundary
- [ ] Commit: `[game] day 3 - slime settling and queue system`

**Success Criteria:**
- Slimes settle at bottom when they stop moving
- Can aim and drop multiple slimes
- Slimes stack properly without overlapping

---

### **Saturday, Feb 22 — COLOR MATCHING**
**Focus:** Match detection algorithm

**Morning:**
- [ ] Implement ColorMatcher.RegisterSettledSlime()
- [ ] Create color grouping logic
- [ ] Implement FindConnectedGroup() using flood fill/BFS

**Afternoon:**
- [ ] Implement AreSlimesTouching() distance check
- [ ] Implement CheckForMatches() - iterate all settled slimes
- [ ] Test: 3 same-color slimes touching = match detected

**Evening:**
- [ ] Add match highlighting (visual feedback)
- [ ] Implement CalculateMatchScore()
- [ ] Commit: `[game] day 4 - color matching detection`

**Success Criteria:**
- System detects when 3+ same-color slimes are touching
- Matched slimes are highlighted
- Score is calculated based on match size

---

### **Sunday, Feb 23 — CHAIN REACTIONS**
**Focus:** Cascade system + scoring multipliers

**Morning:**
- [ ] Implement ChainReaction.StartChain()
- [ ] Implement AddChainLink() for each consecutive match
- [ ] Create chain multiplier system (x2, x3, x4...)

**Afternoon:**
- [ ] Implement merge animations (slimes move together)
- [ ] Add chain counter UI (floating text)
- [ ] Implement ChainReaction.EndChain()

**Evening:**
- [ ] Add visual feedback for chains (screen shake, flash)
- [ ] Test full chain: drop → match → cascade → new match
- [ ] Commit: `[game] day 5 - chain reactions and scoring`

**Success Criteria:**
- Chain reactions work automatically
- Score multipliers increase with chain depth
- Visual feedback makes chains feel satisfying

---

### **Monday, Feb 24 — UI FOUNDATION**
**Focus:** Score display + game flow

**Morning:**
- [ ] Create ScoreDisplay UI (Canvas, TextMeshPro)
- [ ] Hook up GameManager scoring to UI
- [ ] Implement MainMenu (Start Game, Instructions)

**Afternoon:**
- [ ] Implement GameOver screen
- [ ] Add turn counter / slimes remaining
- [ ] Create basic level progression (Level 1, 2, 3...)

**Evening:**
- [ ] Test full game loop: Menu → Play → Match → Game Over
- [ ] Fix any critical bugs
- [ ] Commit: `[game] day 6 - UI and game flow`

**Success Criteria:**
- Can play full game from menu to game over
- Score updates in real-time
- Game state transitions work smoothly

---

### **Tuesday, Feb 25 — POLISH & BUFFER**
**Focus:** Visual polish + bug fixes + Week 2 prep

**Morning:**
- [ ] Add particle effects for matches
- [ ] Improve slime visuals (colors, shading)
- [ ] Add sound effect placeholders (even if just console.log)

**Afternoon:**
- [ ] Bug hunt: fix physics glitches, match detection edge cases
- [ ] Optimize: ensure 60fps on target device
- [ ] Build APK and test on Android device

**Evening:**
- [ ] Document Week 1 learnings
- [ ] Plan Week 2 milestones (UI polish, audio, more levels)
- [ ] Commit: `[game] week 1 complete - playable prototype`

**Success Criteria:**
- Smooth 60fps gameplay
- No critical bugs
- Playable on Android device
- Ready for Week 2 feature development

---

## 📊 Success Metrics

### Functional
- [ ] Slime physics feel good (weighty but bouncy)
- [ ] Matches detect correctly (no false positives/negatives)
- [ ] Chain reactions work automatically
- [ ] Score displays and updates correctly
- [ ] Game loop complete (menu → play → game over)

### Performance
- [ ] 60fps stable in Unity Editor
- [ ] <50MB memory usage
- [ ] No physics glitches or frame drops

### Quality
- [ ] Code is documented
- [ ] Commits are regular and descriptive
- [ ] Project structure is clean

---

## ⚠️ Risk Mitigation

| Risk | Mitigation |
|------|------------|
| Unity physics too finicky | Use 2D physics, tune bounciness/friction early |
| Match detection bugs | Visual debug mode showing detection radii |
| Scope creep | STRICTLY defer non-essential features to Week 2+ |
| Device performance issues | Test on actual Android device by Friday |
| Time overrun | Daily checkpoints - if behind, cut scope ruthlessly |

---

## 📝 Daily Checklist Template

Each day, update this:

```
Date: [Day]
Commits: [Number]
Lines Added: [Approx]
Blockers: [Any issues?]
Tomorrow: [Plan]
```

---

## 🎮 Week 1 Definition of Done

**Playable Prototype Means:**
1. Press Play in Unity
2. Menu appears
3. Click Start
4. Can aim and drop slimes
5. Slimes bounce through pegs
6. Same-color matches detect
7. Chains cascade automatically
8. Score updates
9. Game ends when board full
10. Can restart

**If all 10 work → Week 1 SUCCESS** ✅

---

*Week 1 is about PROOF OF CONCEPT. If the core loop isn't fun by Sunday, we pivot.*
