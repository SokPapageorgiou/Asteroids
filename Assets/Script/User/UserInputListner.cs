using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UserControl;

[CreateAssetMenu(fileName = "UserInputListner", menuName="ScriptableObjects/User/InputListner") ]
public class UserInputListner : ScriptableObject
{
    public float horizontalAxis;
    public float verticalAxis;
    public bool fire;
}
