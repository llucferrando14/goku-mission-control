using UnityEngine;

/// <summary>
/// Controls individual slime ball physics and behavior.
/// Handles dropping, collision, settling, and visual feedback.
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class SlimeController : MonoBehaviour
{
    #region Configuration
    [Header("Physics")]
    [SerializeField] private float bounciness = 0.7f;
    [SerializeField] private float friction = 0.1f;
    [SerializeField] private float sleepThreshold = 0.05f;
    [SerializeField] private float maxVelocity = 20f;
    
    [Header("Visual")]
    [SerializeField] private Color slimeColor = Color.green;
    [SerializeField] private float settleScale = 0.8f;
    [SerializeField] private AnimationCurve bounceCurve;
    #endregion

    #region State
    public enum SlimeState
    {
        InQueue,      // Waiting to be dropped
        Dropping,     // Falling through pegs
        Settling,     // Slowing down at bottom
        Settled,      // At rest, ready for matching
        Merging,      // Currently merging with another slime
        Clearing      // Being removed (matched)
    }
    
    public SlimeState CurrentState { get; private set; }
    public Color Color => slimeColor;
    public bool IsSettled => CurrentState == SlimeState.Settled;
    #endregion

    #region Components
    private Rigidbody2D rb;
    private CircleCollider2D col;
    private SpriteRenderer spriteRenderer;
    #endregion

    #region Unity Lifecycle
    
    private void Awake()
    {
        // TODO: Cache component references (rb, col, spriteRenderer)
        throw new System.NotImplementedException("Component caching required");
    }
    
    private void Start()
    {
        // TODO: Initialize physics material, set sleep threshold
        throw new System.NotImplementedException("Physics initialization required");
    }
    
    private void FixedUpdate()
    {
        // TODO: Cap velocity, check for settling conditions
        throw new System.NotImplementedException("Physics constraints required");
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TODO: Play bounce sound, trigger bounce animation, check for peg collision
        throw new System.NotImplementedException("Collision handling required");
    }
    
    #endregion

    #region Initialization
    
    /// <summary>
    /// Set up slime with specific color and position.
    /// Called when spawning a new slime.
    /// </summary>
    /// <param name="color">Slime color</param>
    /// <param name="startPosition">Spawn position</param>
    public void Initialize(Color color, Vector2 startPosition)
    {
        // TODO: Set color, position, reset state to InQueue
        throw new System.NotImplementedException("Initialization required");
    }
    
    /// <summary>
    /// Configure physics properties.
    /// </summary>
    public void SetPhysicsProperties(float bounce, float fric)
    {
        // TODO: Update bounciness and friction values
        throw new System.NotImplementedException("Physics config required");
    }
    
    #endregion

    #region Drop Mechanics
    
    /// <summary>
    /// Start dropping the slime from current position.
    /// </summary>
    public void Drop()
    {
        // TODO: Change state to Dropping, enable physics, apply initial velocity
        throw new System.NotImplementedException("Drop logic required");
    }
    
    /// <summary>
    /// Set initial aim direction before dropping.
    /// </summary>
    /// <param name="aimAngle">Angle in degrees (0 = straight down)</param>
    public void SetAim(float aimAngle)
    {
        // TODO: Rotate visual to show aim direction
        throw new System.NotImplementedException("Aiming logic required");
    }
    
    #endregion

    #region Settling
    
    /// <summary>
    /// Check if slime has settled (stopped moving).
    /// </summary>
    /// <returns>True if velocity below threshold</returns>
    private bool HasSettled()
    {
        // TODO: Check rb.velocity.magnitude < sleepThreshold
        throw new System.NotImplementedException("Settle detection required");
    }
    
    /// <summary>
    /// Mark slime as settled and ready for matching.
    /// </summary>
    public void Settle()
    {
        // TODO: Change state to Settled, scale down slightly, notify GameManager
        throw new System.NotImplementedException("Settle logic required");
    }
    
    #endregion

    #region Merging & Clearing
    
    /// <summary>
    /// Begin merge animation with another slime.
    /// </summary>
    /// <param name="targetPosition">Position to merge toward</param>
    public void StartMerge(Vector2 targetPosition)
    {
        // TODO: Change state to Merging, animate toward target
        throw new System.NotImplementedException("Merge animation required");
    }
    
    /// <summary>
    /// Complete merge - destroy this slime and return value.
    /// </summary>
    /// <returns>Score value of this slime</returns>
    public int CompleteMerge()
    {
        // TODO: Return point value, play merge effect, destroy game object
        throw new System.NotImplementedException("Merge completion required");
    }
    
    /// <summary>
    /// Trigger clearing animation (when part of match).
    /// </summary>
    public void Clear()
    {
        // TODO: Change state to Clearing, play clear animation, destroy
        throw new System.NotImplementedException("Clear logic required");
    }
    
    #endregion

    #region Visual Feedback
    
    /// <summary>
    /// Play bounce visual effect.
    /// </summary>
    public void PlayBounceEffect()
    {
        // TODO: Squash/stretch animation, particle burst
        throw new System.NotImplementedException("Bounce FX required");
    }
    
    /// <summary>
    /// Highlight slime as part of potential match.
    /// </summary>
    /// <param name="highlighted">True to highlight</param>
    public void SetHighlighted(bool highlighted)
    {
        // TODO: Change sprite color/brightness to show highlight
        throw new System.NotImplementedException("Highlight logic required");
    }
    
    #endregion
}
