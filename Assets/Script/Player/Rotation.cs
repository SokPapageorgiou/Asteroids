using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(ObjectsLoader))]
    public class Rotation : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private ObjectsLoader _objectsLoader;

        private void Start()
        {   
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _objectsLoader = GetComponent<ObjectsLoader>();
        }

        private void FixedUpdate()
        {
            _rigidbody2D.rotation -= Rotate(_objectsLoader.userInputListner.horizontalAxis, _objectsLoader.playerStats.rotationSpeed);
        }

        public float Rotate(float horizontalInput, float rotatioSpeed) 
        {
            return horizontalInput * rotatioSpeed;
        }
    }
}
