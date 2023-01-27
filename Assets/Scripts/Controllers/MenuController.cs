using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private MainMenuView _mainMenuView;
    private void OnEnable()
    {
        _mainMenuView.OnStartButtonClick += OnStartGame;
        _mainMenuView.OnExitButtonClick += OnExitGame;
    }
    private void OnDisable()
    {
        _mainMenuView.OnStartButtonClick -= OnStartGame;
        _mainMenuView.OnExitButtonClick -= OnExitGame;
    }
    private void OnExitGame()
    {
        Application.Quit();
    }
    private void OnStartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
