# Spending Alerts Log

**Purpose:** Track all spending-related events and alerts  
**Created:** 2026-02-19  
**Status:** Active monitoring

---

## Alert History

| Date | Time | Type | Message | Amount |
|------|------|------|---------|--------|
| | | | | |

---

## Spending Policy

- **Daily Budget:** €5.00
- **Daily Hard Limit:** €10.00
- **Action on budget exceeded:** Alert + request approval
- **Action on hard limit:** STOP all paid API calls

## Cost Estimates

| Service | Cost per call | Fallback if exhausted |
|---------|---------------|----------------------|
| Kimi API | ~€0.05 per 1K tokens | Gemini CLI (free) → Claude CLI (free) |
| Gemini CLI | Free (subscription) | Claude CLI → Kimi API (ask first) |
| Claude CLI | Free (Pro subscription) | Kimi API (ask first) |

---

## Rules

1. Check budget BEFORE any paid API call
2. Log every API call with timestamp, model, tokens, cost
3. Alert immediately if approaching budget
4. HARD STOP if daily limit reached
5. Always prefer free alternatives when available

---

*Last updated: 2026-02-19*
