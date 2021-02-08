using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    private GameObject _player;
    
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

        transform.position = _player.transform.position;
        transform.eulerAngles = _player.transform.eulerAngles;
    }

    
    
}
