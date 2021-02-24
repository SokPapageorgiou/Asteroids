using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Bullet
{
    [RequireComponent(typeof(BulletObjectsLoader))]
    public class PlayerBulletTranslation : MonoBehaviour
    {
        [SerializeField]
        private UserInputListner userInputListner;
        [SerializeField]
        private PlayerListner playerListner;

        private BulletStats bulletStats;

        private void Start()
        {
            bulletStats = GetComponent<BulletObjectsLoader>().bulletStats;
        }

        private void Update()
        {
            bulletStats.position = playerListner.position;
            bulletStats.angle = playerListner.angleInDegrees;

            bulletStats.fire = userInputListner.fire;
        }
    }
}
