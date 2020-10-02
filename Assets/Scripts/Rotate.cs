using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Rigidbody2D rotator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Rotation
        if (Input.GetKey(KeyCode.E))
        {
            rotator.rotation -= 10f;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rotator.rotation += 10f;
        }
    }
}
