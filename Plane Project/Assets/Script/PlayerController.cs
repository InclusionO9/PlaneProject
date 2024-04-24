using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlX : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }   
}
