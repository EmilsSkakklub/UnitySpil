using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{

    public bool reverseGravity = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if (reverseGravity == true && Input.GetKeyDown(KeyCode.G))
        {
            reverseGravity = false;
        }
        else if (reverseGravity == false && Input.GetKeyDown(KeyCode.G))
        {
            reverseGravity = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (reverseGravity == false)
        {
            Physics2D.gravity = new Vector2(0, -25);
        }
        else if (reverseGravity == true)
        {
            Physics2D.gravity = new Vector2(0, 25);
        }
    }

}
