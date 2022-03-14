using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    public float speed = 10.0f;
    public float rotationSpeed = 720.0f;
    private Rigidbody playerRb; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput,0,
        verticalInput);
        movementDirection.Normalize();
        
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        
        if (movementDirection != Vector3.zero)
        {
           // transform.forward = movementDirection;
           Quaternion toRotation = Quaternion.LookRotation(movementDirection, 
           Vector3.up);

           transform.rotation = Quaternion.RotateTowards(transform.rotation, 
           toRotation, rotationSpeed * Time.deltaTime);
           
        }
        

    }

   

   
}
