using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private PlayerHook _playerHook;
    [SerializeField] private View _view;
    [SerializeField] private EndGameBox _endGameBox;

    private int _points;

    private void OnEnable()
    {
        _playerHook.OnHookConnected += OnPointsChanged;
        _playerHook.OnEndGameBoxTouched += OnGameEnd;
        _view.OnRestartButtonClick += OnRestartGame;
        _view.OnExitButtonClick += OnExitGame;
    }
    private void OnDisable()
    {
        _playerHook.OnHookConnected -= OnPointsChanged;
        _playerHook.OnEndGameBoxTouched -= OnGameEnd;
        _view.OnRestartButtonClick -= OnRestartGame;
        _view.OnExitButtonClick -= OnExitGame;
    }
    private void OnPointsChanged()
    {
        _points++;
        _view.ChangePointsText(_points.ToString());
        _endGameBox.MoveEndGameBox(_playerHook.transform.position.z);
    }
    private void OnGameEnd()
    {
        StartCoroutine(EndGameDelay());
    }
    private IEnumerator EndGameDelay()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0f;
        _view.EnableEndGamePanel(true);
        _view.EnableJumpButton(false);
    }
    private void OnRestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
    private void OnExitGame()
    {
        Application.Quit();
    }

}
