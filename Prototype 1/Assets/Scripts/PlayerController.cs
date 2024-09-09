using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

    
{
    private float speed = 20f;
    private float turnSpeed = 30f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle forward
        //move it along the z axis
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //moves 20 meters a second. Time.deltatime converts fps rate to per second rate
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // rotation happens in Y, and Y-up.
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime *horizontalInput);

    }
}
