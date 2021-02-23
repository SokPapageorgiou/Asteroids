using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using Player;

namespace PlayerTest
{
    public class MovementTest 
    {
        Movement _movement = new Movement();

        [Test]
        public void SetForceVector_VerticalInputPositive_Return_0_1()
        {
            Vector2 result = _movement.SetForceVector(1);
            Vector2 expectedReturn = new Vector2(0, 1);

            Assert.That(result == expectedReturn);
        }

        [Test]
        public void SetForceVector_VerticalInputNegative_Return_0_minus1()
        {
            Vector2 result = _movement.SetForceVector(-1);
            Vector2 expectedReturn = new Vector2(0, -1);

            Assert.That(result == expectedReturn);
        }

        [Test]
        public void SetForceVector_VerticalInputZero_Return_0_0()
        {
            Vector2 result = _movement.SetForceVector(-1);
            Vector2 expectedReturn = new Vector2(0, -1);

            Assert.That(result == expectedReturn);
        }

        [Test]
        public void SetForce_VerticalInputPositive_MovStrenghtTen_Return_0_10()
        {
            Vector2 result = _movement.SetForce(1, 10);
            Vector2 expectedReturn = new Vector2(0, 10);

            Assert.That(result == expectedReturn);
        }

        [Test]
        public void SetForce_VerticalInputNegative_MovStrenghtTen_Return_0_minus10()
        {
            Vector2 result = _movement.SetForce(-1, 10);
            Vector2 expectedReturn = new Vector2(0, -10);

            Assert.That(result == expectedReturn);
        }

        [Test]
        public void SetForce_VerticalInputZero_MovStrenghtTen_Return_0_0()
        {
            Vector2 result = _movement.SetForce(0, 10);
            Vector2 expectedReturn = new Vector2(0, 0);

            Assert.That(result == expectedReturn);
        }

        [Test]
        public void SetForce_VerticalInputPositive_MovStrenghtZero_Return_0_0()
        {
            Vector2 result = _movement.SetForce(1, 0);
            Vector2 expectedReturn = new Vector2(0, 0);

            Assert.That(result == expectedReturn);
        }

        [Test]
        public void SetForce_VerticalInputPositive_MovStrenghtMinus10_Return_0_minus10()
        {
            Vector2 result = _movement.SetForce(1, -10);
            Vector2 expectedReturn = new Vector2(0, -10);

            Assert.That(result == expectedReturn);
        }
    }
}
