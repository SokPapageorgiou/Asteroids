using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet
{
    [CreateAssetMenu(fileName = "BulletStats", menuName = "ScriptableObjects/Bullet/Stats")]
    public class BulletStats : ScriptableObject
    {
        [Header("Transform")]
        public Vector2 position;
        public float angle;

        [Header("Actions")]
        public bool fire;

        [Header("Editables")]
        public float speed;
        public float lifeSpawn;
    }
}
