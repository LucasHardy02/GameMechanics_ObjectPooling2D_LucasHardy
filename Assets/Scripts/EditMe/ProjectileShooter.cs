using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectileShooter : MonoBehaviour
{
    
    // create fields for the bullet prefab and the firePoint (where the bullet should spawn)


    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform Enemy;

    // TODO: After you get your bullets working, set up the ObjectPool class
    // Then create an ObjectPool type field here. The bullet prefab will be referenced

    [SerializeField] private ObjectPool bulletPool;

    // in the object pool rather than here. 

    void OnAttack(InputValue value)
    {
        Shoot();
    }

    void Shoot()
    {

        GameObject bulletPrefab = bulletPool.GetGameObject();
        //returns null
        if (bulletPrefab == null)
        {
            return;
        }

        bulletPrefab.SetActive(true);
        bulletPrefab.transform.position = firePoint.position;
        bulletPrefab.transform.rotation = firePoint.rotation;

        Debug.Log("Shoot");
        //instantiate your bullet here
        //Make sure it has the right position and rotation. 

    }


}
