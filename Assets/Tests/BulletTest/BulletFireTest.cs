using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using Bullet;

namespace BulletFireTest
{
    public class BulletFireTest
    {
        private BulletFire _bulletFire = new BulletFire();

        [Test]
        public void Degree2Rad_Angle0_Return0() 
        {
            float result = _bulletFire.Degree2Rad(0);

            Assert.That(result == 0);
        }

        [Test]
        public void Degree2Rad_Angle180_ReturnPi()
        {
            float result = _bulletFire.Degree2Rad(180);

            Assert.That(result == Mathf.PI);
        }

        [Test]
        public void Degree2Rad_Angle90_ReturnPiDiv2()
        {
            float result = _bulletFire.Degree2Rad(90);

            Assert.That(result == Mathf.PI/2);
        }

        [Test]
        public void Degree2Rad_Angle270_Return3PiDiv2()
        {
            float result = _bulletFire.Degree2Rad(270);

            Assert.That(result == Mathf.PI * 3 / 2);
        }

        [Test]
        public void Degree2Rad_Angle30_ReturnPiDiv6()
        {
            float result = _bulletFire.Degree2Rad(30);

            Assert.That(result == Mathf.PI / 6);
        }

        [Test]
        public void Degree2Rad_Angle45_ReturnPiDiv4()
        {
            float result = _bulletFire.Degree2Rad(45);

            Assert.That(result == Mathf.PI / 4);
        }

        [Test]
        public void Degree2Rad_Angle60_ReturnPiDiv3()
        {
            float result = _bulletFire.Degree2Rad(60);

            Assert.That(result == Mathf.PI / 3);
        }

        [Test]
        public void SetForceY_Angle0_Return0() 
        {
            float result = _bulletFire.SetForceY(0);

            Assert.That(result == 0);
        }

        [Test]
        public void SetForceY_AnglePIDiv2_Return1()
        {
            float result = _bulletFire.SetForceY(Mathf.PI/2);

            Assert.That(result == 1);
        }

        [Test]
        public void SetForceY_AnglePI_Return0()
        {
            float result = _bulletFire.SetForceY(Mathf.PI);

            Assert.That(result == Mathf.Sin(Mathf.PI));
        }

        [Test]
        public void SetForceY_Angle3PIDiv2_ReturnMinus1()
        {
            float result = _bulletFire.SetForceY(3 * Mathf.PI / 2);

            Assert.That(result == -1);
        }

        [Test]
        public void SetForceX_Angle0_Return1()
        {
            float result = _bulletFire.SetForceX(0);

            Assert.That(result == 1);
        }

        [Test]
        public void SetForceX_AnglePIDiv2_Return0()
        {
            float result = _bulletFire.SetForceX(Mathf.PI / 2);

            Assert.That(result == Mathf.Cos(Mathf.PI / 2));
        }

        [Test]
        public void SetForceX_AnglePI_ReturnMinus1()
        {
            float result = _bulletFire.SetForceX(Mathf.PI);

            Assert.That(result == Mathf.Cos(Mathf.PI));
        }

        [Test]
        public void SetForceX_Angle3PIDiv2_Return0()
        {
            float result = _bulletFire.SetForceX(3 * Mathf.PI / 2);

            Assert.That(result == Mathf.Cos(3 * Mathf.PI / 2));
        }

        [Test]
        public void SetForce_Angle0_Return_1_0() 
        {
            Vector2 result = _bulletFire.SetForce(0);

            Assert.That(result == new Vector2(1, 0));
        }

        [Test]
        public void SetForce_Angle90_Return_0_1()
        {
            Vector2 result = _bulletFire.SetForce(90);

            Assert.That(result == new Vector2(0, 1));
        }
    }
}
