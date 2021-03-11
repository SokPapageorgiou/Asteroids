using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UserControl
{
    public class UserInput : MonoBehaviour
    {
        public UserInputListner _userInputListner;

        void Update()
        {
            _userInputListner.horizontalAxis = Input.GetAxis("Horizontal");
            _userInputListner.verticalAxis = Input.GetAxis("Vertical");
            _userInputListner.fire = Input.GetMouseButton(0);
        }
    }   
}
