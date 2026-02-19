# Week 1 Milestone Plan — Slime Cascade

**Week:** February 19-25, 2026  
**Goal:** Core Foundation — Physics & Basic Mechanics  
**Deliverable:** First playable prototype (slime drops, bounces, settles)

---

## 🎯 Week 1 Objectives

By end of Week 1, we should have:
- ✅ Unity project fully configured
- ✅ Basic physics (slime drops, bounces off pegs)
- ✅ Aim and drop controls
- ✅ Slime settlement detection
- ✅ Simple UI (score display, basic menu)
- ✅ **Playable:** Can drop slimes and see them bounce

---

## 📅 Day-by-Day Breakdown

### **Day 1 — Wednesday, Feb 19** (TODAY)
**Focus:** Project Setup & Physics Foundation

| Task | Time | Status |
|------|------|--------|
| ✅ Create Unity project structure | 30m | DONE |
| ✅ Write core script stubs | 1h | DONE |
| [ ] Open project in Unity, configure build settings | 30m | TODO |
| [ ] Import 2D Physics package | 15m | TODO |
| [ ] Create basic slime prefab (Circle sprite + Rigidbody2D) | 30m | TODO |
| [ ] Configure physics materials (bounciness, friction) | 30m | TODO |
| [ ] Test: Drop slime, watch it fall | 15m | TODO |

**End of Day 1 Deliverable:** Slime falls with gravity

---

### **Day 2 — Thursday, Feb 20**
**Focus:** Peg Field & Collision

| Task | Time | Status |
|------|------|--------|
| [ ] Create peg prefab (Circle sprite, static collider) | 30m | TODO |
| [ ] Build PegBoard generation (grid layout) | 1h | TODO |
| [ ] Place 20+ pegs in scene | 30m | TODO |
| [ ] Test: Slime bounces through pegs | 30m | TODO |
| [ ] Adjust bounce physics (not too chaotic) | 30m | TODO |
| [ ] Add boundary colliders (walls, floor) | 30m | TODO |

**End of Day 2 Deliverable:** Slime bounces realistically through peg field

---

### **Day 3 — Friday, Feb 21**
**Focus:** Aim & Drop Controls

| Task | Time | Status |
|------|------|--------|
| [ ] Implement aim mechanic (mouse/touch position) | 1h | TODO |
| [ ] Visual aim line/trajectory preview | 1h | TODO |
| [ ] Drop on click/tap | 30m | TODO |
| [ ] Prevent drops while slimes are settling | 30m | TODO |
| [ ] Add drop cooldown (0.5s between drops) | 15m | TODO |
| [ ] Test: Smooth aiming and dropping | 30m | TODO |

**End of Day 3 Deliverable:** Can aim and drop slimes with visual feedback

---

### **Day 4 — Saturday, Feb 22**
**Focus:** Settlement Detection & State Machine

| Task | Time | Status |
|------|------|--------|
| [ ] Implement velocity monitoring | 45m | TODO |
| [ ] Detect when slime "settles" (velocity < threshold) | 45m | TODO |
| [ ] Stop physics on settled slimes | 30m | TODO |
| [ ] Snap to grid position | 45m | TODO |
| [ ] Track settled slimes in GameManager | 30m | TODO |
| [ ] Test: Slimes settle and stack neatly | 30m | TODO |

**End of Day 4 Deliverable:** Slimes settle at bottom and stop moving

---

### **Day 5 — Sunday, Feb 23**
**Focus:** Color Matching (Basic)

| Task | Time | Status |
|------|------|--------|
| [ ] Create 4 slime color variants (prefabs) | 30m | TODO |
| [ ] Implement neighbor detection (physics overlap) | 1h | TODO |
| [ ] Detect 3+ adjacent same-color slimes | 1h | TODO |
| [ ] Highlight matched slimes | 30m | TODO |
| [ ] Test: Matches detected correctly | 30m | TODO |

**End of Day 5 Deliverable:** System detects color matches (no merge yet)

---

### **Day 6 — Monday, Feb 24**
**Focus:** Merge Animation & Scoring

| Task | Time | Status |
|------|------|--------|
| [ ] Merge animation (slimes move together + shrink) | 1.5h | TODO |
| [ ] Particle effect on merge | 30m | TODO |
| [ ] Score calculation (base + match size bonus) | 30m | TODO |
| [ ] Score UI display | 30m | TODO |
| [ ] Test: Merge feels satisfying | 30m | TODO |

**End of Day 6 Deliverable:** Matches merge with satisfying animation and score

---

### **Day 7 — Tuesday, Feb 25**
**Focus:** Integration & First Playable

| Task | Time | Status |
|------|------|--------|
| [ ] Main menu (Start Game button) | 30m | TODO |
| [ ] Basic game loop (drop → settle → match → merge → repeat) | 1h | TODO |
| [ ] Lose condition (slimes stack to top) | 30m | TODO |
| [ ] Score persistence (session only) | 15m | TODO |
| [ ] Polish: Sound effects, particles | 1h | TODO |
| [ ] **BUILD & TEST ON ANDROID** | 1h | TODO |

**End of Day 7 Deliverable:** **FIRST PLAYABLE PROTOTYPE**

---

## ✅ Week 1 Success Criteria

| Criteria | How to Test |
|----------|-------------|
| Can aim slime left/right | Move mouse/finger, slime follows |
| Can drop slime on click | Click/tap, slime falls |
| Slime bounces through pegs | Observe realistic physics |
| Slime settles at bottom | Stops moving, stacks neatly |
| Match 3+ same colors detected | Place 3 red slimes together, see highlight |
| Merge animation plays | Slimes shrink together, particles spawn |
| Score updates on merge | Number increases |
| Can play for 2+ minutes without crash | Stress test |
| Runs on Android device | Build APK, install, test |

---

## 🚀 Stretch Goals (If Time Permits)

- [ ] Add simple background music
- [ ] Add sound effects (bounce, merge, drop)
- [ ] Add pause menu
- [ ] Add restart button
- [ ] Add simple main menu art
- [ ] Add level counter (display "Level 1")

---

## ⚠️ Risk Mitigation

| Risk | Mitigation |
|------|------------|
| Unity physics too chaotic | Tune bounciness/friction early (Day 2) |
| Settlement detection unreliable | Test extensively, adjust threshold |
| Android build issues | Test Day 1, not Day 7 |
| Scope creep | Stick to Week 1 plan, defer extras |
| Performance problems | Profile Day 3, optimize early |

---

## 📊 Progress Tracking

| Day | Planned | Actual | Status |
|-----|---------|--------|--------|
| Wed 19 | Setup + Physics | [TBD] | 🟡 In Progress |
| Thu 20 | Pegs + Collision | [TBD] | ⚪ Not Started |
| Fri 21 | Aim + Drop | [TBD] | ⚪ Not Started |
| Sat 22 | Settlement | [TBD] | ⚪ Not Started |
| Sun 23 | Color Match | [TBD] | ⚪ Not Started |
| Mon 24 | Merge + Score | [TBD] | ⚪ Not Started |
| Tue 25 | Polish + Build | [TBD] | ⚪ Not Started |

---

## 📝 Notes

- **Priority:** Working > Perfect. Get it functional first, polish later.
- **Testing:** Test on device EVERY DAY, not just Day 7.
- **Commits:** Commit after each task completion.
- **Blockers:** If stuck >30min, move on and come back.

---

**Week 1 Goal:** *"Drop. Bounce. Merge."* — Core loop functional by Feb 25.

Ready to start Day 1! 🎮
