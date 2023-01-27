using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookLoader : MonoBehaviour
{
    [SerializeField] private HookMover _prefub;
    [SerializeField] private PlayerHook _playerHook;
    private Transform _newHookPos;
    private void Start()
    {
        _newHookPos = transform;
        _newHookPos.transform.position = new Vector3(5.5f,2.85f,-20);

    }
    private void OnEnable()
    {
        _playerHook.OnHookConnected += OnInstatiateNewHook;
    }
    private void OnDisable()
    {
        _playerHook.OnHookConnected -= OnInstatiateNewHook;
    }
    private void OnInstatiateNewHook()
    {

        HookMover temp = Instantiate(_prefub, transform.position, Quaternion.identity);
        temp.SetHookMoveSide(Random.Range(0, 3));
        temp.transform.position = _newHookPos.position;
        temp.transform.rotation = _newHookPos.rotation;
        _newHookPos.position -= new Vector3(0, 0, 5.5f);
    }


}
