using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Commons
{ 
    public class ObjectPooling : MonoBehaviour
    {
        [HideInInspector]
        public Queue<GameObject> pool;
        
        [SerializeField]
        private GameObject _objectToPool;
        
        [SerializeField]
        private int _amountToPool;

        private void Start()
        {
            pool = new Queue<GameObject>();

            GameObject temp;
            for (int i = 0; i < _amountToPool; i++)
            {
                temp = Instantiate(_objectToPool);
                temp.transform.SetParent(gameObject.transform);
                AddGameObjToQueue(temp, pool);
            }
        }

        public void AddGameObjToQueue(GameObject temp, Queue<GameObject> pool)
        {
            temp.SetActive(false);
            pool.Enqueue(temp);
        }

        public GameObject ActivateGameObjectFromPool(Queue<GameObject> pool) 
        {
            GameObject temp = pool.Dequeue();
            temp.SetActive(true);
            pool.Enqueue(temp);

            return temp;
        }
    }
}
