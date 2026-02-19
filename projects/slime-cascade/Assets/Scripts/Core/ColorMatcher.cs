using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Detects color matches between settled slimes.
/// Triggers merge and chain reaction events when matches are found.
/// </summary>
public class ColorMatcher : MonoBehaviour
{
    #region Configuration
    [Header("Match Settings")]
    [SerializeField] private int minMatchCount = 3;
    [SerializeField] private float matchCheckDelay = 0.5f;
    [SerializeField] private float mergeDuration = 0.3f;
    
    [Header("Detection")]
    [SerializeField] private float slimeRadius = 0.4f;
    [SerializeField] private LayerMask slimeLayer;
    #endregion

    #region State
    private List<SlimeController> settledSlimes = new List<SlimeController>();
    private bool isCheckingMatches = false;
    private HashSet<SlimeController> slimesInMatch = new HashSet<SlimeController>();
    #endregion

    #region Events
    public delegate void MatchFound(List<SlimeController> matchedSlimes, Color color);
    public static event MatchFound OnMatchFound;
    
    public delegate void MergeComplete(int totalScore);
    public static event MergeComplete OnMergeComplete;
    #endregion

    #region Unity Lifecycle
    
    private void Start()
    {
        // TODO: Subscribe to SlimeController.OnSettled event
        throw new System.NotImplementedException("Event subscription required");
    }
    
    private void OnDestroy()
    {
        // TODO: Unsubscribe from events
        throw new System.NotImplementedException("Cleanup required");
    }
    
    #endregion

    #region Slime Registration
    
    /// <summary>
    /// Register a slime as settled and ready for matching.
    /// </summary>
    public void RegisterSettledSlime(SlimeController slime)
    {
        // TODO: Add to settledSlimes list, trigger delayed match check
        throw new System.NotImplementedException("Registration required");
    }
    
    /// <summary>
    /// Unregister a slime (when it clears or merges).
    /// </summary>
    public void UnregisterSlime(SlimeController slime)
    {
        // TODO: Remove from settledSlimes list
        throw new System.NotImplementedException("Unregistration required");
    }
    
    #endregion

    #region Match Detection
    
    /// <summary>
    /// Check all settled slimes for color matches.
    /// </summary>
    public void CheckForMatches()
    {
        // TODO: Iterate through settledSlimes, group by color, find connected groups
        throw new System.NotImplementedException("Match detection required");
    }
    
    /// <summary>
    /// Find all slimes connected by color using flood fill.
    /// </summary>
    /// <param name="startSlime">Starting slime</param>
    /// <param name="color">Color to match</param>
    /// <returns>List of all connected same-color slimes</returns>
    private List<SlimeController> FindConnectedGroup(SlimeController startSlime, Color color)
    {
        // TODO: BFS/DFS to find all touching same-color slimes
        throw new System.NotImplementedException("Flood fill required");
    }
    
    /// <summary>
    /// Check if two slimes are touching (within radius).
    /// </summary>
    private bool AreSlimesTouching(SlimeController a, SlimeController b)
    {
        // TODO: Distance check between slime positions
        throw new System.NotImplementedException("Touch detection required");
    }
    
    /// <summary>
    /// Get neighbors of a slime (for flood fill).
    /// </summary>
    private List<SlimeController> GetNeighbors(SlimeController slime)
    {
        // TODO: Find all settled slimes within 2*radius distance
        throw new System.NotImplementedException("Neighbor search required");
    }
    
    #endregion

    #region Match Processing
    
    /// <summary>
    /// Process a valid match - trigger merge animations and scoring.
    /// </summary>
    /// <param name="matchedSlimes">List of slimes in the match</param>
    private void ProcessMatch(List<SlimeController> matchedSlimes)
    {
        // TODO: Fire OnMatchFound event, trigger merge animations
        throw new System.NotImplementedException("Match processing required");
    }
    
    /// <summary>
    /// Calculate score for a match based on count and chain depth.
    /// </summary>
    /// <param name="matchCount">Number of slimes in match</param>
    /// <param name="chainDepth">Current chain reaction depth</param>
    public int CalculateMatchScore(int matchCount, int chainDepth)
    {
        // TODO: Base points * multiplier * chain bonus
        throw new System.NotImplementedException("Score calculation required");
    }
    
    #endregion

    #region Merging
    
    /// <summary>
    /// Animate slimes merging together.
    /// </summary>
    /// <param name="slimes">Slimes to merge</param>
    /// <param name="targetPosition">Where to merge toward</param>
    private IEnumerator MergeSlimes(List<SlimeController> slimes, Vector2 targetPosition)
    {
        // TODO: Animate all slimes toward target, then clear them
        throw new System.NotImplementedException("Merge animation required");
    }
    
    /// <summary>
    /// Create merged slime visual effect.
    /// </summary>
    private void SpawnMergeEffect(Vector2 position, Color color)
    {
        // TODO: Particle burst, screen shake, sound effect
        throw new System.NotImplementedException("Merge FX required");
    }
    
    #endregion

    #region Chain Reactions
    
    /// <summary>
    /// After a merge, check if new matches were created (chain reaction).
    /// </summary>
    public void CheckForChainReaction(int chainDepth)
    {
        // TODO: Delayed call to CheckForMatches with chain depth incremented
        throw new System.NotImplementedException("Chain check required");
    }
    
    /// <summary>
    /// Get current chain multiplier based on depth.
    /// </summary>
    public float GetChainMultiplier(int chainDepth)
    {
        // TODO: Return multiplier (e.g., 1.0, 1.5, 2.0, 3.0...)
        throw new System.NotImplementedException("Chain multiplier required");
    }
    
    #endregion

    #region Utility
    
    /// <summary>
    /// Highlight potential matches (for player feedback).
    /// </summary>
    public void HighlightPotentialMatches()
    {
        // TODO: Find groups of 2 same-color slimes and highlight them
        throw new System.NotImplementedException("Highlight logic required");
    }
    
    /// <summary>
    /// Clear all highlights.
    /// </summary>
    public void ClearHighlights()
    {
        // TODO: Remove highlights from all slimes
        throw new System.NotImplementedException("Clear highlights required");
    }
    
    #endregion
}
