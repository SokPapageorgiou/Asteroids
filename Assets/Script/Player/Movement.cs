using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(ObjectsLoader))]
    public class Movement : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private ObjectsLoader _objectsLoader;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _objectsLoader = GetComponent<ObjectsLoader>();
        }
         
        void FixedUpdate()
        {
            _rigidbody2D.AddRelativeForce(SetForce(_objectsLoader.userInputListner.verticalAxis, 
                _objectsLoader.playerStats.movementStrenght));
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
}


