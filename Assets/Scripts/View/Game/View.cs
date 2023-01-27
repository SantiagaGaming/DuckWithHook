using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class View : MonoBehaviour
{
    public UnityAction OnExitButtonClick;
    public UnityAction OnRestartButtonClick;

    [SerializeField] private GameObject _endGamePanel;
    [SerializeField] private GameObject _jumpButton;
    [SerializeField] private Text _pointsText;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;
    private void Start()
    {
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
    }

    public void ChangePointsText(string text)
    {
        _pointsText.text = "score: "+ text;
    }
    public void EnableEndGamePanel(bool value)
    {
        _endGamePanel.SetActive(value);
    }
    public void EnableJumpButton(bool value)
    {
        _jumpButton.SetActive(value);
    }
}
