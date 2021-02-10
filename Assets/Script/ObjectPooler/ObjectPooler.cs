using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool 
    {
        public string tag;
        public GameObject prefab;
        public int size;
        public GameObject parent;
    }

    public List<Pool> pools; 

    public Dictionary<string, Queue<GameObject>> poolDictionary;

    public static ObjectPooler Instance;
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools) 
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                if (pool.parent != null) obj.transform.SetParent(pool.parent.transform);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnFromPool(string tag) 
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool " + tag + " doens't exist.");
            return null;
        }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();
        objectToSpawn.SetActive(true);

        IPooledObject _pooledObject = objectToSpawn.GetComponent<IPooledObject>();
        if (_pooledObject != null) _pooledObject.OnObjectSpawn();

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
   
}
