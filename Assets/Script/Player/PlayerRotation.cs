using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerRotation : MonoBehaviour
{
    private Vector2 _mousePosition2D;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetMousePosition();
    }

    void FixedUpdate()
    {
        _rigidbody2D.MoveRotation(SetRotationInDegrees());
    }

    private void GetMousePosition()
    {
        _mousePosition2D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private float SetRotationInDegrees()
    {
        float _angleOffSetInDegrees = 90;
        float _deltaX = _mousePosition2D.x - transform.position.x;
        float _deltaY = _mousePosition2D.y - transform.position.y;

        return Mathf.Atan2(_deltaY, _deltaX) * Mathf.Rad2Deg - _angleOffSetInDegrees;
    }
}
