using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using Commons;

namespace CommonsTest
{
    public class ObjectPoolingTest
    {
        private ObjectPooling _objectPooling = new ObjectPooling();
         
        [Test]
        public void AddGameObjToQueue_Add3GO_Return3() 
        {
            GameObject temp = new GameObject();
            Queue<GameObject> pool = new Queue<GameObject>();
            
            for (int i = 0; i < 3; i++)
            {
                _objectPooling.AddGameObjToQueue(temp, pool);
            }

            int result = pool.Count;

            Assert.That(result == 3);
        }

        [Test]
        public void AddGameObjToQueue_Add300GO_Return300()
        {
            GameObject temp = new GameObject();
            Queue<GameObject> pool = new Queue<GameObject>();

            for (int i = 0; i < 300; i++)
            {
                _objectPooling.AddGameObjToQueue(temp, pool);
            }

            int result = pool.Count;

            Assert.That(result == 300);
        }

        [Test]
        public void AddGameObjToQueue_AddMinus10GO_Return0()
        {
            GameObject temp = new GameObject();
            Queue<GameObject> pool = new Queue<GameObject>();

            for (int i = 0; i < -10; i++)
            {
                _objectPooling.AddGameObjToQueue(temp, pool);
            }

            int result = pool.Count;

            Assert.That(result == 0);
        }

        [Test]
        public void ActivateGameObjectFromQueue_ReturnTrue() 
        {
            GameObject temp = new GameObject();
            Queue<GameObject> pool = new Queue<GameObject>();

            for (int i = 0; i < 5; i++)
            {
                _objectPooling.AddGameObjToQueue(temp, pool);
            }

            temp = _objectPooling.ActivateGameObjectFromPool(pool);

            bool result = temp.activeSelf;

            Assert.That(result == true);
        }
    }
}
