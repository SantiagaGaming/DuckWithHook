using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _jumpPower;
    private Rigidbody _rb;
    private bool _jump = true;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
public void Jump()
    {
        if(_jump)
        {
            _jump = false;
            _rb.isKinematic = false;
            transform.parent = null;
            _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            _rb.AddForce(Vector3.forward * -_jumpPower/4, ForceMode.Impulse);
        }
    
    }
    public void AllowJump()
    {
        _jump = true;
    }

}
