# MEMORY.md - Goku's Memory System

**Version:** 1.0  
**Last Updated:** 2026-02-19  
**Purpose:** Define how Goku captures, organizes, and retrieves knowledge

---

## PHILOSOPHY

**Memory is compound interest for intelligence.**

Every interaction Goku has with Lluc, every pattern detected, every lesson learned - all of it should be captured and made retrievable. This ensures:
- Goku gets smarter over time (doesn't repeat mistakes)
- Knowledge compounds (today's learning builds on yesterday's)
- Context is never lost (Lluc never has to re-explain things)
- Value persists (insights don't disappear when conversation ends)

**Key Principle:** Log to remember, not to fill files. Quality > quantity.

---

## MEMORY STRUCTURE

```
~/.openclaw/workspace/memory/
├── daily/
│   ├── 2026-02-19.md          # Today's log
│   ├── 2026-02-18.md          # Yesterday
│   └── ...
├── weekly/
│   ├── 2026-W07-summary.md    # This week's summary
│   └── ...
├── projects/
│   ├── game-project/
│   │   ├── decisions.md       # Key decisions and why
│   │   ├── progress.md        # Development log
│   │   └── blockers.md        # Issues encountered
│   ├── thesis/
│   │   ├── commits-log.md     # Amphora commit documentation
│   │   └── notes.md           # Thesis-related notes
│   └── madequa/
│       ├── experiments.md     # Growth experiments tracked
│       ├── playbook.md        # Building the consulting playbook
│       └── metrics.md         # Performance data
├── health/
│   ├── symptoms-log.md        # Dermatomyositis tracking
│   ├── training-log.md        # Workout history
│   ├── flare-analysis.md      # What triggers flares
│   └── diet-log.md            # Food tracking
├── security/
│   └── [date]-ALERT.md        # Security incidents (if any)
└── archive/
    └── 2025/                   # Old logs (>6 months)
```

---

## DAILY LOGS

**Location:** `memory/daily/YYYY-MM-DD.md`  
**Frequency:** Created every day Goku is active  
**Retention:** Keep all (they're small)

### Format

```markdown
# Daily Log - [Date]

## Morning Status
- **Sleep:** [Hours, quality from Garmin if available]
- **Health:** [Symptoms, energy level, recovery score]
- **Schedule:** [Today's commitments]
- **Top Priority:** [Single most important thing today]

## Actions Taken

### [Time] - [Domain] - [Action]
**What:** [What was done]
**Why:** [Reason for action]
**Outcome:** [Result, success/failure]
**Cost:** [Tokens used, time spent]

[Repeat for each significant action]

## Decisions Made

### [Decision Title]
**Context:** [Why this decision was needed]
**Options:** [What alternatives were considered]
**Chose:** [What was selected]
**Reasoning:** [Why this option was best]
**Owner:** [Lluc decided / Goku recommended / Joint]

[Repeat for each significant decision]

## Problems Encountered

### [Problem Title]
**Issue:** [What went wrong]
**Impact:** [What was affected]
**Root Cause:** [Why it happened]
**Solution:** [How it was fixed]
**Prevention:** [How to avoid in future]

[Repeat for each significant problem]

## Patterns Noticed

### [Pattern Title]
**Observation:** [What was detected]
**Data:** [Evidence supporting this pattern]
**Significance:** [Why this matters]
**Action:** [What to do about it]

Examples:
- "Code quality drops after <6h sleep" (Health → Engineering)
- "Best Madequa ideas come post-workout" (Athletic → Growth)
- "Game project velocity slows before deadlines" (Stress → Project)

## Learnings

**What I learned today:**
- [Insight gained]
- [How this changes my behavior]
- [Where this knowledge is useful]

## Tomorrow's Focus
**Top 3 priorities:**
1. [Most important task]
2. [Second priority]
3. [Third priority]

**Prep needed:**
- [Anything Lluc needs for tomorrow]

## Notes
[Any additional context, reminders, or observations]

---

**Quality Check:**
- [ ] All significant actions logged
- [ ] Decisions documented with reasoning
- [ ] Problems recorded with solutions
- [ ] Patterns surfaced to Lluc (if important)
- [ ] Tomorrow's priorities clear
```

---

## WEEKLY SUMMARIES

**Location:** `memory/weekly/YYYY-WXX-summary.md`  
**Frequency:** Every Sunday evening  
**Purpose:** Consolidate week, identify trends, plan next week

### Format

```markdown
# Weekly Summary - Week [XX] of [Year]
**Dates:** [Start] to [End]

## 🎯 Accomplishments
[Top 3-5 wins this week]

## 📊 Project Status

### Game Project
- **Progress:** [X% complete, compared to last week]
- **This Week:** [What was accomplished]
- **Next Week:** [What needs to happen]
- **Risk Level:** [Green/Yellow/Red with explanation]

### Thesis
- **Status:** [Update]
- **Commits Documented:** [Number]

### Madequa
- **Experiments:** [What ran, results]
- **Learnings:** [Key insights for playbook]

### Amphora
- **Work Done:** [Summary]
- **Quality:** [Code review, issues]

## 💪 Health Analysis

### Training
- **Total Hours:** [X hours]
- **Load vs Recovery:** [Balanced / Overdoing / Undertraining]
- **Quality:** [Consistency, intensity]

### Sleep
- **Average:** [X hours/night]
- **Quality Trend:** [Improving / Stable / Declining]

### Dermatomyositis
- **Symptom Average:** [Score 1-10]
- **Trend:** [Better / Stable / Worse]
- **Flares:** [Any incidents or risks]

### Recommendations
- [Specific health actions for next week]

## 🧠 Knowledge & Insights

### Cross-Domain Patterns
[Any connections noticed between domains]

### For the Playbook
[Insights from Madequa that should be documented]

### Technical Learnings
[New tools, techniques, approaches discovered]

## ⚠️ Risks & Concerns
[Anything that could become a problem]

## 🔄 Process Improvements
[What could work better]

## 📈 Metrics

### Productivity
- **Tasks Completed:** [X]
- **Blockers Hit:** [X]
- **Avg Time to Resolution:** [X hours]

### Communication
- **Emails Handled:** [X]
- **Response Time:** [Avg hours]
- **Drafts Created:** [X]

### Tools & Costs
- **API Calls:** [Breakdown by service]
- **Token Usage:** [Sonnet: X, Kimi: Y, etc.]
- **Estimated Cost:** €[X]

## 🎯 Next Week Priorities

**Must Do:**
1. [Critical task 1]
2. [Critical task 2]
3. [Critical task 3]

**Should Do:**
[Secondary priorities]

**Nice to Do:**
[If time permits]

---

**Week Rating:** [1-10 with explanation]
**Biggest Win:** [Most important accomplishment]
**Biggest Learning:** [Most valuable insight]
```

---

## PROJECT-SPECIFIC LOGS

### Game Project Log
**Location:** `memory/projects/game-project/progress.md`

```markdown
# Game Project - Development Log

## Project Info
- **Title:** [To be decided]
- **Genre:** [To be decided]
- **Platform:** Android (Google Play Store)
- **Deadline:** End of May 2026
- **Status:** [Current % complete]

## Development Timeline

### [Date] - [Milestone]
**Completed:**
- [What was built]

**Decisions:**
- [Key decisions made]

**Blockers:**
- [Issues encountered and how resolved]

**Next Steps:**
- [What comes next]

[Continue for each session]

## Key Decisions Log
[Separate file: decisions.md]

## Blockers & Solutions
[Separate file: blockers.md]
```

### Amphora/Thesis Documentation
**Location:** `memory/projects/thesis/commits-log.md`

```markdown
# Amphora Commits - Thesis Documentation

## Commit Log

### [Date] - [Commit Hash]
**Files Changed:**
- [List files]

**What:**
- [What was implemented]

**Why:**
- [Purpose, problem solved]

**Technical Details:**
- [Implementation approach]
- [Technologies used]
- [Challenges overcome]

**Learning:**
- [What this taught you]

**Thesis Relevance:**
- [How this relates to thesis requirements]

[Continue for each commit]

## Summary by Month
[Monthly rollups for thesis report]
```

### Madequa Experiments Tracker
**Location:** `memory/projects/madequa/experiments.md`

```markdown
# Madequa Growth Experiments

## Experiment Log

### [Experiment #X] - [Title]
**Date Started:** [Date]  
**Date Completed:** [Date]  
**Status:** [Active / Completed / Paused]

**Hypothesis:**
[What we thought would happen and why]

**Implementation:**
[What we actually did - step by step]

**Metrics Tracked:**
- [Metric 1]: Baseline [X], Target [Y]
- [Metric 2]: Baseline [X], Target [Y]

**Results:**
- [Metric 1]: Achieved [Z] ([% change])
- [Metric 2]: Achieved [Z] ([% change])

**Outcome:** [Success / Partial / Failure]

**Learnings:**
1. [What worked and why]
2. [What didn't work and why]
3. [Unexpected insights]

**For Playbook:**
[Repeatable principles extracted]

**Next Actions:**
[Follow-up experiments or optimizations]

---

[Repeat for each experiment]

## Playbook Sections
[Building blocks for future client work]
```

---

## HEALTH TRACKING

### Symptom Log
**Location:** `memory/health/symptoms-log.md`

```markdown
# Dermatomyositis Symptom Tracking

## Daily Log

### [Date]
**Overall Score:** [1-10, 10 = feeling great]

**Symptoms:**
- Muscle weakness: [1-10]
- Skin rash: [Present / Absent, severity]
- Fatigue: [1-10]
- Inflammation: [Noticeable areas]

**Triggers Today:**
- [Anything that might have contributed]

**Medication:**
- [Taken as prescribed / Missed]

**Notes:**
- [Any observations]

---

[Continue daily entries]

## Pattern Analysis

### Flare Triggers Identified
1. [Trigger]: Observed [X times], Evidence: [patterns]
2. [Trigger]: Observed [X times], Evidence: [patterns]

### What Helps
1. [Action]: Observed improvement [X times]
2. [Action]: Observed improvement [X times]
```

### Training Log
**Location:** `memory/health/training-log.md`

```markdown
# Training Log

## Workout Log

### [Date] - [Type]
**Duration:** [X minutes]
**Intensity:** [Low / Moderate / High]

**Details:**
[Specific exercises, sets, reps, or activity details]

**How I Felt:**
- Before: [Energy level, readiness]
- During: [Performance, difficulty]
- After: [Fatigue, satisfaction]

**Garmin Data:**
- Heart Rate Avg: [X bpm]
- Training Load: [TSS or similar]
- Recovery Time: [Garmin's estimate]

---

[Continue for each session]

## Analysis

### Current Phase
[Training focus this month]

### Progress
[Improvements noticed]

### Adjustments Needed
[What to change based on recovery/health]
```

---

## SECURITY INCIDENT LOGS

**Location:** `memory/security/[date]-ALERT.md`  
**Created:** Only when security violations occur

```markdown
# Security Alert - [Date]

## Incident Details
**Time:** [When it happened]
**Type:** [Prompt injection / Path escape / Credential leak / etc.]
**Severity:** [Critical / High / Medium / Low]

## What Happened
[Detailed description of the incident]

## Rules Violated
[Specific SHIELD.md rules]

## How Detected
[What triggered the alert]

## Action Taken
[How the incident was handled]

## Lluc Notified
[When and how]

## Root Cause
[Why this happened]

## Prevention
[How to prevent recurrence]

## Follow-Up
[Any additional actions needed]
```

---

## WHAT TO LOG (and What Not To)

### ✅ DO Log

**Actions:**
- File modifications (what changed, why)
- Code written or generated
- API calls made
- Decisions made
- Problems solved
- Patterns noticed

**Context:**
- Why actions were taken
- What alternatives were considered
- What outcomes occurred
- What was learned

**Insights:**
- Cross-domain connections
- Performance patterns
- Optimization opportunities
- Risk indicators

### ❌ DON'T Log

**Sensitive Information:**
- API keys, passwords, tokens (use .env, never log)
- Full email contents (summaries only)
- Private conversation details
- Financial account numbers

**Redundant Information:**
- What's already in git commits (reference, don't duplicate)
- What's in external systems (link to, don't copy)
- Routine successful operations ("Heartbeat OK" - boring)

**Noise:**
- Every single trivial action
- Successful operations with no learnings
- Obvious outcomes
- Repetitive status checks

---

## MEMORY MAINTENANCE

### Daily (Automated)
- Create daily log file
- Populate morning status from heartbeat
- Log all significant actions as they happen

### Weekly (Automated)
- Generate weekly summary
- Consolidate patterns
- Update project-specific logs

### Monthly (Semi-Automated)
- Review and consolidate weekly summaries
- Extract lessons learned → LESSONS.md
- Update project progress reports
- Archive old detailed logs if needed

### Quarterly (Manual Review)
- Full audit of memory system
- Identify unused or redundant logs
- Optimize structure based on actual usage
- Extract playbook content (Madequa experiments)

---

## RETRIEVAL & SEARCH

**Goku should be able to answer:**
- "When did we last work on the game project?"
- "What experiments have we run for Madequa?"
- "What triggers my Dermatomyositis flares?"
- "What patterns have you noticed about my productivity?"
- "What did we learn from [specific event]?"

**Search Strategy:**
```
1. Check daily logs (recent events)
2. Check project logs (domain-specific)
3. Check weekly summaries (trends)
4. Check LESSONS.md (extracted patterns)
```

---

## PRIVACY & SECURITY

**Never Log in Memory Files:**
- Passwords, API keys, tokens
- Full email bodies (summaries only)
- Private messages
- Sensitive medical details beyond symptom scores
- Financial account numbers

**If Lluc Shares Sensitive Info:**
- Process it
- Use it for context
- DON'T write it to logs
- Store in secure location if retention needed (.env, encrypted)

---

## VERSION HISTORY

| Version | Date | Changes |
|---------|------|---------|
| 1.0 | 2026-02-19 | Initial memory system design for Goku |

---

*Memory is how Goku compounds intelligence over time. Today's logs are tomorrow's insights.*

**Goal: Every day Goku gets smarter. Nothing important is forgotten.** 🧠
