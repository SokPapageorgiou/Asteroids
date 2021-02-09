using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTransform : MonoBehaviour
{
    private GameObject _player;

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        Physics2D.IgnoreCollision(_player.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        transform.position = _player.transform.position;
        transform.eulerAngles = _player.transform.eulerAngles;
    }

    
    
}
