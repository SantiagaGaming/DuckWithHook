using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum HookSide
{
    Right,
    Left,
    Up
}
public class HookMover : MonoBehaviour
{

    [SerializeField] private float _moveSpeed;
    [SerializeField] private HookSide _side;

    private Vector3 _movePos;
    private float _moveSeconds;
    private void Start()
    {
        if (_side == HookSide.Right)
            _movePos = Vector3.right;
        else if (_side == HookSide.Left)
            _movePos = Vector3.left;
        else _movePos = Vector3.down;
    }
    private void Update()
    {
        _moveSeconds += Time.deltaTime;
        transform.Translate(_movePos * _moveSpeed * Time.deltaTime);
        if(_moveSeconds >=6f)
        {
            VectorChanger();
            _moveSeconds = 0f;
        }
    }
    private void VectorChanger()
    {
        if (_movePos == Vector3.right)
            _movePos = Vector3.left;
        else if (_movePos == Vector3.left)
            _movePos = Vector3.right;
        else if (_movePos == Vector3.down)
            _movePos = Vector3.up;
        else if (_movePos == Vector3.up)
            _movePos = Vector3.down;
    }
    public void SetHookMoveSide(int side)
    {
        switch(side)
        {
            case 0:
                _side = HookSide.Left;
                break;
            case 1:
                _side = HookSide.Right;
                break;
            case 2:
                _side = HookSide.Up;
                break;
        }
    }
}
