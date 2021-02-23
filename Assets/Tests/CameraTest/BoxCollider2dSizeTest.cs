using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using MainCamera;

namespace MainCameraTest
{
    public class BoxCollider2dSizeTest
    {
        private BoxCollider2dSize _boxCollider2DSize = new BoxCollider2dSize();

        [Test]
        public void SetSize_Ortho10Aspect2_Return_10_20() 
        {
            Vector2 result = _boxCollider2DSize.SetSize(10, 2);

            Assert.That(result == new Vector2(40,20));
        }

        [Test]
        public void SetSize_Ortho6Aspect1dot_Return_6_9()
        {
            Vector2 result = _boxCollider2DSize.SetSize(6, 1.5f);

            Assert.That(result == new Vector2(18, 12));
        }
    }
}
