using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class RocketController : MonoBehaviour
{
    private Rigidbody rb;

    void Thrust()
    {
        rb.AddRelativeForce(Vector3.up * 25);

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Thrust();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Rotate(-0.8f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Rotate(0.8f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.Rotate(0, 0, 0.8f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            transform.Rotate(0, 0, -0.8f);
        }
    }
}
