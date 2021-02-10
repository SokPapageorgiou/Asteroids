using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifespam : MonoBehaviour
{
    [SerializeField]
    private float _lifespam;

    void Start()
    {
        Invoke("Deactivate", _lifespam);
    }

    private void Deactivate() 
    {
        gameObject.SetActive(false);
    }

    
}
