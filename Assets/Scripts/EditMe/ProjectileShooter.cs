using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectileShooter : MonoBehaviour
{
    
    // create fields for the bullet prefab and the firePoint (where the bullet should spawn)

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform Enemy;

    // TODO: After you get your bullets working, set up the ObjectPool class
    // Then create an ObjectPool type field here. The bullet prefab will be referenced

    private List<GameObject> bulletPool = new List<GameObject>();

    // in the object pool rather than here. 

    void OnAttack(InputValue value)
    {
        Shoot();
    }

    void Shoot()
    {
        bulletPool.Add(Instantiate(bulletPrefab, firePoint.position, firePoint.rotation));
        //instantiate your bullet here
        //Make sure it has the right position and rotation. 

    }


}
