using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // Tilt the plane up/down based on up/down arrow keys
    }   Transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime)
}
