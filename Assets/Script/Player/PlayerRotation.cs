using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerRotation : MonoBehaviour
{
    [SerializeField]
    private float _rotateSpeed;
    private float _horizontalInput;

    private Rigidbody2D _rigidbody2D;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetVerticalInput();    
    }

    private void FixedUpdate()
    {
        Rotate();
    }

    private void GetVerticalInput() 
    {
        _horizontalInput = Input.GetAxis("Horizontal");
    }

    private void Rotate() 
    {
        _rigidbody2D.rotation -= _horizontalInput * _rotateSpeed;
    } 
}
