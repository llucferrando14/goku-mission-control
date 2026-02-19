using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// GameManager - Central game state controller
/// Manages game flow, score, level progression, and coordinates all systems
/// </summary>
public class GameManager : MonoBehaviour
{
    #region Singleton Pattern
    public static GameManager Instance { get; private set; }
    #endregion

    #region Game State
    public enum GameState
    {
        Menu,
        Playing,
        Paused,
        GameOver,
        LevelComplete
    }
    
    public GameState CurrentState { get; private set; }
    #endregion

    #region Core Systems References
    [Header("Core Systems")]
    [SerializeField] private SlimeController slimeController;
    [SerializeField] private PegBoard pegBoard;
    [SerializeField] private ColorMatcher colorMatcher;
    [SerializeField] private ChainReaction chainReaction;
    #endregion

    #region Game Data
    [Header("Game Data")]
    [SerializeField] private int currentScore;
    [SerializeField] private int currentLevel;
    [SerializeField] private int slimesRemaining;
    [SerializeField] private int targetScore;
    #endregion

    #region Events
    public System.Action<int> OnScoreChanged;
    public System.Action<int> OnLevelChanged;
    public System.Action<GameState> OnGameStateChanged;
    public System.Action OnGameOver;
    public System.Action OnLevelComplete;
    #endregion

    #region Unity Lifecycle
    private void Awake()
    {
        // TODO: Implement singleton initialization
        // TODO: Set Instance = this
        // TODO: DontDestroyOnLoad if needed
    }

    private void Start()
    {
        // TODO: Initialize all core systems
        // TODO: Load level data
        // TODO: Set initial state to Menu
    }

    private void Update()
    {
        // TODO: Handle input based on current state
        // TODO: Check win/lose conditions
    }
    #endregion

    #region State Management
    public void SetGameState(GameState newState)
    {
        // TODO: Validate state transition
        // TODO: Exit current state logic
        // TODO: Set CurrentState = newState
        // TODO: Enter new state logic
        // TODO: Invoke OnGameStateChanged
    }

    public void StartGame()
    {
        // TODO: Reset score and level
        // TODO: Initialize first level
        // TODO: Set state to Playing
    }

    public void PauseGame()
    {
        // TODO: Set state to Paused
        // TODO: Show pause menu
        // TODO: Stop physics/time if needed
    }

    public void ResumeGame()
    {
        // TODO: Set state to Playing
        // TODO: Hide pause menu
        // TODO: Resume physics/time
    }

    public void EndGame()
    {
        // TODO: Set state to GameOver
        // TODO: Show game over UI
        // TODO: Save high score
        // TODO: Invoke OnGameOver
    }
    #endregion

    #region Score Management
    public void AddScore(int points)
    {
        // TODO: Add points to currentScore
        // TODO: Invoke OnScoreChanged
        // TODO: Check for level completion
    }

    public void ResetScore()
    {
        // TODO: Reset currentScore to 0
        // TODO: Invoke OnScoreChanged
    }
    #endregion

    #region Level Management
    public void LoadLevel(int levelNumber)
    {
        // TODO: Validate level exists
        // TODO: Load level configuration
        // TODO: Initialize peg board
        // TODO: Reset slimes for the level
        // TODO: Set target score
    }

    public void NextLevel()
    {
        // TODO: Increment currentLevel
        // TODO: LoadLevel(currentLevel)
        // TODO: Invoke OnLevelChanged
        // TODO: Set state to LevelComplete briefly, then Playing
    }
    #endregion

    #region Slime Management
    public void OnSlimeDropped()
    {
        // TODO: Decrement slimesRemaining
        // TODO: Check if out of slimes
        // TODO: Trigger Game Over if no slimes and target not met
    }

    public void AddSlimes(int count)
    {
        // TODO: Add count to slimesRemaining (power-up reward)
    }
    #endregion

    #region Utility
    public bool IsPlaying()
    {
        return CurrentState == GameState.Playing;
    }

    public void RestartLevel()
    {
        // TODO: Reload current level
        // TODO: Reset score for the level
    }
    #endregion
}
