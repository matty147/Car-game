using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontrols : MonoBehaviour
{
     public Rigidbody theRB;

    public float forwardaccel = 8f , reverseAccel = 4f, macSpeed = 50f , turnStrength = 180 , gravityForce = 10f ;

    private float speedInput, turnInput;

    private bool grounded;

    public LayerMask WhatisGround;
    public float groundRayLength = .5f;
    public Transform groundRayPoint;

    // Start is called before the first frame update
    void Start()
    {
        theRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        speedInput = 0f;
        if (Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardaccel * 1000f;
        }
        
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAccel * 1000f;
        }

        turnInput = Input.GetAxis("Horizontal");

        if (grounded = true)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime * Input.GetAxis("Vertical"), 0f));
        }       
            transform.position = theRB.transform.position; 
    }

    private void FixedUpdate()
    {
        grounded = false;
        RaycastHit hit;

        if(Physics.Raycast(groundRayPoint.position, transform.up, out hit, groundRayLength, WhatisGround))
        {
            grounded = true;
        }

        if (grounded = true)
        {
            if (Mathf.Abs(speedInput) > 0)
            {
                theRB.AddForce(transform.forward * speedInput);
            }
        } 
        else
        {
            theRB.AddForce(Vector3.up * -gravityForce * 100f);
        }
    }
}
