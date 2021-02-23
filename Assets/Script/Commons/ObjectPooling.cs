using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Commons
{ 
    public class ObjectPooling : MonoBehaviour
    {
        private Queue<GameObject> _pool;
        [SerializeField]
        private GameObject _objectToPool;
        [SerializeField]
        private int _amountToPool;

        private void Start()
        {
            _pool = new Queue<GameObject>();

            GameObject temp;
            for (int i = 0; i < _amountToPool; i++)
            {
                temp = Instantiate(_objectToPool);
                temp.SetActive(false);
                temp.transform.SetParent(gameObject.transform);
                _pool.Enqueue(temp);
            }
        }
    }
}
