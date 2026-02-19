#!/bin/bash
# Spending Monitor — Goku Cost Control System
# Run before any API call to check budget

KIMI_USAGE_FILE="$HOME/.openclaw/workspace/memory/kimi-usage.json"
SPENDING_ALERTS="$HOME/.openclaw/workspace/memory/spending-alerts.md"
DAILY_BUDGET=5.00  # €5 per day
DAILY_LIMIT=10.00  # €10 hard stop

# Initialize usage file if not exists
if [ ! -f "$KIMI_USAGE_FILE" ]; then
    echo "[]" > "$KIMI_USAGE_FILE"
fi

# Calculate today's spending
today=$(date -u +%Y-%m-%d)
today_spent=$(cat "$KIMI_USAGE_FILE" | grep "\"date\": \"$today\"" | wc -l)
today_cost=$(echo "$today_spent * 0.05" | bc -l 2>/dev/null || echo "0")

# Log API call
log_api_call() {
    local model="$1"
    local tokens="$2"
    local cost="$3"
    local timestamp=$(date -u +%Y-%m-%dT%H:%M:%SZ)
    local date=$(date -u +%Y-%m-%d)
    
    # Append to JSON array (simple approach)
    echo "{\"timestamp\": \"$timestamp\", \"date\": \"$date\", \"model\": \"$model\", \"tokens\": $tokens, \"cost_estimate\": $cost}" >> "$KIMI_USAGE_FILE"
}

# Alert function
alert_spending() {
    local message="$1"
    local timestamp=$(date)
    
    echo "💸 SPENDING ALERT: $message" >> "$SPENDING_ALERTS"
    echo "Timestamp: $timestamp" >> "$SPENDING_ALERTS"
    echo "Daily total: €$today_cost" >> "$SPENDING_ALERTS"
    echo "---" >> "$SPENDING_ALERTS"
    
    # Also log to daily memory
    echo "[$(date +%H:%M)] 💸 SPENDING ALERT: $message" >> "$HOME/.openclaw/workspace/memory/daily/$(date +%Y-%m-%d).md"
}

# Check if approaching budget
check_budget() {
    local requested_cost="${1:-0.05}"
    
    # Check if we'd exceed daily limit
    local projected=$(echo "$today_cost + $requested_cost" | bc -l 2>/dev/null || echo "999")
    
    if (( $(echo "$projected > $DAILY_LIMIT" | bc -l 2>/dev/null || echo "1") )); then
        echo "HARD_LIMIT"
        alert_spending "HARD LIMIT REACHED: €$today_cost spent today. STOP ALL PAID API CALLS."
        return 1
    fi
    
    if (( $(echo "$projected > $DAILY_BUDGET" | bc -l 2>/dev/null || echo "1") )); then
        echo "BUDGET_WARNING"
        alert_spending "Budget warning: €$today_cost spent, requesting €$requested_cost more"
        return 0
    fi
    
    echo "OK"
    return 0
}

# Main execution
if [ "$1" = "log" ]; then
    log_api_call "$2" "$3" "$4"
elif [ "$1" = "check" ]; then
    check_budget "$2"
elif [ "$1" = "status" ]; then
    echo "Today's spending: €$today_cost"
    echo "Daily budget: €$DAILY_BUDGET"
    echo "Daily limit: €$DAILY_LIMIT"
else
    echo "Usage: $0 [log|check|status] [args...]"
fi
