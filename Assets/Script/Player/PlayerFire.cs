using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    private ObjectPooler _objectPooler;

    private void Start()
    {
        _objectPooler = ObjectPooler.Instance;    
    }

    void Update()
    {
        if (Input.GetKeyDown("space")) Fire();
    }

    private void Fire() 
    {
        _objectPooler.SpawnFromPool("Bullet");
    }
}
