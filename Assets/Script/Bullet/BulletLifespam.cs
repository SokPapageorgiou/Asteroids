using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifespam : MonoBehaviour
{
    [SerializeField]
    private float _lifespam;

    public void OnEnabled()
    {
        Invoke("Deactivate", _lifespam);
    }

    private void Deactivate() 
    {
        gameObject.SetActive(false);
    }

    
}
