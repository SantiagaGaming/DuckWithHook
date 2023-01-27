using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _cameraMoveSpeed = 4;

    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x-1.4f, _player.transform.position.x, Time.deltaTime * _cameraMoveSpeed),
                                               Mathf.Lerp(transform.position.y, _player.transform.position.y+4f, Time.deltaTime * _cameraMoveSpeed),
                                               Mathf.Lerp(transform.position.z-0.1f, _player.transform.position.z, Time.deltaTime * _cameraMoveSpeed));
    }
}