using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using Player;

namespace PlayerTest
{
    public class RotationTest
    {
        [Test]
        public void Rotate_HorizontalInputPositiveRotationSpeedTen_Return10() 
        {
            Rotation _rotation = new Rotation();

            float result = _rotation.Rotate(1, 10);

            Assert.That(result == 10);
        }

        [Test]
        public void Rotate_HorizontalInputNegativeRotationSpeedTen_ReturnMinus10()
        {
            Rotation _rotation = new Rotation();

            float result = _rotation.Rotate(-1, 10);

            Assert.That(result == -10);
        }

        [Test]
        public void Rotate_HorizontalInputZeroRotationSpeedTen_Return0()
        {
            Rotation _rotation = new Rotation();

            float result = _rotation.Rotate(0, 10);

            Assert.That(result == 0);
        }
    }
}
