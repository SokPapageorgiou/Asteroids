using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTransform : MonoBehaviour, IPooledObject
{
    GameObject _player;
    BulletForce _bulletForce;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _bulletForce = GetComponent<BulletForce>();
    }

    private void Start()
    {
        Physics2D.IgnoreCollision(_player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    public void OnObjectSpawn()
    {
        SetPosition(_player.transform.position);
        SetRotation(_player.transform.eulerAngles);

        _bulletForce.ApplyForce();
    }
    
    private void SetRotation(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }

    private void SetPosition(Vector3 position)
    {
        transform.position = position;
    }


}
