using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    
    Rigidbody rb;
    public float velocity = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        rb.AddForce(new Vector3(horizontal, 0,vertical) * velocity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Exit"))
        {
            Debug.Log("You win! Congratulation!");
        }
            
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pincho"))
        {
            transform.position = new Vector3(17,0,16);
        }
        if (collision.gameObject.CompareTag ("Enemy")) 
        {

            transform.position = new Vector3(17, 0, 16);

        }
    }
}
