using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CameraGamePlayArea : MonoBehaviour
{
    void Awake()
    {
        BoxCollider2D _boxCollider2D = GetComponent<BoxCollider2D>();
        
        SetBoxColliderSize(_boxCollider2D);
        
        _boxCollider2D.isTrigger = true;
    }

    private static void SetBoxColliderSize(BoxCollider2D _boxCollider2D)
    {
        float _height = Camera.main.orthographicSize * 2;
        float _width = Camera.main.aspect * _height * 2;
        _boxCollider2D.size = new Vector2(_width, _height);
    }

}
