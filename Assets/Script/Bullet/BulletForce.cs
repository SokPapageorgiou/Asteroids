using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletForce : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed;

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    public void ApplyForce()
    {
        _rigidbody2D.AddForce(SetForceVector() * _movementSpeed, ForceMode2D.Impulse);
    }

    private Vector2 SetForceVector()
    {
        Vector2 _forceDirection = new Vector2(Mathf.Sin(-TransformZAngleInRadians()), Mathf.Cos(TransformZAngleInRadians()));
        if (_forceDirection.magnitude > 1) _forceDirection.Normalize();

        return _forceDirection;
    }

    private float TransformZAngleInRadians()
    {
        return transform.eulerAngles.z * Mathf.Deg2Rad;
    }
}
