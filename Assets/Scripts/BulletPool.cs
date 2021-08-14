using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject currentBullet;
    Stack<GameObject> Pool = new Stack<GameObject>();
    public static BulletPool instance;
    // Start is called before the first frame update
    public static BulletPool Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BulletPool>();
            }
            return instance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             CreateBullet();
        }
    }

    public void CreatePool()
    {
            Pool.Push(Instantiate(bulletPrefab));
            Pool.Peek().SetActive(false);
            Pool.Peek().name = "Bullet";
    }

    public void AddBulletToPool(GameObject bullettemp)
    {
        Pool.Push(bullettemp);
        Pool.Peek().SetActive(false);
    }
    public void CreateBullet()
    {
        if (Pool.Count == 0)
        {
            CreatePool();
        }
        GameObject temp = Pool.Pop();
        temp.SetActive(true);
        if (temp.tag == "bullet")
        {
            temp.transform.position = transform.position;
            temp.transform.rotation = transform.rotation;
            currentBullet = temp;
        }
    }
}