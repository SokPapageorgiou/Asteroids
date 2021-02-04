using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateSpeed;

    private float _verticalInput;
    private float _horizontalInput;

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetInputAxis();
    }
    
    private void FixedUpdate()
    {
        ApplyForce();
        Rotate();
    }

    private void GetInputAxis()
    {
        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    private void ApplyForce()
    {
        Vector2 _velocity = new Vector2(0, _verticalInput);
        if (_velocity.magnitude > 1) _velocity.Normalize();

        _rigidbody2D.AddRelativeForce(_velocity * _movementSpeed, ForceMode2D.Impulse);
    }

    private void Rotate() 
    {
        _rigidbody2D.rotation += _horizontalInput * _rotateSpeed;
    }
}
