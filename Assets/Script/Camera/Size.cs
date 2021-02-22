using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainCamera
{
    [RequireComponent(typeof(CameraObjectsLoader))]
    public class Size : MonoBehaviour
    {
        private CameraObjectsLoader _cameraObjectsLoader;
        
        void Start()
        {
            _cameraObjectsLoader = GetComponent<CameraObjectsLoader>();
            Camera cam = Camera.main;

            _cameraObjectsLoader.cameraStats.orthograficSize = cam.orthographicSize;
            _cameraObjectsLoader.cameraStats.aspect = cam.aspect;
        }

    }
}
