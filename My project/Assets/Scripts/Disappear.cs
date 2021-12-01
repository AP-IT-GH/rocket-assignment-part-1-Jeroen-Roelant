using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        { Debug.Log("t");
            Destroy(transform.gameObject);
        }
    }
}
