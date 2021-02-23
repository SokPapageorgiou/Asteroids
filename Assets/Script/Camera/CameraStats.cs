using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainCamera
{
    [CreateAssetMenu(fileName = "CameraListner", menuName ="ScriptableObjects/Camera/Listner")]
    public class CameraStats : ScriptableObject
    {
        [Header("Camera")]
        public float orthograficSize;
        public float aspect;

        [Header("GamePlay Area")]
        public float sizeX;
        public float sizeY;
    }
}
