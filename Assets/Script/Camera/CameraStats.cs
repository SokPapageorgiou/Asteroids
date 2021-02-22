using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainCamera
{
    [CreateAssetMenu(fileName = "CameraListner", menuName ="ScriptableObjects/Camera/Listner")]
    public class CameraStats : ScriptableObject
    {
        public float orthograficSize;
        public float aspect;
    }
}
