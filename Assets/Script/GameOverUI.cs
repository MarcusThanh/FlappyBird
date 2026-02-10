using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    GameManager gameManager = GameManager.getGameMananger();
    void Start()
    {
        GameManager.OnGameStateChanged += HandleGameStateChange;
        DisableUI();

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameManager.UpdateGameState(GameState.PlayerAlive);
        Time.timeScale =1.0f;
        Debug.Log("Restarted button Clicked");
    }

    public void OpenShop()
    {
        Debug.Log("Shop button clicked!");
        // Example: open shop panel
        // shopPanel.SetActive(true);
    }

    public void Main_Menu()
    {
        Debug.Log("Go to Main menu clicked!");
    }

    public void HandleGameStateChange(GameState state)
    {
        if (state == GameState.PlayerDie)
        {
            ActiveUI();
        }
        if (state == GameState.PlayerAlive)
        {
            DisableUI();
        }
    }

    public void OnDestroy()
    {
        GameManager.OnGameStateChanged -= HandleGameStateChange;

    }
    public void ActiveUI()
    {
        gameObject.SetActive(true);
    }
    public void DisableUI()
    {
        gameObject.SetActive(false);
    }
}


