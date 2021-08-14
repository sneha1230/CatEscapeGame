using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropen : MonoBehaviour
{
    public GameObject Door;
    bool doorOpen = false;
   
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(!doorOpen)
        {
            doorOpen = true;
            Door.transform.position += new Vector3(0, 4, 0);
        }

        
    }
}
