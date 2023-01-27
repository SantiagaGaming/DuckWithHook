using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    [SerializeField] private Transform _newPosition;
    public Transform GetNewPosition()
    {
        return _newPosition;
    }

}
