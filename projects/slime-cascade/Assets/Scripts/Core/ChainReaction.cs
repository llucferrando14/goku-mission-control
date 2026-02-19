using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// ChainReaction - Manages cascade effects from merges
/// Handles delayed reactions, scoring cascades, and visual feedback
/// </summary>
public class ChainReaction : MonoBehaviour
{
    #region Chain Configuration
    [Header("Chain Settings")]
    [SerializeField] private float cascadeDelay = 0.3f;
    [SerializeField] private float maxChainDuration = 5f;
    [SerializeField] private bool allowRecursiveChains = true;
    [SerializeField] private int maxChainDepth = 10;
    #endregion

    #region Chain State
    private int currentChainLevel;
    private float chainScoreMultiplier;
    private List<ChainEvent> activeChain;
    private bool isChainActive;
    
    public class ChainEvent
    {
        public Vector2 Position;
        public SlimeController.SlimeColor Color;
        public int ChainLevel;
        public float Delay;
        public System.Action OnComplete;
    }
    #endregion

    #region Multiplier Curve
    [Header("Scoring")]
    [SerializeField] private AnimationCurve chainMultiplierCurve;
    [SerializeField] private float baseMultiplier = 1f;
    [SerializeField] private float maxMultiplier = 10f;
    #endregion

    #region Events
    public System.Action<int> OnChainStarted;
    public System.Action<int, float> OnChainLevelIncreased;
    public System.Action<int, int> OnChainComplete; // chainLevel, totalScore
    public System.Action<Vector2, int> OnCascadeTriggered;
    #endregion

    #region Unity Lifecycle
    private void Awake()
    {
        // TODO: Initialize lists
        // TODO: Setup default multiplier curve
    }

    private void Start()
    {
        // TODO: Subscribe to ColorMatcher events
    }
    #endregion

    #region Chain Initiation
    public void StartChainReaction(Vector2 origin, List<SlimeController> initialSlimes)
    {
        // TODO: Reset chain state
        // TODO: Set isChainActive = true
        // TODO: Add initial event to activeChain
        // TODO: Start ProcessChain coroutine
        // TODO: Invoke OnChainStarted
    }

    public void TriggerCascade(Vector2 position, SlimeController.SlimeColor color, int chainLevel)
    {
        // TODO: Create new ChainEvent
        // TODO: Add to activeChain
        // TODO: Update UI to show cascade
        // TODO: Invoke OnCascadeTriggered
    }
    #endregion

    #region Chain Processing
    private IEnumerator ProcessChain()
    {
        // TODO: While activeChain has events
        // TODO: Process each event with delay
        // TODO: Check for new merges after each event
        // TODO: Update chain level
        // TODO: Apply multiplier
        yield return null; // TODO: Implement
    }

    private IEnumerator ProcessChainEvent(ChainEvent chainEvent)
    {
        // TODO: Wait for chainEvent.Delay
        // TODO: Spawn visual effects
        // TODO: Apply physics forces to nearby slimes
        // TODO: Check for new matches
        // TODO: Call chainEvent.OnComplete
        yield return null; // TODO: Implement
    }

    private void ResolveChain()
    {
        // TODO: Calculate total chain score
        // TODO: Apply final multiplier
        // TODO: Award points via GameManager
        // TODO: Invoke OnChainComplete
        // TODO: Reset chain state
    }
    #endregion

    #region Cascade Mechanics
    private List<SlimeController> FindAffectedSlimes(Vector2 center, float radius)
    {
        // TODO: Find slimes within radius of cascade point
        // TODO: Affected slimes may shift/merge
        // TODO: Return list of affected slimes
        return new List<SlimeController>(); // TODO: Implement
    }

    private void ApplyCascadeForce(Vector2 center, float force)
    {
        // TODO: Apply explosive force to slimes near center
        // TODO: May cause new matches
        // TODO: Visual shake effect
    }

    private bool CheckForSecondaryMatches()
    {
        // TODO: After cascade, check if new matches formed
        // TODO: If yes, add to activeChain
        // TODO: Return true if new matches found
        return false; // TODO: Implement
    }
    #endregion

    #region Multiplier System
    public float GetCurrentMultiplier()
    {
        // TODO: Evaluate chainMultiplierCurve at currentChainLevel
        // TODO: Clamp between baseMultiplier and maxMultiplier
        return baseMultiplier; // TODO: Implement
    }

    public int CalculateChainScore(int baseScore)
    {
        // TODO: Multiply baseScore by GetCurrentMultiplier()
        // TODO: Return as int
        return baseScore; // TODO: Implement
    }

    private void UpdateChainLevel(int newLevel)
    {
        // TODO: Set currentChainLevel = newLevel
        // TODO: Calculate new multiplier
        // TODO: Update UI
        // TODO: Invoke OnChainLevelIncreased
    }
    #endregion

    #region Visual Effects
    private void SpawnCascadeEffect(Vector2 position, int level)
    {
        // TODO: Spawn particle system
        // TODO: Scale intensity with chain level
        // TODO: Color based on triggering slime
        // TODO: Screen shake for high levels
    }

    private void ShowChainText(Vector2 position, int level)
    {
        // TODO: Spawn floating text
        // TODO: "x2", "x3", "COMBO!", "MEGA CASCADE!"
    }

    private IEnumerator ScreenShake(float intensity, float duration)
    {
        // TODO: Shake camera
        // TODO: Intensity scales with chain level
        yield return null; // TODO: Implement
    }
    #endregion

    #region Audio
    private void PlayCascadeSound(int level)
    {
        // TODO: Play escalating sound
        // TODO: Pitch/speed increases with chain level
        // TODO: Satisfying "pop" sounds
    }
    #endregion

    #region Utility
    public bool IsChainActive()
    {
        return isChainActive;
    }

    public int GetCurrentChainLevel()
    {
        return currentChainLevel;
    }

    public void StopChain()
    {
        // TODO: Stop all chain processing
        // TODO: Clear activeChain
        // TODO: Reset state
    }

    public float GetChainProgress()
    {
        // TODO: Return 0-1 progress of current chain
        // TODO: Used for UI bar
        return 0f; // TODO: Implement
    }
    #endregion
}
