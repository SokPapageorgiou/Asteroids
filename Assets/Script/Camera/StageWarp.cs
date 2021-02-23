using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainCamera
{   
    [RequireComponent(typeof(CameraObjectsLoader))]
    public class StageWarp : MonoBehaviour
    {
        private CameraStats _cameraStats;

        private void Start()
        {
            _cameraStats = GetComponent<CameraObjectsLoader>().cameraStats;
        }

        void OnTriggerExit2D(Collider2D other)
        {
            float newPositionX = WarpInOneAxis(_cameraStats.sizeX / 2, other.gameObject.transform.position.x);
            float newPositionY = WarpInOneAxis(_cameraStats.sizeY / 2, other.gameObject.transform.position.y);

            other.gameObject.transform.position = new Vector2(newPositionX, newPositionY); 
        }

        public float WarpInOneAxis(float range, float number) 
        {
            if (IsNumberOutOfRange(range, number)) number = InvertNumber(number);

            return number;
        }
        
        public bool IsNumberOutOfRange(float range, float number)
        {
            bool outOfRange;

            if (number >= -range && number <= range) { outOfRange = false; }
            else { outOfRange = true; }
                        
            return outOfRange;
        }
        
        public float InvertNumber(float number)
        {
            return number * -1;
        }
    }    
}
