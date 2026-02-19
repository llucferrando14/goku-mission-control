using UnityEngine;

/// <summary>
/// Central game state manager. Handles game flow, scoring, level progression.
/// Singleton pattern - only one GameManager exists per scene.
/// </summary>
public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance { get; private set; }
    #endregion

    #region Game State
    public enum GameState
    {
        MainMenu,
        Playing,
        GameOver,
        LevelComplete,
        Paused
    }
    
    public GameState CurrentState { get; private set; }
    #endregion

    #region Game Data
    [Header("Game Settings")]
    [SerializeField] private int targetScore = 1000;
    [SerializeField] private int maxSlimes = 50;
    [SerializeField] private float turnTimeLimit = 30f;
    
    [Header("Runtime Data")]
    [SerializeField] private int currentScore = 0;
    [SerializeField] private int currentLevel = 1;
    [SerializeField] private int slimesDropped = 0;
    [SerializeField] private float turnTimer = 0f;
    #endregion

    #region Events
    public delegate void GameStateChanged(GameState newState);
    public static event GameStateChanged OnGameStateChanged;
    
    public delegate void ScoreUpdated(int newScore, int pointsAdded);
    public static event ScoreUpdated OnScoreUpdated;
    
    public delegate void LevelComplete(int level, int finalScore);
    public static event LevelComplete OnLevelComplete;
    #endregion

    #region Unity Lifecycle
    
    private void Awake()
    {
        // TODO: Initialize singleton, prevent duplicates
        throw new System.NotImplementedException("Singleton initialization required");
    }
    
    private void Start()
    {
        // TODO: Initialize game state, load level data, setup event listeners
        throw new System.NotImplementedException("Game initialization required");
    }
    
    private void Update()
    {
        // TODO: Update turn timer, check win/lose conditions
        throw new System.NotImplementedException("Game loop update required");
    }
    
    #endregion

    #region State Management
    
    /// <summary>
    /// Transition to a new game state. Notifies all subscribers.
    /// </summary>
    /// <param name="newState">Target state</param>
    public void ChangeState(GameState newState)
    {
        // TODO: Validate state transition, update CurrentState, fire event
        throw new System.NotImplementedException("State transition logic required");
    }
    
    /// <summary>
    /// Start a new game from the beginning.
    /// </summary>
    public void StartNewGame()
    {
        // TODO: Reset score, level, load first level, change to Playing state
        throw new System.NotImplementedException("New game logic required");
    }
    
    /// <summary>
    /// Start the next level.
    /// </summary>
    public void NextLevel()
    {
        // TODO: Increment level, load level data, reset board
        throw new System.NotImplementedException("Level progression required");
    }
    
    /// <summary>
    /// End current game session.
    /// </summary>
    public void GameOver()
    {
        // TODO: Save high score, show game over UI, change state
        throw new System.NotImplementedException("Game over logic required");
    }
    
    /// <summary>
    /// Pause/unpause the game.
    /// </summary>
    public void TogglePause()
    {
        // TODO: Toggle time scale, show/hide pause menu
        throw new System.NotImplementedException("Pause logic required");
    }
    
    #endregion

    #region Scoring
    
    /// <summary>
    /// Add points to current score.
    /// </summary>
    /// <param name="points">Points to add</param>
    /// <param name="source">What caused the score (for analytics)</param>
    public void AddScore(int points, string source)
    {
        // TODO: Add points, check for high score, fire ScoreUpdated event
        throw new System.NotImplementedException("Scoring logic required");
    }
    
    /// <summary>
    /// Check if current score meets target for level completion.
    /// </summary>
    /// <returns>True if target met</returns>
    public bool CheckWinCondition()
    {
        // TODO: Compare currentScore >= targetScore
        throw new System.NotImplementedException("Win condition check required");
    }
    
    #endregion

    #region Data Access
    
    /// <summary>
    /// Get current game statistics.
    /// </summary>
    public (int score, int level, int slimesDropped) GetStats()
    {
        // TODO: Return tuple of current stats
        throw new System.NotImplementedException("Stats getter required");
    }
    
    #endregion
}
