using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject speedUp;
    public GameObject speedDown;
    public PlayerMovement pm;
    public GravityChange gc;
    public bool TakenBoost;
    public float SpeedUpSpeed = 3;
    public float SpeedUpGravitySpeed = 3;
    public float SpeedDownSpeed = 0.5f;
    public float SpeedDownGravitySpeed = 0.25f;


    private void Start()
    {
        pm = GetComponent<PlayerMovement>();
        gc = GetComponent<GravityChange>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SpeedUp" && !TakenBoost)
        {
                Debug.Log("poweruptaken2");
                Invoke("IsSpeededUp",0);
                Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "SpeedDown" && !TakenBoost)
        {
                Debug.Log("poweruptaken3");
                Invoke("IsSlowedDown", 0);
                Destroy(other.gameObject);
        }

    }
    private void IsSpeededUp()
    {
        pm.maxSpeed = pm.maxSpeed * SpeedUpSpeed;
        gc.gravitySpeed = gc.gravitySpeed * SpeedUpGravitySpeed;
        Invoke("IsNormal", 10);
        TakenBoost = true;
        
    }
    private void IsSlowedDown()
    {
        pm.maxSpeed = pm.maxSpeed * SpeedDownSpeed;
        gc.gravitySpeed = gc.gravitySpeed * SpeedDownGravitySpeed;
        Invoke("IsNormal", 10);
        TakenBoost = true;
    }
    private void IsNormal()
    {
        pm.maxSpeed = 4f;
        gc.gravitySpeed = 7f;
        TakenBoost = false;
    }

    
}
