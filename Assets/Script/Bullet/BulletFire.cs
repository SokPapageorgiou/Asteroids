using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Commons;

namespace Bullet
{
    [RequireComponent(typeof(ObjectPooling))]
    [RequireComponent(typeof(BulletObjectsLoader))]
    public class BulletFire : MonoBehaviour
    {   
        private ObjectPooling   _bulletPool;
        private BulletStats     _bulletStats;
        private GameObject      _bullet;
        private bool            _fire;

        private void Start()
        {
            _bulletPool = GetComponent<ObjectPooling>();
            _bulletStats = GetComponent<BulletObjectsLoader>().bulletStats;
        }

        private void Update()
        {
            _fire = _bulletStats.fire;
        }

        private void FixedUpdate()
        {
            if (_fire)
            {
                _bullet = _bulletPool.ActivateGameObjectFromPool(_bulletPool.pool);
                _bullet.transform.position = _bulletStats.position;
                Rigidbody2D rigidBody2d = _bullet.GetComponent<Rigidbody2D>();
                rigidBody2d.AddForce(SetForce(_bulletStats.angle) * _bulletStats.speed);
            }
        }

        public Vector2 SetForce(float angleDegree) 
        {
            float radians = Degree2Rad(angleDegree);

            float x = SetForceX(radians);
            float y = SetForceY(radians);

            return new Vector2(x, y);
        }
        
        public float Degree2Rad(float degree) 
        {
            return degree * Mathf.Deg2Rad;
        }

        public float SetForceY(float radians)
        {
            return Mathf.Sin(radians);
        }

        public float SetForceX(float radians)
        {
            return Mathf.Cos(radians);
        }
    }
}
