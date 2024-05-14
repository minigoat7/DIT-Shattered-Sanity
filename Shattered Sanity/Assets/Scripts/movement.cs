using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    CharacterController controller;
    
    bool IsGrounded = true;
    public float jumpForce = 5000f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.W)) 
    {
        transform.Translate(Vector3.forward * 20 * Time.deltaTime);
    }   
    if (Input.GetKey(KeyCode.S)) 
    {
        transform.Translate(Vector3.back * 20 * Time.deltaTime);
    }   
     if (Input.GetKey(KeyCode.D)) 
    {
        transform.Translate(Vector3.right * 20 * Time.deltaTime);
    }   
    if (Input.GetKey(KeyCode.A)) 
    {
        transform.Translate(Vector3.left * 20 * Time.deltaTime);
    }   
    //if (Input.GetKeyDown(KeyCode.Space))
   // {
   //     rb.AddForce(Vector3.up * 20000 * Time.deltaTime);
  //  }

    if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
    {
        rb.AddForce(Vector3.up * jumpForce);
    }
    }
void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        IsGrounded = true;
    }
}


void OnCollisionExit(Collision collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        IsGrounded = false;
    }
}
}
