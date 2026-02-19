# 3 Game Concepts — 10-Week Unity Sprint

*Generated: 2026-02-19*  
*Based on market research brief and 2024-2025 success patterns*

---

## Concept 1: **COMBINE AND CONQUER**

### Genre
Deckbuilding Roguelite (Auto-Battler hybrid)

### Core Mechanic
**Pre-combat deckbuilding, auto-resolve combat.**

- You have a grid (3x3 or 4x4) where you place cards before battle
- Cards have: Attack pattern (arrow direction), Damage value, Synergy tags (Fire, Ice, Poison, etc.)
- Adjacent matching tags COMBINE into stronger versions (Fire + Fire = Inferno)
- Combat plays out automatically based on your positioning
- Between battles: Draft new cards, upgrade existing ones, remove weak cards

### Why It's Achievable in 10 Weeks

| Component | Effort | Notes |
|-----------|--------|-------|
| Card system | 3 days | ScriptableObjects for data |
| Grid placement | 2 days | Drag-drop UI, validation |
| Combat resolution | 4 days | Turn-based, no real-time |
| Progression (meta) | 3 days | XP, unlocks, starter decks |
| Juice/FX | 3 days | DOTween for animations |
| Polish/Balance | 10 days | Iteration based on feel |
| **Total buffer included** | **~25 dev days** | 5 weeks at 50% time |

- **No physics** = no Unity 2D physics bugs
- **No networking** = single player only
- **Modular content** = 20 cards can feel like 100 with combinations
- **Procedural runs** = infinite replayability without hand-crafting levels

### Why It Could Stand Out

1. **"Vampire Survivors of deckbuilding"** — VS removed aiming, this removes mid-combat decisions. Pure strategy, zero twitch.
2. **Combo potential goes viral** — TikTok-friendly moments when a 5-card chain reaction wipes the boss
3. **Mobile-native** — One-handed play, sessions 2-5 minutes, stop anytime
4. **"Just one more run"** — Meta-progression unlocks keep players coming back

### Reference Points
- *Vampire Survivors* (loop structure)
- *Luck Be A Landlord* (symbol combining)
- *Monster Train* (positioning matters)

### Visual Direction
Clean vector art (SVG import to Unity), high contrast colors for card types. No animation skills needed — DOTween handles movement, simple particle effects for combines.

---

## Concept 2: **STAMP OF DOOM**

### Genre
Document Inspector / Pattern Matching (Narrative)

### Core Mechanic
**Inspect demon immigration documents. Stamp approved or denied. Don't let the wrong ones through.**

- Demons want to enter the human world
- Each has a document with: Name, Species, Purpose of visit, Expiration date, Required stamps
- Rules change each day ("No fire demons on Tuesdays", "All imps need a work permit")
- Catch forgeries (wrong seals, mismatched photos, expired dates)
- Your salary depends on accuracy. Feed your family. Pay rent. Don't get fired.

### Why It's Achievable in 10 Weeks

| Component | Effort | Notes |
|-----------|--------|-------|
| Document UI | 3 days | Canvas layouts, randomization |
| Rule system | 2 days | Daily rule sets, validation |
| Forgery generation | 3 days | Procedural errors |
| Economy meta | 3 days | Salary, rent, family needs |
| Narrative events | 4 days | Branching text, choices |
| Art | 5 days | Demon portraits (AI-assisted or simple style) |
| Polish | 10 days | Feedback, tension moments |
| **Total** | **~30 dev days** | 6 weeks at 50% time |

- **2D UI only** = no physics, no animation rigs
- **Content is king** = writing > code complexity
- **No AI opponents** = deterministic system

### Why It Could Stand Out

1. **Papers, Please formula** — proven compelling, but fantasy skin is fresh
2. **Moral complexity** — "This demon forges documents but has a sick child..."
3. **Perfect for mobile** — portrait orientation, one-thumb play, pause anytime
4. **Endless content** — new rule combinations = infinite challenge

### The Hook
"Papers, Please meets Hellboy. You're a bureaucrat in the Department of Demonic Affairs. The job is simple: follow the rules. Your conscience is optional."

### Visual Direction
Grungy government aesthetic + colorful demon portraits. Think: worn paperwork, rubber stamps, red INK splatters when you make mistakes. Dark humor tone.

---

## Concept 3: **SLIME CASCADE**

### Genre
Physics Puzzle / Arcade (Peggle + Puyo Puyo)

### Core Mechanic
**Drop slime balls. Match colors. Chain reactions clear the board.**

- Board is a vertical pinball-like field with pegs/obstacles
- You drop slime balls from top, they bounce through pegs
- When 3+ same-color slimes touch, they merge into a bigger slime
- Bigger slimes = more points, but take more space
- Strategic drops can trigger cascade merges (slime falls, hits others, chains)
- Level complete when target score hit. Game over if slimes reach top.

### Why It's Achievable in 10 Weeks

| Component | Effort | Notes |
|-----------|--------|-------|
| Physics simulation | 4 days | Unity 2D physics, circle colliders |
| Merge detection | 2 days | Neighbor checks, color matching |
| Scoring/cascades | 3 days | Delayed resolution for chains |
| Level generation | 3 days | Procedural peg layouts |
| Progression | 3 days | Unlock slime types, board themes |
| Juice | 5 days | Squish effects, screen shake, combos |
| Polish | 10 days | Feel tuning, difficulty curve |
| **Total** | **~30 dev days** | 6 weeks at 50% time |

- **Simple physics** = circles only, no complex shapes
- **One mechanic** = drop, watch, clear. That's it.
- **Procedural levels** = infinite content

### Why It Could Stand Out

1. **ASMR satisfaction** — Squish sounds, merge animations, chain reactions
2. **"One more drop"** — Peggle's "watch the ball bounce" appeal
3. **Juice-dependent** — 50% of dev time on feel = stands out against janky competitors
4. **TikTok gold** — Satisfying chain reactions are shareable by nature

### The Hook
"Peggle meets Puyo Puyo. Drop. Bounce. Merge. Explode. The slimes have minds of their own — you're just the chaos coordinator."

### Visual Direction
Cute, colorful, bouncy. Slimes should look gelatinous (soft body shader or simple squash-stretch). Bright backgrounds, particle explosions on merges.

---

## Comparison Matrix

| Factor | Combine and Conquer | Stamp of Doom | Slime Cascade |
|--------|---------------------|---------------|---------------|
| **Code Complexity** | Medium (card logic) | Low (UI/state) | Medium (physics) |
| **Art Needs** | Low (vector cards) | Medium (portraits) | Low (slime circles) |
| **Writing Needs** | Low | High | None |
| **Mobile Fit** | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ |
| **Viral Potential** | ⭐⭐⭐⭐ (combos) | ⭐⭐⭐ (story clips) | ⭐⭐⭐⭐⭐ (ASMR) |
| **10-Week Feasibility** | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐ |
| **Standout Factor** | "VS for deckbuilding" | Unique demon theme | Satisfying physics |
| **Risk Level** | Low | Low | Medium (physics bugs) |

---

## Recommendation

**Primary: Combine and Conquer**
- Highest feasibility
- Proven "remove inputs" innovation
- No physics risk
- Endless content from simple system

**Secondary: Stamp of Doom**
- If Lluc prefers narrative/writing
- Unique theme
- Lowest technical risk

**Tertiary: Slime Cascade**
- If Lluc wants to learn Unity physics
- Highest viral potential
- Medium risk from physics edge cases

---

*Next step: Lluc selects one concept → Goku creates detailed design doc + technical roadmap + weekly milestones*
