using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using Bullet;

namespace BulletTest
{
    public class BulletFireTest
    {
        BulletFire bulletFire = new BulletFire();

        [Test]
        public void SetBulletSpeed_Speed0_Return0_0() 
        {
            Vector2 result = bulletFire.SetBulletSpeed(0);

            Assert.That(result == new Vector2(0, 0));
        }

        [Test]
        public void SetBulletSpeed_Speed5_Return0_5()
        {
            Vector2 result = bulletFire.SetBulletSpeed(5);

            Assert.That(result == new Vector2(0, 5));
        }

        [Test]
        public void SetBulletSpeed_SpeedMinus5_Return0_Minus5() 
        {
            Vector2 result = bulletFire.SetBulletSpeed(-5);

            Assert.That(result == new Vector2(0, -5));
        }
    }
}
