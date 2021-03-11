using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(ObjectsLoader))]
    public class Rotation : MonoBehaviour
    {
        private ObjectsLoader _objLoader;

        private void Start()
        {
            _objLoader = GetComponent<ObjectsLoader>();    
        }

        private void Update()
        {
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + _objLoader.playerStats.angleOffset;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
