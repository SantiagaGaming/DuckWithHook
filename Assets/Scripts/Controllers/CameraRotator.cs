using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    private float _yAngle = 0.08f;
    private void Update()
    {
        transform.rotation= Quaternion.Euler(0,_yAngle,0);
        _yAngle++;
        Reverse();
    }
    private void Reverse()
    {
        if (transform.rotation.y > 180)
            _yAngle = -_yAngle;
    }
}
