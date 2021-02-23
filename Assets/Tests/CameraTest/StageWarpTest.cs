using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using MainCamera;

namespace MainCameraTest
{
    public class StageWarpTest
    {
        private StageWarp _stageWarp = new StageWarp();
        
        [Test]
        public void InvertNumber_One_ReturnMinusOne() 
        {
            float result = _stageWarp.InvertNumber(1);

            Assert.That(result == -1);
        }

        [Test]
        public void InvertNumber_Minus6_Return6()
        {
            float result = _stageWarp.InvertNumber(-6);

            Assert.That(result == 6);
        }

        [Test]
        public void IsNumberOutOfRange_Range1Num0_ReturnFalse() 
        {
            bool result = _stageWarp.IsNumberOutOfRange(1,0);

            Assert.That(result == false);
        }

        [Test]
        public void IsNumberOutOfRange_Range1Num1_ReturnFalse()
        {
            bool result = _stageWarp.IsNumberOutOfRange(1, 1);

            Assert.That(result == false);
        }

        [Test]
        public void IsNumberOutOfRange_Range1NumMinus1_ReturnFalse()
        {
            bool result = _stageWarp.IsNumberOutOfRange(1, -1);

            Assert.That(result == false);
        }

        [Test]
        public void IsNumberOutOfRange_Range1Num2_ReturnTrue()
        {
            bool result = _stageWarp.IsNumberOutOfRange(1, 2);

            Assert.That(result == true);
        }

        [Test]
        public void IsNumberOutOfRange_Range1NumMinus2_ReturnTrue()
        {
            bool result = _stageWarp.IsNumberOutOfRange(1, -2);

            Assert.That(result == true);
        }

        [Test]
        public void WarpInOneAxis_Range2Num1_Return1() 
        {
            float result = _stageWarp.WarpInOneAxis(2 , 1);

            Assert.That(result == 1);
        }

        [Test]
        public void WarpInOneAxis_Range2NumMinus1_ReturnMinus1()
        {
            float result = _stageWarp.WarpInOneAxis(2, -1);

            Assert.That(result == -1);
        }

        [Test]
        public void WarpInOneAxis_Range2Num2_Return2()
        {
            float result = _stageWarp.WarpInOneAxis(2, 2);

            Assert.That(result == 2);
        }

        [Test]
        public void WarpInOneAxis_Range2NumMinus2_ReturnMinus2()
        {
            float result = _stageWarp.WarpInOneAxis(2, -2);

            Assert.That(result == -2);
        }

        [Test]
        public void WarpInOneAxis_Range2Num3_ReturnMinus3()
        {
            float result = _stageWarp.WarpInOneAxis(2, 3);

            Assert.That(result == -3);
        }

        [Test]
        public void WarpInOneAxis_Range2NumMinus3_Return3()
        {
            float result = _stageWarp.WarpInOneAxis(2, -3);

            Assert.That(result == 3);
        }

        [Test]
        public void WarpInOneAxis_Range2Num100_ReturnMinus100()
        {
            float result = _stageWarp.WarpInOneAxis(2, 100);

            Assert.That(result == -100);
        }

        [Test]
        public void WarpInOneAxis_Range2NumMinus100_Return100()
        {
            float result = _stageWarp.WarpInOneAxis(2, -100);

            Assert.That(result == 100);
        }
    }
}
