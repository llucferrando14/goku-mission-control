# TOOLS.md - Goku's Tool Ecosystem

**Version:** 1.0  
**Last Updated:** 2026-02-19  
**Status:** Documenting current state + planned connections

---

## PHILOSOPHY

This file tracks:
- What tools Lluc uses NOW (current state)
- What access Goku has (current permissions)
- What should be connected NEXT (priority order)
- How each tool integrates (API, MCP, manual)

**Goal:** Build a complete tool ecosystem that amplifies Lluc's capabilities across all 6 domains.

---

## CURRENT STATE SNAPSHOT

### Development Tools (Amphora Domain)

**Code Editor:**
- Primary: [TO BE CONFIRMED - VS Code? Cursor? Other?]
- Extensions: [To be documented]
- Goku Access: None (Tier 0 currently)

**Version Control:**
- Git: ✅ Installed
- Platform: [GitHub? GitLab? Bitbucket? - To be confirmed]
- Repos:
  - Amphora work: [Location to be confirmed]
  - Game project: [Location to be confirmed]
  - Madequa: [Location to be confirmed]
- Goku Access: None yet (will unlock at Tier 1)

**Terminal:**
- Shell: [bash? zsh? fish? - To be confirmed]
- Package Managers:
  - npm: [Installed? Version?]
  - pip: [Installed? Version?]
  - apt: ✅ (Ubuntu system)
- Goku Access: None yet (will unlock at Tier 1 for safe commands)

**Programming Languages:**
- Primary: [To be documented]
- Frameworks: [To be documented]
- Databases: [To be documented]

**Amphora-Specific Stack:**
[TO BE FILLED IN BY LLUC]
- Languages:
- Frameworks:
- Tools:
- APIs:

---

### Communication & Productivity Tools

**Email:**
- Service: Gmail ✅
- Account: [Lluc's email]
- Current Access: None
- Needed Access: Read-only (Tier 2+)
- Use Case: Daily briefings, urgent email detection
- API: Google Gmail API
- Status: ⏳ Not yet connected

**Calendar:**
- Service: Google Calendar ✅
- Current Access: None
- Needed Access: Read-only (Tier 2), Create events (Tier 3)
- Use Case: Schedule optimization, conflict detection, meeting prep
- API: Google Calendar API
- Status: ⏳ Not yet connected

**File Storage:**
- Service: Google Drive ✅
- Current Access: None
- Needed Access: Read-only (Tier 2), Write (Tier 3)
- Use Case: Document access, storage for Goku's outputs
- API: Google Drive API
- Status: ⏳ Not yet connected

**Messaging:**
- Telegram: ✅ Active
- Current Access: None
- Needed Access: Read-only (Tier 2), Send to self (Tier 3)
- Use Case: Quick task capture, reminders to Lluc
- API: Telegram Bot API
- Status: ⏳ Not yet connected

**Note-Taking:**
- Current System: [Notion? Obsidian? Apple Notes? Paper? - To be confirmed]
- Goku Integration: [Depends on what Lluc uses]

**Task Management:**
- Current System: [Trello? Linear? Todoist? None? - To be confirmed]
- Goku Integration: [Could become part of Personal OS]

---

### Health & Fitness Tools

**Wearable:**
- Device: Garmin [MODEL TO BE CONFIRMED]
- Current Tracking:
  - Activities: [What Lluc tracks now]
  - Metrics: [HRV? Sleep? Steps? - To be confirmed]
- Current Access: None
- Needed Access: Read-only (Tier 2)
- Use Case: Athletic performance, Dermatomyositis monitoring, flare prevention
- API: Garmin Connect API
- Status: ⏳ Not yet connected

**Food Tracking:**
- Current System: [MyFitnessPal? Paper log? Nothing systematic? - To be confirmed]
- Goku Integration: [Build tracking system or connect to existing]

**Medication Tracking:**
- Current System: [App? Spreadsheet? Reminders? - To be confirmed]
- Goku Integration: [Could be part of Health Dashboard]

**Medical Records:**
- Dermatomyositis Documentation: [How Lluc currently tracks symptoms]
- Goku Integration: [Daily symptom logging, pattern analysis]

---

### Madequa-Specific Tools (Growth Partner Domain)

**Shopify:**
- Madequa Store: ✅ Active
- Current Access: None
- Needed Access: Read-only (Tier 2), Write (Tier 3 with approval)
- Use Case: Analyze products, orders, customer data, test automations
- API: Shopify Admin API
- Status: ⏳ Not yet connected
- Priority: HIGH (core of Madequa work)

**Klaviyo:**
- Email Marketing Platform: ✅ Active at Madequa
- Current Access: None
- Needed Access: Read-only (Tier 2), Write (Tier 3 with approval)
- Use Case: Analyze campaigns, segment data, propose optimizations
- API: Klaviyo API
- Status: ⏳ Not yet connected
- Priority: HIGH (core of Madequa work)

**Analytics:**
- [Google Analytics? Shopify Analytics? Other? - To be confirmed]
- Use Case: Track Madequa experiments, measure impact

**Competitor Tracking:**
- Current Method: [Manual? Tools? - To be confirmed]
- Goku Integration: [Automated competitor monitoring]

---

### AI/LLM Tools (Currently Used)

**Claude:**
- Access: ✅ (You're using it now!)
- Current Interface: Claude.ai web
- API Access: [To be confirmed]

**Other LLMs:**
- ChatGPT: [Does Lluc use? How often?]
- Copilot: [In VS Code/Cursor?]
- Cursor AI: [Using this?]
- Other: [Any other AI tools?]

**Usage Patterns:**
[TO BE DOCUMENTED]
- What does Lluc use AI for currently?
- What's working well?
- What's frustrating?
- What could be automated with Goku?

---

### Game Development Tools

**Game Engine:**
- Primary: [Unity? Godot? Unreal? React Native? - TO BE DECIDED]
- Experience Level: [Lluc has used Unity before - confirmed]
- License: [Free tier? Student? Paid?]
- Goku Integration: [Project setup, asset management, deployment help]

**Asset Tools:**
- 2D Graphics: [What does Lluc use or plan to use?]
- Audio: [Music, sound effects tools?]
- Testing: [How will game be tested?]

**Publishing:**
- Target: Google Play Store ✅
- Developer Account: [Does Lluc have one? Needs to create?]
- Goku Integration: [Guide through publishing process]

---

## PLANNED CONNECTIONS (Priority Order)

### Phase 1: Foundation (Week 1-2)
**Goal:** Get basic monitoring and documentation working

1. **Gmail (Read-Only)**
   - Priority: HIGH
   - Reason: Daily briefings need email summaries
   - Setup: Google API OAuth
   - Tier Required: 2

2. **Google Calendar (Read-Only)**
   - Priority: HIGH
   - Reason: Schedule awareness, conflict detection
   - Setup: Google API OAuth
   - Tier Required: 2

3. **GitHub (Read-Only)**
   - Priority: HIGH
   - Reason: Track Amphora commits for thesis documentation
   - Setup: Personal Access Token
   - Tier Required: 2

### Phase 2: Health & Growth (Week 3-4)
**Goal:** Athletic optimization and Madequa experiments

4. **Garmin Connect API**
   - Priority: HIGH
   - Reason: Dermatomyositis monitoring, training optimization
   - Setup: OAuth + API key
   - Tier Required: 2

5. **Shopify (Madequa)**
   - Priority: HIGH
   - Reason: Core of Growth Partner learning
   - Setup: API key from Madequa admin
   - Tier Required: 2 (read), 3 (write with approval)

6. **Klaviyo (Madequa)**
   - Priority: HIGH
   - Reason: Email campaign analysis
   - Setup: API key from Madequa admin
   - Tier Required: 2

### Phase 3: Communication & Automation (Month 2)
**Goal:** Reduce manual work, increase autonomy

7. **Gmail (Write - Drafts Only)**
   - Priority: MEDIUM
   - Reason: Email drafting for review
   - Tier Required: 3

8. **Google Calendar (Write)**
   - Priority: MEDIUM
   - Reason: Create events, optimize schedule
   - Tier Required: 3

9. **Telegram Bot**
   - Priority: MEDIUM
   - Reason: Quick task capture, reminders
   - Setup: Create bot, get token
   - Tier Required: 2 (read), 3 (send)

10. **Google Drive (Read/Write)**
    - Priority: MEDIUM
    - Reason: Access docs, store outputs
    - Tier Required: 2 (read), 3 (write)

### Phase 4: Advanced (Month 3+)
**Goal:** Full automation, proactive intelligence

11. **GitHub (Write)**
    - Priority: LOW-MEDIUM
    - Reason: Push commits, create PRs
    - Tier Required: 3

12. **Additional Analytics Tools**
    - Depends on what Lluc uses at Madequa
    - Tier Required: 2+

---

## INTEGRATION METHODS

### API Integrations (Direct)
**Best for:** Services with good APIs (Google, GitHub, Shopify)

**Setup Process:**
1. Create API credentials
2. Store in `~/.openclaw/workspace/.env`
3. Test connection with read-only operation
4. Grant Goku access at appropriate tier
5. Monitor usage and costs

**Security:**
- All credentials in `.env` (never in code)
- `.env` in `.gitignore` (never committed)
- Log API calls (track usage and costs)
- Rate limiting respected

### MCP Integrations (Model Context Protocol)
**Best for:** Complex workflows, multiple service coordination

**From Skills Guide:** MCP provides the tools, Skills provide the workflows

**Potential MCP Servers:**
- Gmail MCP
- Calendar MCP
- GitHub MCP
- [Others as needed]

**Setup Process:**
1. Install MCP server
2. Configure credentials
3. Create Skill that uses MCP
4. Test workflow
5. Deploy

### Manual/Hybrid (For Now)
**For services without good APIs or during early setup:**
- Lluc uploads data manually (bank statements, food logs)
- Goku processes locally
- Transition to automated once working

---

## TOOL INVENTORY TEMPLATE

**For each new tool, document:**

```markdown
### [Tool Name]
- Service: [What it is]
- Current Access: [None/Read/Write]
- Needed Access: [What Goku needs]
- Use Case: [Why we need this]
- API: [Which API]
- Tier Required: [0/1/2/3/4]
- Status: [Not Connected/Testing/Active]
- Priority: [HIGH/MEDIUM/LOW]
- Setup: [How to connect]
- Security: [Credentials location, special handling]
- Cost: [Free/Usage-based/Subscription]
```

---

## MISSING INFORMATION (To Be Filled By Lluc)

### Critical Gaps:
1. **Amphora Tech Stack** - What languages/frameworks/tools?
2. **Garmin Model** - Which device? What metrics available?
3. **Game Engine Choice** - Unity? Something else?
4. **Daily Tools** - What does Lluc use for notes, tasks, files?
5. **Madequa Access** - Can Lluc get API keys for Shopify/Klaviyo?

### Process to Fill Gaps:
As Lluc shares information:
1. Update this file
2. Prioritize connections
3. Set up access at appropriate tier
4. Test integration
5. Document in usage logs

---

## COST TRACKING

### Current Costs (Monthly)
- Claude Pro/Max: [Subscription cost]
- [Other paid tools: list here]
- **Total:** €[amount]/month

### Projected Costs (After Full Integration)
- API Usage (estimated):
  - Google APIs: Free tier (should be sufficient)
  - Garmin: Free
  - GitHub: Free (personal use)
  - Shopify/Klaviyo: Via Madequa (no cost to Lluc)
  - [Other]: [Estimate]
- **Projected Total:** €[amount]/month

**Goal:** Keep tool costs low. Optimize for free tiers and efficient API usage.

---

## SECURITY NOTES

**For ALL tool connections:**
- Credentials stored in `~/.openclaw/workspace/.env`
- `.env` in `.gitignore`
- Never log credentials in memory files
- Use read-only access until write is needed
- Test thoroughly before granting access
- Monitor for suspicious activity
- Revoke access immediately if compromised

**OAuth Tokens:**
- Store securely
- Refresh automatically when expired
- Rotate if suspected leak

**API Keys:**
- Rotate every 90 days (or when compromised)
- Use least-privilege (only permissions needed)
- Monitor usage (detect anomalies)

---

## USAGE MONITORING

**Goku should track:**
- API calls per day/service
- Token usage (for AI models)
- Costs (estimated and actual)
- Rate limit hits (avoid throttling)
- Errors (failed calls, auth issues)

**Report Format (Weekly):**
```
Tool Usage Summary (Week of [date]):

Gmail API: 47 calls, 0 errors, Rate limit: 5% of daily quota
Calendar API: 23 calls, 0 errors
Garmin API: 7 calls, 0 errors
Shopify API: 15 calls, 1 error (fixed)

Token Usage:
- Sonnet: 145K tokens (€X estimated)
- Kimi: 89K tokens (€Y estimated)

Issues:
- [Any problems encountered]

Recommendations:
- [Optimizations identified]
```

---

## VERSION HISTORY

| Version | Date | Changes |
|---------|------|---------|
| 1.0 | 2026-02-19 | Initial tool inventory, awaiting Lluc's details |

---

*This file will evolve as tools are connected. Update after each new integration.*

**Current Priority: Fill in missing information from Lluc, then begin Phase 1 connections.** 🔧
