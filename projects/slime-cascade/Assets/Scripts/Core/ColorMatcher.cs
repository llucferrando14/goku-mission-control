using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// ColorMatcher - Detects and processes color matches
/// Handles merge detection, validation, and trigger cascade reactions
/// </summary>
public class ColorMatcher : MonoBehaviour
{
    #region Match Configuration
    [Header("Match Rules")]
    [SerializeField] private int minMatchSize = 3;
    [SerializeField] private bool allowDiagonalMatches = false;
    [SerializeField] private bool requireAdjacentToPeg = true;
    [SerializeField] private float mergeAnimationDuration = 0.3f;
    #endregion

    #region Match State
    private List<SlimeController> currentMatch;
    private List<List<SlimeController>> pendingMerges;
    private bool isProcessingMerge;
    #endregion

    #region Detection Settings
    [Header("Detection")]
    [SerializeField] private float neighborSearchRadius = 1.5f;
    [SerializeField] private LayerMask slimeLayer;
    #endregion

    #region Events
    public System.Action<List<SlimeController>> OnMatchDetected;
    public System.Action<int> OnMatchPointsCalculated;
    public System.Action OnMergeComplete;
    #endregion

    #region Unity Lifecycle
    private void Awake()
    {
        // TODO: Initialize lists
        // TODO: Cache component references
    }

    private void Start()
    {
        // TODO: Subscribe to SlimeController.OnSettled events
    }
    #endregion

    #region Match Detection
    public void CheckForMatches(SlimeController settledSlime)
    {
        // TODO: Find all connected slimes of same color
        // TODO: Use BFS/DFS to find connected components
        // TODO: Check if match size >= minMatchSize
        // TODO: If valid match, add to pendingMerges
        // TODO: Invoke OnMatchDetected
    }

    private List<SlimeController> FindConnectedSlimes(SlimeController startSlime)
    {
        // TODO: BFS to find all connected same-color slimes
        // TODO: Check neighbors (4 or 8 directions based on settings)
        // TODO: Return list of all connected slimes
        return new List<SlimeController>(); // TODO: Implement
    }

    private List<SlimeController> GetNeighbors(SlimeController slime)
    {
        // TODO: Find all adjacent slimes
        // TODO: Use Physics2D.OverlapCircle or grid-based lookup
        // TODO: Filter by color match
        return new List<SlimeController>(); // TODO: Implement
    }

    public bool WouldCreateMatch(SlimeController slime, Vector2 position)
    {
        // TODO: Predictive check before drop
        // TODO: Check if dropping here would create a match
        // TODO: Used for aim assist/hints
        return false; // TODO: Implement
    }
    #endregion

    #region Merge Processing
    public void ProcessNextMerge()
    {
        // TODO: Check if already processing
        // TODO: Get next merge from pendingMerges
        // TODO: Start merge animation sequence
        // TODO: Call ProcessMerge for the group
    }

    private void ProcessMerge(List<SlimeController> slimesToMerge)
    {
        // TODO: Calculate merge center position
        // TODO: Animate slimes merging together
        // TODO: Spawn merged slime or particles
        // TODO: Calculate score
        // TODO: Invoke OnMatchPointsCalculated
        // TODO: Mark slimes as merged
        // TODO: Trigger chain reaction check
    }

    private IEnumerator MergeAnimation(List<SlimeController> slimes)
    {
        // TODO: Animate each slime moving to center
        // TODO: Scale down and fade
        // TODO: Spawn merge effect
        // TODO: Wait for animation complete
        yield return null; // TODO: Implement
    }

    private int CalculateMatchScore(List<SlimeController> slimes)
    {
        // TODO: Base score per slime
        // TODO: Multiplier for match size
        // TODO: Bonus for special colors
        // TODO: Combo multiplier
        return 0; // TODO: Implement
    }
    #endregion

    #region Special Match Types
    public bool CheckForSpecialMerge(List<SlimeController> slimes)
    {
        // TODO: Check for special formations
        // TODO: T-shape, L-shape, line clears
        // TODO: Return true if special merge triggered
        return false; // TODO: Implement
    }

    public void TriggerRainbowMerge(SlimeController rainbowSlime)
    {
        // TODO: Find all slimes of most common color
        // TODO: Merge all of that color
        // TODO: Special visual effect
    }

    public void TriggerBombMerge(List<SlimeController> slimes)
    {
        // TODO: Clear area around merge point
        // TODO: Affects nearby slimes regardless of color
    }
    #endregion

    #region Combo System
    private int currentCombo;
    private float comboTimer;
    [SerializeField] private float comboWindow = 2f;

    public void IncrementCombo()
    {
        // TODO: Increment currentCombo
        // TODO: Reset comboTimer
        // TODO: Show combo UI
    }

    public void ResetCombo()
    {
        // TODO: Reset currentCombo to 0
        // TODO: Hide combo UI
    }

    public int GetComboMultiplier()
    {
        // TODO: Return combo multiplier (1 + combo * 0.5)
        return 1; // TODO: Implement
    }

    private void Update()
    {
        // TODO: Decrement comboTimer
        // TODO: If timer <= 0, ResetCombo()
    }
    #endregion

    #region Utility
    public bool HasPendingMerges()
    {
        // TODO: Return pendingMerges.Count > 0
        return false; // TODO: Implement
    }

    public void ClearPendingMerges()
    {
        // TODO: Clear pendingMerges list
    }

    public int GetMatchSizeAt(Vector2 position, SlimeController.SlimeColor color)
    {
        // TODO: Predict match size without actual slimes
        // TODO: Used for aim assist
        return 0; // TODO: Implement
    }
    #endregion
}
