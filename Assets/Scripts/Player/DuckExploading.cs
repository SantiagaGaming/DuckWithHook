using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckExploading : MonoBehaviour
{
    [SerializeField] private GameObject[] _duckParts;
    [SerializeField] private Animator _anim;
    public void ExplodeDuck()
    {
        _anim.enabled = false;
        foreach (var duckPart in _duckParts)
        {
            if(!duckPart.GetComponent<Rigidbody>())
            duckPart.AddComponent<Rigidbody>();
            var rb = duckPart.GetComponent<Rigidbody>();
            ForceAdded(rb);
        }
    }
    private void ForceAdded(Rigidbody rb)
    {
        int rnd = Random.Range(0, 4);
        Vector3 forceVector = Vector3.down;
        switch (rnd)
        {
            case 0:
                forceVector = Vector3.forward;
                break;
            case 1:
                forceVector = Vector3.down;
                break;
            case 2:
                forceVector = Vector3.left;
                break;
            case 3:
                forceVector = -Vector3.forward;
                break;

        }
        rb.AddForce(forceVector * 10, ForceMode.Impulse);

    }
}
