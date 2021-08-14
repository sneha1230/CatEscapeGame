using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody bulletRB;
    public float bulletSpeed;
    
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        bulletRB.AddForce(transform.forward * bulletSpeed);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        StartCoroutine("BulletAddToPool");
    }
    IEnumerator BulletAddToPool()
    {
        yield return new WaitForSeconds(1);
        if (bulletRB.gameObject.name == "Bullet")
        {
            BulletPool.Instance.AddBulletToPool(bulletRB.gameObject);
        }
    }
}
