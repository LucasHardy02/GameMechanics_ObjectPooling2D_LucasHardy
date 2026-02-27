using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    // create a coroutine that waits for a few seconds and then disables this gameobject.

    public new Coroutine bulletWaitTime;
    
     IEnumerator WaitToDisable()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
    // in OnEnable you can start that coroutine. in OnDisable you can StopAllCoroutines!
    // 
    private void OnEnable()
    {
        bulletWaitTime = StartCoroutine(WaitToDisable());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }

    // This will allow our bullet to get disabled after a few seconds if nothing was hit. 


    // every frame, update the bullet's position using transform.Translate
    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    // You probably want to make a speed variable. 
    [SerializeField] private float speed = 10f;

    // OnTriggerEnter2D, please cause some damage if the other object is an IDamagable! 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamagable damagable))
        {
            damagable.TakeDamage(10);
            gameObject.SetActive(false);
        }
    }


}
