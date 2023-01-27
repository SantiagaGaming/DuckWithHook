using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHook : MonoBehaviour
{
    public UnityAction OnHookConnected;
    public UnityAction OnEndGameBoxTouched;

    [SerializeField] private GameObject _duck;
    [SerializeField] private DuckExploading _duckExploading;

    private Rigidbody _duckRb;
    private PlayerMover _playerMover;

    private void Start()
    {
        _duckRb = _duck.GetComponent<Rigidbody>();
        _playerMover = _duck.GetComponent<PlayerMover>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Hook hook))
        {
            _duckRb.isKinematic = true;
            _duck.transform.position = hook.GetNewPosition().position;
            _duck.transform.parent = hook.transform;
            _playerMover.AllowJump();
            OnHookConnected?.Invoke();
        }
        if(other.TryGetComponent(out EndGameBox box))
        {
            _duckExploading.ExplodeDuck();
            StartCoroutine(DelayInvoke());
        }
    }
    private IEnumerator DelayInvoke()
    {
        yield return new WaitForSeconds(0.2f);
        OnEndGameBoxTouched?.Invoke();
    }
}
