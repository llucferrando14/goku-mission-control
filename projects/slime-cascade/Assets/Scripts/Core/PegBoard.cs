using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// PegBoard - Manages the peg field layout and generation
/// Handles peg placement, types, and board state
/// </summary>
public class PegBoard : MonoBehaviour
{
    #region Board Configuration
    [Header("Board Dimensions")]
    [SerializeField] private int gridWidth = 7;
    [SerializeField] private int gridHeight = 12;
    [SerializeField] private float cellSize = 1f;
    [SerializeField] private Vector2 boardOffset;
    #endregion

    #region Peg Types
    [Header("Peg Types")]
    [SerializeField] private GameObject standardPegPrefab;
    [SerializeField] private GameObject bumperPegPrefab;
    [SerializeField] private GameObject breakablePegPrefab;
    
    public enum PegType
    {
        Standard,   // Fixed, normal bounce
        Bumper,     // Extra bouncy
        Breakable,  // Destroys after N hits
        Moving,     // Moves horizontally
        Rotating    // Rotates, changing bounce angle
    }
    #endregion

    #region Board State
    private Peg[,] pegGrid;
    private List<Peg> activePegs;
    private List<Peg> breakablePegs;
    
    public class Peg
    {
        public Vector2Int GridPosition;
        public Vector2 WorldPosition;
        public PegType Type;
        public GameObject Instance;
        public int Durability; // For breakable pegs
        public bool IsActive;
    }
    #endregion

    #region Generation Settings
    [Header("Generation")]
    [SerializeField] private float bumperPegChance = 0.15f;
    [SerializeField] private float breakablePegChance = 0.1f;
    [SerializeField] private int minPegsPerRow = 3;
    [SerializeField] private int maxPegsPerRow = 5;
    [SerializeField] private bool useStaggeredRows = true;
    #endregion

    #region Events
    public System.Action<Vector2Int> OnPegHit;
    public System.Action<Peg> OnPegDestroyed;
    public System.Action OnBoardGenerated;
    #endregion

    #region Unity Lifecycle
    private void Awake()
    {
        // TODO: Initialize peg lists
        // TODO: Set up board dimensions
    }

    private void Start()
    {
        // TODO: Generate initial board
        // TODO: Load level config if available
    }
    #endregion

    #region Board Generation
    public void GenerateBoard(int levelNumber = 1)
    {
        // TODO: Clear existing board
        // TODO: Initialize pegGrid array
        // TODO: Generate peg layout based on level
        // TODO: Place pegs in world space
        // TODO: Invoke OnBoardGenerated
    }

    public void GenerateRandomBoard()
    {
        // TODO: Create random but fair layout
        // TODO: Ensure no unwinnable configurations
        // TODO: Distribute peg types randomly
    }

    private void PlacePeg(int x, int y, PegType type)
    {
        // TODO: Calculate world position from grid coordinates
        // TODO: Instantiate peg prefab
        // TODO: Configure peg properties
        // TODO: Add to pegGrid and activePegs
    }

    private Vector2 GridToWorld(Vector2Int gridPos)
    {
        // TODO: Convert grid coordinates to world position
        // TODO: Apply stagger offset for every other row
        // TODO: Apply boardOffset
        return Vector2.zero; // TODO: Implement
    }

    private Vector2Int WorldToGrid(Vector2 worldPos)
    {
        // TODO: Convert world position to grid coordinates
        // TODO: Inverse of GridToWorld
        return Vector2Int.zero; // TODO: Implement
    }
    #endregion

    #region Level Patterns
    public void LoadLevelPattern(LevelPattern pattern)
    {
        // TODO: Load predefined pattern from scriptable object
        // TODO: Place pegs according to pattern data
    }

    public void GenerateDiamondPattern()
    {
        // TODO: Create diamond-shaped peg field
    }

    public void GenerateCirclePattern()
    {
        // TODO: Create circular peg field
    }

    public void GenerateRandomScattered()
    {
        // TODO: Random placement with minimum spacing
    }
    #endregion

    #region Peg Management
    public Peg GetPegAt(Vector2Int gridPos)
    {
        // TODO: Return peg at grid position
        // TODO: Handle out of bounds
        return null; // TODO: Implement
    }

    public Peg GetNearestPeg(Vector2 worldPos)
    {
        // TODO: Find closest peg to world position
        // TODO: Useful for match detection
        return null; // TODO: Implement
    }

    public void DamagePeg(Vector2Int gridPos, int damage = 1)
    {
        // TODO: Apply damage to breakable peg
        // TODO: Check durability
        // TODO: Destroy if durability <= 0
        // TODO: Invoke OnPegDestroyed
    }

    public void RemovePeg(Vector2Int gridPos)
    {
        // TODO: Remove peg from grid and lists
        // TODO: Destroy GameObject
        // TODO: Clear grid cell
    }
    #endregion

    #region Queries
    public bool IsValidGridPosition(Vector2Int gridPos)
    {
        // TODO: Check if position is within grid bounds
        return false; // TODO: Implement
    }

    public bool HasPegAt(Vector2Int gridPos)
    {
        // TODO: Check if grid cell has active peg
        return false; // TODO: Implement
    }

    public List<Peg> GetPegsInRow(int row)
    {
        // TODO: Return all pegs in specified row
        return new List<Peg>(); // TODO: Implement
    }

    public List<Peg> GetPegsInColumn(int col)
    {
        // TODO: Return all pegs in specified column
        return new List<Peg>(); // TODO: Implement
    }
    #endregion

    #region Visual Effects
    public void HighlightPeg(Vector2Int gridPos, Color highlightColor)
    {
        // TODO: Visual feedback for targeted peg
    }

    public void ShakeBoard(float intensity, float duration)
    {
        // TODO: Screen shake on big cascade
    }
    #endregion

    #region Utility
    public void ClearBoard()
    {
        // TODO: Remove all pegs
        // TODO: Clear lists and grid
        // TODO: Destroy all peg GameObjects
    }

    public int GetActivePegCount()
    {
        // TODO: Return count of active pegs
        return 0; // TODO: Implement
    }
    #endregion

    #region Data Structures
    [System.Serializable]
    public class LevelPattern
    {
        public string patternName;
        public int width;
        public int height;
        public PegType[] pegLayout; // Flattened 2D array
        public int[] durabilityMap; // For breakable pegs
    }
    #endregion
}
