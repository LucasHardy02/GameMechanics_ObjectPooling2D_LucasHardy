using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    // create a field for the prefab GameObject. 
    [SerializeField] private GameObject prefab;
    
    [SerializeField] private int poolSize = 20;

    // create a field for the number of GameObjects to spawn
    [SerializeField] private int numberOfBulletsToSpawn = 20;

    // create a list of GameObjects called _pool which will hold references to all spawned GameObjects

    new List<GameObject> _pool = new List<GameObject>();

    // in Awake, spawn the appropriate amount of bullets. 
    private void Awake()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(prefab);
            bullet.SetActive(false);
            _pool.Add(bullet);
        }
    }
    // be sure to disable them and add them to your list as you go. 


    // create a method called GetGameObject which returns a GameObject. 
    public GameObject GetGameObject()
    {
        return gameObject;

        if (_pool.Count > 0)
        {
            GameObject bullet = _pool[0];
            _pool.RemoveAt(0);
            return bullet;
        }
        else
        {
            return null;
        }
    }
    // It should look for a GameObject which is not active, returning the first one that it finds. 
    // If there is no inactive one, return null. 

}
