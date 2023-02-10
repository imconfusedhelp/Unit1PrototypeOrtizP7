using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // speed variable for player
    private float speed = 20f;
    // variable for turn speed
    private float turnSpeed = 100f;
    // used to get horizontal axis
    private float horizontalInput;
    // used to get vertical axis
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get axis for left and right
        horizontalInput = Input.GetAxis("Horizontal");
        // get axis for forward and backward
        forwardInput = Input.GetAxis("Vertical");

        // this moves the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // let player (tank) turn left and right with 'a' and 'd'
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}

