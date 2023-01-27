using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameBox : MonoBehaviour
{
    public void MoveEndGameBox(float zPos)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, zPos);
    }
}
