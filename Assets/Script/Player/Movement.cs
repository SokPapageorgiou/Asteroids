using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private UserInputListner _userInputListner;
    [SerializeField]
    private Player.Stats _stats;
    
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rigidbody2D.AddForce(SetForce(_userInputListner.verticalAxis, _stats.movementStrenght));
    }

    public Vector2 SetForce(float verticalInput, float movementStrenght) 
    {
        return SetForceVector(verticalInput) * movementStrenght;
    }
    
    public Vector2 SetForceVector(float verticalInput) 
    {
        int forceY = 0;

        if (verticalInput > 0) forceY = 1;
        else if (verticalInput < 0) forceY = -1;
        
        return new Vector2(0, forceY);
    }
}


