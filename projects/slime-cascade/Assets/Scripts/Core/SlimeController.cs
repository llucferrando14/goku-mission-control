using UnityEngine;

/// <summary>
/// SlimeController - Handles slime ball physics, dropping, and interactions
/// Controls the player-controlled slime from aim to settlement
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class SlimeController : MonoBehaviour
{
    #region Physics Components
    private Rigidbody2D rb;
    private CircleCollider2D col;
    #endregion

    #region Slime Properties
    [Header("Slime Properties")]
    [SerializeField] private SlimeColor color;
    [SerializeField] private float dropForce = 5f;
    [SerializeField] private float maxBounceVelocity = 10f;
    [SerializeField] private float sleepThreshold = 0.05f;
    
    public enum SlimeColor
    {
        Red,
        Green,
        Blue,
        Yellow,
        Purple, // Special/power-up
        Rainbow // Wildcard
    }
    #endregion

    #region State
    public enum SlimeState
    {
        Aiming,     // Player is aiming from top
        Dropping,   // In free fall
        Bouncing,   // Hitting pegs
        Settling,   // Slowing down at bottom
        Merged,     // Part of a match/merge
        Destroyed   // Cleared from board
    }
    
    public SlimeState CurrentState { get; private set; }
    public SlimeColor Color => color;
    public bool IsSettled => CurrentState == SlimeState.Settling || CurrentState == SlimeState.Merged;
    #endregion

    #region Events
    public System.Action OnDropStarted;
    public System.Action OnBounce;
    public System.Action OnSettled;
    public System.Action OnMerge;
    #endregion

    #region Unity Lifecycle
    private void Awake()
    {
        // TODO: Cache Rigidbody2D component
        // TODO: Cache CircleCollider2D component
        // TODO: Configure physics properties
    }

    private void Start()
    {
        // TODO: Set initial state to Aiming
        // TODO: Position at top of board
        // TODO: Disable physics until dropped
    }

    private void FixedUpdate()
    {
        // TODO: Monitor velocity for state changes
        // TODO: Check if settled (velocity < threshold)
        // TODO: Clamp max velocity
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TODO: Handle collision with pegs
        // TODO: Handle collision with other slimes
        // TODO: Trigger OnBounce event
        // TODO: Play bounce sound effect
        // TODO: Spawn bounce particles
    }
    #endregion

    #region Drop Mechanics
    public void SetAimPosition(Vector3 worldPosition)
    {
        // TODO: Only allow if in Aiming state
        // TODO: Move slime to x position (keep y at top)
        // TODO: Visual feedback (aim line, trajectory preview)
    }

    public void Drop()
    {
        // TODO: Validate in Aiming state
        // TODO: Enable physics
        // TODO: Apply initial downward force
        // TODO: Change state to Dropping
        // TODO: Invoke OnDropStarted
    }

    public void DropWithForce(Vector2 direction, float force)
    {
        // TODO: Alternative drop with directional force
        // TODO: Used for special slimes or power-ups
    }
    #endregion

    #region Color Management
    public void SetColor(SlimeColor newColor)
    {
        // TODO: Set color property
        // TODO: Update visual (sprite color)
        // TODO: Update physics material if needed
    }

    public void RandomizeColor(SlimeColor[] allowedColors)
    {
        // TODO: Pick random color from allowed set
        // TODO: SetColor(randomColor)
    }
    #endregion

    #region State Management
    private void SetState(SlimeState newState)
    {
        // TODO: Handle state exit logic
        // TODO: Set CurrentState = newState
        // TODO: Handle state enter logic
    }

    private void OnSettle()
    {
        // TODO: Change state to Settling
        // TODO: Stop physics simulation
        // TODO: Snap to grid position
        // TODO: Invoke OnSettled
        // TODO: Notify GameManager
        // TODO: Check for matches
    }
    #endregion

    #region Merge & Clear
    public void MarkForMerge()
    {
        // TODO: Set state to Merged
        // TODO: Disable physics
        // TODO: Prepare for merge animation
    }

    public void ClearFromBoard()
    {
        // TODO: Set state to Destroyed
        // TODO: Play clear animation
        // TODO: Spawn particles
        // TODO: Return to pool or destroy
    }
    #endregion

    #region Utility
    public bool CanMatchWith(SlimeController other)
    {
        // TODO: Check if colors match
        // TODO: Handle special colors (Rainbow matches any)
        // TODO: Return true if matchable
        return false; // TODO: Implement
    }

    public void ApplyBounceBoost(float multiplier)
    {
        // TODO: Temporarily increase bounciness
        // TODO: Used for power-ups
    }

    public void SetKinematic(bool kinematic)
    {
        // TODO: Set Rigidbody2D.isKinematic
        // TODO: Used for pausing/resuming
    }
    #endregion
}
