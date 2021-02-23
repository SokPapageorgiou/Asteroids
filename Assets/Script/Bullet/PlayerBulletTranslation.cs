using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Bullet
{
    public class PlayerBulletTranslation : MonoBehaviour
    {
        [SerializeField]
        private UserInputListner userInputListner;
        [SerializeField]
        private PlayerListner playerListner;
        [SerializeField]
        private BulletStats bulletStats;

        private void Update()
        {
            bulletStats.position = playerListner.position;
            bulletStats.angle = playerListner.angleInDegrees;

            bulletStats.fire = userInputListner.fire;
        }
    }
}
