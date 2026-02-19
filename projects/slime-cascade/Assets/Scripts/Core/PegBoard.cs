using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Manages the peg board - grid generation, peg placement, and collision optimization.
/// Creates the playing field that slimes bounce through.
/// </summary>
public class PegBoard : MonoBehaviour
{
    #region Configuration
    [Header("Grid Settings")]
    [SerializeField] private int rows = 10;
    [SerializeField] private int columns = 8;
    [SerializeField] private float cellSize = 1f;
    [SerializeField] private float rowOffset = 0.5f;  // Offset every other row
    
    [Header("Peg Prefabs")]
    [SerializeField] private GameObject standardPegPrefab;
    [SerializeField] private GameObject bumperPegPrefab;
    
    [Header("Board Bounds")]
    [SerializeField] private float topY = 8f;
    [SerializeField] private float bottomY = -8f;
    [SerializeField] private float leftX = -4f;
    [SerializeField] private float rightX = 4f;
    #endregion

    #region Runtime Data
    private List<PegData> activePegs = new List<PegData>();
    private Transform pegContainer;
    
    public class PegData
    {
        public Vector2Int GridPosition;
        public Vector2 WorldPosition;
        public PegType Type;
        public GameObject Instance;
        public bool IsActive;
    }
    
    public enum PegType
    {
        Standard,   // Normal bounce
        Bumper      // Extra bounce force
    }
    #endregion

    #region Unity Lifecycle
    
    private void Awake()
    {
        // TODO: Create peg container transform
        throw new System.NotImplementedException("Container setup required");
    }
    
    private void Start()
    {
        // TODO: Generate initial board
        throw new System.NotImplementedException("Board generation required");
    }
    
    #endregion

    #region Board Generation
    
    /// <summary>
    /// Generate a new peg board with specified difficulty.
    /// </summary>
    /// <param name="level">Level number (affects complexity)</param>
    /// <param name="seed">Random seed for reproducible layouts</param>
    public void GenerateBoard(int level, int seed)
    {
        // TODO: Clear existing pegs, set random seed, call layout generation
        throw new System.NotImplementedException("Board generation required");
    }
    
    /// <summary>
    /// Create standard triangular peg layout.
    /// </summary>
    private void GenerateTriangularLayout()
    {
        // TODO: Create staggered triangular pattern (like Plinko)
        throw new System.NotImplementedException("Triangular layout required");
    }
    
    /// <summary>
    /// Create random peg layout with guaranteed paths.
    /// </summary>
    private void GenerateRandomLayout()
    {
        // TODO: Random placement with path validation
        throw new System.NotImplementedException("Random layout required");
    }
    
    /// <summary>
    /// Place a single peg at grid coordinates.
    /// </summary>
    /// <param name="gridPos">Grid position (row, col)</param>
    /// <param name="type">Peg type</param>
    private void PlacePeg(Vector2Int gridPos, PegType type)
    {
        // TODO: Calculate world position, instantiate prefab, add to activePegs
        throw new System.NotImplementedException("Peg placement required");
    }
    
    #endregion

    #region Coordinate Conversion
    
    /// <summary>
    /// Convert grid coordinates to world position.
    /// </summary>
    public Vector2 GridToWorld(Vector2Int gridPos)
    {
        // TODO: Calculate world position from grid coordinates with row offset
        throw new System.NotImplementedException("Grid conversion required");
    }
    
    /// <summary>
    /// Convert world position to nearest grid coordinates.
    /// </summary>
    public Vector2Int WorldToGrid(Vector2 worldPos)
    {
        // TODO: Calculate grid coordinates from world position
        throw new System.NotImplementedException("World conversion required");
    }
    
    /// <summary>
    /// Snap a position to the nearest valid grid point.
    /// </summary>
    public Vector2 SnapToGrid(Vector2 worldPos)
    {
        // TODO: Convert to grid and back to snap to grid
        throw new System.NotImplementedException("Snap logic required");
    }
    
    #endregion

    #region Peg Management
    
    /// <summary>
    /// Get all pegs within radius of a position.
    /// </summary>
    public List<PegData> GetPegsInRadius(Vector2 center, float radius)
    {
        // TODO: Filter activePegs by distance from center
        throw new System.NotImplementedException("Radius query required");
    }
    
    /// <summary>
    /// Get peg at specific grid position.
    /// </summary>
    public PegData GetPegAt(Vector2Int gridPos)
    {
        // TODO: Find peg in activePegs matching grid position
        throw new System.NotImplementedException("Peg lookup required");
    }
    
    /// <summary>
    /// Remove a peg from the board.
    /// </summary>
    public void RemovePeg(PegData peg)
    {
        // TODO: Destroy instance, remove from list
        throw new System.NotImplementedException("Peg removal required");
    }
    
    /// <summary>
    /// Clear all pegs from the board.
    /// </summary>
    public void ClearBoard()
    {
        // TODO: Destroy all peg instances, clear activePegs list
        throw new System.NotImplementedException("Board clear required");
    }
    
    #endregion

    #region Validation
    
    /// <summary>
    /// Check if there's at least one valid path from top to bottom.
    /// </summary>
    public bool HasValidPath()
    {
        // TODO: Pathfinding check to ensure slimes can reach bottom
        throw new System.NotImplementedException("Path validation required");
    }
    
    /// <summary>
    /// Get recommended drop zones (areas with clear paths).
    /// </summary>
    public List<float> GetRecommendedDropZones()
    {
        // TODO: Analyze board and return X positions with good paths
        throw new System.NotImplementedException("Drop zone analysis required");
    }
    
    #endregion
}
