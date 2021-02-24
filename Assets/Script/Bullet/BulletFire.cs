using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Commons;

namespace Bullet
{
    [RequireComponent(typeof(ObjectPooling))]
    [RequireComponent(typeof(BulletObjectsLoader))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class BulletFire : MonoBehaviour
    {   
        private ObjectPooling _bulletPool;
        private BulletStats _bulletStats;
        private GameObject _bullet;
        private bool _fire;

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
                _bullet.transform.eulerAngles = new Vector3(0, 0, _bulletStats.angle);

                _bullet.GetComponent<Rigidbody2D>().AddRelativeForce(SetBulletSpeed(_bulletStats.speed));
            }
        }

        public Vector2 SetBulletSpeed(float speed) 
        {
            return new Vector2(0, speed);
        }
    }
}
