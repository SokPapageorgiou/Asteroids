using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed;
    private float _verticalInput;
    
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetInputVertical();
    }
    
    private void FixedUpdate()
    {
        ApplyForce();
    }

    private void GetInputVertical()
    {
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void ApplyForce()
    {
        Vector2 _velocity = new Vector2(0, _verticalInput);
        if (_velocity.magnitude > 1) _velocity.Normalize();

        _rigidbody2D.AddRelativeForce(_velocity * _movementSpeed, ForceMode2D.Impulse);
    }
}
