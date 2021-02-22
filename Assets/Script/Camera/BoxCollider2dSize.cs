using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainCamera
{
    [RequireComponent(typeof(CameraObjectsLoader))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class BoxCollider2dSize : MonoBehaviour
    {
        private CameraObjectsLoader _objectsLoader;
        private BoxCollider2D _boxCollider2D;

        void Start()
        {
            _objectsLoader = GetComponent<CameraObjectsLoader>();
            _boxCollider2D = GetComponent<BoxCollider2D>();

            _boxCollider2D.size = SetSize(_objectsLoader.cameraStats.orthograficSize, _objectsLoader.cameraStats.aspect);
        }

        public Vector2 SetSize(float orthographicSize, float aspect) 
        {
            return new Vector2(orthographicSize * aspect * 2, orthographicSize * 2);
        }
    }
}
