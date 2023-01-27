using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveCtontroller : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private JumpButton _jumpButton;
    private void OnEnable()
    {
        _jumpButton.JumpButtonPressed += OnPlayerJump;
    }
    private void OnDisable()
    {
        _jumpButton.JumpButtonPressed -= OnPlayerJump;
    }
    private void OnPlayerJump()
    {
        _playerMover.Jump();
    }
}
