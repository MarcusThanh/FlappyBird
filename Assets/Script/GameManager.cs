using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;
    public static event Action<GameState> OnGameStateChanged; 
    public GameState State;
    protected GameManager(){}
    
    

    public static GameManager getGameMananger()
    {
        if (_instance == null)
        {
            return new GameManager();
        }
        else
        {
            Debug.Log("There only can be one Game Manager at any given time");
            return _instance;
        }
    }
    void Awake()
    {
        _instance = new GameManager();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch(newState)
        {

            case GameState.OnIntroScreen:
                break;
            case GameState.PlayerAlive:
                break;
            case GameState.PlayerDie:
                HandlePlayerDie();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, "Invalid State");
        }

        OnGameStateChanged?.Invoke(newState);
    }
    private static void HandlePlayerDie()
    {
        Debug.Log("Player Die from game manager");
    }

}

public enum GameState
{
    OnIntroScreen,
    PlayerAlive,
    PlayerDie,

}
