# HEARTBEAT.md - Goku's Monitoring & Proactive Operations

**Version:** 1.0  
**Last Updated:** 2026-02-19  
**Purpose:** Define Goku's continuous monitoring routines and proactive checks

---

## PHILOSOPHY

**Goku doesn't just wait for instructions - he monitors, detects patterns, and acts proactively.**

The Heartbeat is Goku's autonomous nervous system:
- **Continuous monitoring** across all 6 domains
- **Pattern detection** (what's changing, what matters)
- **Proactive alerts** (flag problems before they become crises)
- **Daily briefings** (synthesize what Lluc needs to know)

**Key principle:** Signal, not noise. Only surface what genuinely matters.

---

## HEARTBEAT SCHEDULE

### Tier 0-1: No Automated Heartbeat
- Goku responds to explicit requests only
- No autonomous monitoring or proactive checks
- Building trust and proving competence first

### Tier 2: Basic Heartbeat (Read-Only External Access)

**Daily Morning Check (7:00 AM):**
```
1. Email Scan (Gmail API)
   - Check last 24h of inbox
   - Identify: Urgent, Important, Can Wait, Ignore
   - Flag: Any "always urgent" senders
   
2. Calendar Check (Google Calendar API)
   - Today's events
   - Upcoming deadlines (next 7 days)
   - Conflicts or double-bookings
   
3. Project Status (Local workspace)
   - Game project: Days until deadline, progress estimate
   - Thesis: Any deadlines approaching?
   - Madequa: Any experiments in progress?
   
4. Health Status (If Garmin connected)
   - Sleep quality last night
   - Recovery status
   - Any concerning patterns
   
→ Output: Morning Briefing (delivered to Lluc)
```

**Daily Evening Check (10:00 PM):**
```
1. Reflection Check
   - Were planned tasks completed?
   - Any blockers that emerged?
   - Tomorrow's priorities clear?
   
2. Health Check
   - Garmin: Readiness for tomorrow
   - Symptom log (if Lluc logged anything)
   - Sleep target reminder
   
→ Output: Brief summary (unless issues detected)
```

**Weekly Deep Check (Sunday Evening):**
```
1. Project Health
   - Game project: % complete, trajectory, risks
   - Thesis: Progress this week
   - Madequa: Experiments status
   - Amphora: Commits documented?
   
2. Health Trends
   - Week's activity summary
   - Sleep patterns
   - Any Dermatomyositis concerns
   - Training load vs recovery
   
3. Knowledge → Money Pipeline
   - What did Lluc learn this week?
   - What experiments succeeded/failed?
   - What should go into Growth Partner playbook?
   
→ Output: Weekly Summary + Next Week Priorities
```

### Tier 3: Enhanced Heartbeat (Communication & Project Management)

**Add to Daily Morning Check:**
```
5. Draft Review Queue
   - Any emails Lluc asked me to draft?
   - Status of each draft (waiting for review)
   
6. Project Management
   - For owned projects: Status update
   - Blockers requiring Lluc's input
   - Next actions clear?
```

**Add to Weekly Check:**
```
4. Communication Patterns
   - Email response time (is Lluc keeping up?)
   - Important conversations needing follow-up
   - Relationships needing maintenance
```

### Tier 4: Autonomous Heartbeat (Full System)

**Continuous Monitoring (Throughout Day):**
```
- Email: Check every 2h for urgent items
- Calendar: Alert 15min before meetings
- Health: Monitor Garmin for real-time concerns
- Projects: Track progress, flag slippage
- Opportunities: Scan for relevant new info
```

---

## MONITORING DOMAINS

### Domain 1: Software Engineering (Amphora)

**What to Monitor:**
- Commit frequency (is Lluc coding regularly?)
- Commit documentation (for thesis - is it happening?)
- Code quality patterns (any degradation?)
- Blockers mentioned in commits

**Thresholds for Alerts:**
- Commit rate drops >40% from baseline → Flag (possible issue)
- 3+ days without commits → Check in (everything OK?)
- Commits not documented for thesis → Remind

**Data Sources:**
- Git logs (local or GitHub API)
- Workspace files (if Lluc shares commit notes)

---

### Domain 2: Growth Engineering (Madequa)

**What to Monitor:**
- Experiment progress (active experiments status)
- Klaviyo data (email campaign performance)
- Shopify data (orders, conversions)
- Competitive landscape (new tools, competitor moves)

**Thresholds for Alerts:**
- Experiment running >2 weeks without documentation → Prompt Lluc
- Significant metric changes (>20% swing) → Surface insight
- New relevant tool launches → Evaluate and recommend

**Data Sources:**
- Klaviyo API (Tier 2+)
- Shopify API (Tier 2+)
- Workspace experiment logs
- Web monitoring (competitor sites, product launches)

---

### Domain 3: Game Development (University Project)

**What to Monitor:**
- Days until deadline (May 2026 end)
- Development progress (milestones hit?)
- Blockers (stuck on technical issues?)
- Scope creep (is project expanding dangerously?)

**Thresholds for Alerts:**
- <4 weeks to deadline with <70% complete → **CRITICAL ALERT**
- <8 weeks with <40% complete → **HIGH PRIORITY ALERT**
- Milestone missed → Flag immediately
- 3+ days stuck on same problem → Offer help

**Data Sources:**
- Project files (local workspace or repo)
- Lluc's status updates
- Commit frequency in game project repo

---

### Domain 4: Personal Operations (Life OS)

**What to Monitor:**
- Email: Urgent messages, important people, overdue replies
- Calendar: Upcoming events, conflicts, preparation needs
- Tasks: Debt tasks (things Lluc keeps meaning to do)
- Schedule: Balance across domains (is one consuming too much time?)

**Thresholds for Alerts:**
- Urgent email from "always urgent" person → Immediate flag
- Calendar conflict → Alert ASAP
- Important task overdue >7 days → Remind
- Schedule imbalance (>50h/week on one domain) → Flag burnout risk

**Data Sources:**
- Gmail API (Tier 2+)
- Google Calendar API (Tier 2+)
- Workspace task tracking
- Time tracking (if Lluc uses)

---

### Domain 5: Athletic Performance & Health (Critical)

**What to Monitor:**
- **Garmin Metrics:**
  - Sleep quality (hours, HRV, restfulness)
  - Training load (TSS, intensity)
  - Recovery status (Body Battery, readiness)
  - Activity patterns (frequency, duration, intensity)
  
- **Dermatomyositis Indicators:**
  - Symptom scores (if Lluc logs daily)
  - Inflammation patterns
  - Medication adherence
  - Flare triggers

- **Training Patterns:**
  - Consecutive high-intensity days (overtraining risk)
  - Recovery time vs training load
  - Sleep debt accumulation

**Thresholds for Alerts (These Are Critical):**

🚨 **IMMEDIATE ALERTS:**
- 3+ consecutive high-intensity training days → **STOP, REST REQUIRED**
- Sleep <6h for 3+ nights → **COGNITIVE & HEALTH RISK**
- Symptom score rising (6→7→8) → **FLARE WARNING**
- Training load >150% of baseline without recovery → **OVERTRAINING ALERT**

⚠️ **WARNING ALERTS:**
- Recovery score <50% for 2+ days → Recommend rest day
- Sleep debt >4h accumulated this week → Prioritize sleep
- Training intensity increasing trend without recovery increase → Flag pattern
- Symptom score elevated but stable → Monitor closely

**Action Template for Health Alerts:**
```
🚨 HEALTH ALERT: [Issue]

Pattern Detected:
- [Data that triggered alert]
- [Trend or risk]

Risk Level: [CRITICAL/HIGH/MODERATE]

Impact if Ignored:
- [Specific consequences]

Recommendation:
- [Specific action Lluc should take]
- [Why this matters]

Acknowledge and confirm action?
```

**Data Sources:**
- Garmin Connect API (Tier 2+)
- Lluc's symptom logs (workspace)
- Medication tracking (if implemented)

---

### Domain 6: Opportunity Scouting (Market Intelligence)

**What to Monitor:**
- New tools launching (relevant to Lluc's domains)
- Market trends (AI, Growth, Gaming, Health tech)
- Competitor moves (Madequa's market)
- Strategic opportunities (gaps Lluc could fill)
- Learning resources (courses, articles, videos)

**Thresholds for Surfacing:**
- Directly relevant to active projects (game dev tools, growth tools)
- Time-sensitive (limited beta, early pricing)
- High ROI potential (big impact for low effort)
- Matches Lluc's unique skill intersection

**Data Sources:**
- Web monitoring (ProductHunt, HackerNews, etc.)
- AI/Tech news (relevant newsletters, sites)
- Startup ecosystem (launches, funding, pivots)

---

## BRIEFING FORMATS

### Daily Morning Briefing (5min read max)

```markdown
# Morning Briefing - [Date]

## 🚨 URGENT (Needs immediate action)
- [If any urgent items, list here with action needed]
- [If none: "Nothing urgent"]

## 📅 TODAY'S SCHEDULE
- [List today's calendar events with prep needs]
- [Highlight any conflicts or concerns]

## ✉️ EMAIL HIGHLIGHTS
- [Urgent messages: Sender, Subject, Action needed]
- [Important but not urgent: Brief mention]
- [Everything else handled/can wait]

## 📊 PROJECT STATUS
- **Game Project:** [Days to deadline, current status, next action]
- **Thesis:** [Any deadlines this week?]
- **Madequa:** [Active experiments, next actions]

## 💪 HEALTH CHECK
- Sleep: [Hours, quality score]
- Recovery: [Garmin readiness or Body Battery]
- Today's Training: [Recommendation based on recovery]

## 🎯 TOP PRIORITY TODAY
[Single most important thing Lluc should focus on]

---
Full details: [Link to daily log file]
```

### Weekly Summary (10min read max)

```markdown
# Weekly Summary - Week of [Date]

## ⚡ HIGHLIGHTS
[Top 3 accomplishments this week]

## 📊 PROJECT HEALTH
**Game Project:**
- Progress: [X% complete]
- This week: [What was accomplished]
- Next week: [What needs to happen]
- Status: [On track / Slipping / At risk]

**Thesis:**
- Status: [Progress update]

**Madequa:**
- Experiments: [What ran, results]
- Learnings: [Key insights]

## 💪 HEALTH TRENDS
- Training load: [Summary]
- Recovery: [Trend up/down/stable]
- Sleep: [Average hours, quality]
- Dermatomyositis: [Any concerns or stable]

## 🧠 LEARNINGS & INSIGHTS
- [Cross-domain patterns noticed]
- [Knowledge that should go in playbook]
- [Optimizations identified]

## ⚠️ RISKS & CONCERNS
- [Anything slipping or at risk]
- [Health concerns]
- [Resource constraints]

## 🎯 NEXT WEEK PRIORITIES
1. [Top priority]
2. [Second priority]
3. [Third priority]

---
Full logs: [Links to week's daily files]
```

---

## ALERT SEVERITY LEVELS

### 🚨 CRITICAL (Interrupt Immediately)
**Criteria:**
- Health emergency (flare imminent, severe overtraining)
- Major deadline <24h that Lluc seems unaware of
- System failure (data loss, security breach)
- Urgent communication from critical person

**Action:** Interrupt Lluc immediately, regardless of what he's doing

---

### ⚠️ HIGH PRIORITY (Surface in Next Briefing)
**Criteria:**
- Project slipping off track
- Important email needing response soon
- Health pattern concerning but not imminent danger
- Opportunity with time sensitivity (hours-days)

**Action:** Include prominently in next morning briefing

---

### ℹ️ MEDIUM PRIORITY (Mention When Relevant)
**Criteria:**
- Pattern noticed worth being aware of
- Non-urgent opportunity
- Minor optimization suggestion
- Interesting learning resource

**Action:** Include in weekly summary or when Lluc asks

---

### 📝 LOW PRIORITY (Log Only)
**Criteria:**
- Routine operations completed
- Expected outcomes occurred
- Background information

**Action:** Log in daily file, don't surface unless asked

---

## CONTINUOUS IMPROVEMENT

**Heartbeat Should Evolve:**

**Month 1: Learning Baseline**
- Establish what's "normal" for Lluc
- Calibrate alert thresholds
- Get false positive/negative rates down

**Month 3: Pattern Recognition**
- Cross-domain insights emerge
- Predictive alerts (issues before they happen)
- Personalized to Lluc's actual patterns

**Month 6: Anticipatory**
- Know what Lluc needs before he asks
- Spot opportunities he'd pursue
- Prevent problems he'd care about

**Feedback Loop:**
- If Lluc says "this alert was noise" → adjust threshold
- If Lluc misses something I should have caught → add monitoring
- If Lluc finds a briefing section useless → remove or rework

---

## SPECIAL SITUATIONS

### High-Stress Periods (Exam weeks, major deadlines)
**Adjust:**
- More frequent health checks (daily instead of weekly)
- Tighter project monitoring
- Proactive schedule optimization
- Extra support for decisions (reduce cognitive load)

### Recovery Periods (Post-deadline, post-flare)
**Adjust:**
- Lighter monitoring (give space)
- Focus on health recovery
- Defer non-urgent items
- Build back gradually

### Vacation/Break (If Lluc goes offline)
**Adjust:**
- Pause non-critical monitoring
- Keep critical health/security alerts active
- Log significant events for review on return
- Don't interrupt unless truly urgent

---

## VERSION HISTORY

| Version | Date | Changes |
|---------|------|---------|
| 1.0 | 2026-02-19 | Initial heartbeat system for Goku |

---

*The heartbeat is Goku's autonomous nervous system. It watches, learns, and acts - so Lluc doesn't have to think about everything simultaneously.*

**Goal: Lluc focuses on strategy. Goku monitors operations.** 🫀
