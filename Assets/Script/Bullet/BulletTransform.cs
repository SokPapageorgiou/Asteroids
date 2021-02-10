using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTransform : MonoBehaviour, IPooledObject
{
    private GameObject _player;
    private BulletForce _bulletForce;
    
    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _bulletForce = GetComponent<BulletForce>();
    }

    public void OnObjectSpawn()
    {
        SetPosition(_player.transform.position);
        SetRotation(_player.transform.eulerAngles);

        _bulletForce.ApplyForce();
    }

    private void SetPosition(Vector3 position)
    {
        transform.localPosition = position;
    }

    private void SetRotation(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }
}
