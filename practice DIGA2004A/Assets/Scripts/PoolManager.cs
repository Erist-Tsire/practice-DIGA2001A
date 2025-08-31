using UnityEngine;
using System.Collections.Generic;

public class PoolManager : MonoBehaviour
{
    public GameObject prefab;
    public int poolSize = 10; // number of objects to pre-instantiate

    private List<GameObject> pool = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   //create a pool of objects
        for(int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
        
    }

    public GameObject GetObject()
    {   // try to find an inactive object in the pool
        for (int i = 0; i< pool.Count; i++)
        {
            if(!pool[i].activeInHierarchy)//if not active in the hierarchy they are available in the pool
            {
                pool[i].SetActive(true);//set object when called
                return pool[i];
            }
        }

        for(int i =0; i< pool.Count; i++)
        {
            pool[i].SetActive(false);
        }

        var obj = pool[0];
        obj.SetActive(true);
        return obj;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
