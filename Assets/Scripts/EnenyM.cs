using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnenyM : MonoBehaviour
{
    public float enemySpeed;
    private Vector3 dir = Vector3.left;

    public GameObject player;
    public float Distance;

    public bool Istaret;
    public NavMeshAgent navMesh;
     void Start()
    {
       
    }

    void Update()
    {
        Distance = Vector3.Distance(player.transform.position, this.transform.position);

        if(Distance<=5)
        {
            Istaret = false;
        }
        if (Distance <= 5)
        {
            Istaret = true;
        }
        if(Istaret)
        {
            navMesh.isStopped = false;
            navMesh.SetDestination(player.transform.position);
        }
        if (!Istaret)
        {
            navMesh.isStopped = true;
        }

        if (!Istaret)
        {
            transform.Translate(dir * enemySpeed * Time.deltaTime);

            if (transform.position.x <= -4)
            {
                dir = Vector3.right;
            }
            else if (transform.position.x >= 4)
            {
                dir = Vector3.left;
            }
        }
     
    }

}
//sneha 
//public float enemySpeed;
//private Vector3 dir = Vector3.left;

//// Start is called before the first frame update
//void Start()
//{

//}

//// Update is called once per frame
//void Update()
//{
//    if (gameObject.CompareTag("Enemy"))
//    {
//        transform.Translate(dir * enemySpeed * Time.deltaTime);

//        if (transform.position.x <= -4)
//        {
//            dir = Vector3.right;
//        }
//        else if (transform.position.x >= 4)
//        {
//            dir = Vector3.left;
//        }
//    }
//    if (gameObject.CompareTag("Enemy1"))
//    {
//        transform.Translate(dir * enemySpeed * Time.deltaTime);

//        if (transform.position.x <= -4)
//        {
//            dir = Vector3.right;
//        }
//        else if (transform.position.x >= 4)
//        {
//            dir = Vector3.left;
//        }
//    }
//}
