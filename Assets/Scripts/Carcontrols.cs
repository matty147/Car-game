using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontrols : MonoBehaviour
{
     public Rigidbody theRB;

    public float forwardaccel = 8f , reverseAccel = 4f, macSpeed = 50f , turnStrength = 180;

    private float speedInput, turnInput;
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


        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime * Input.GetAxis("Vertical"), 0f));
            
            transform.position = theRB.transform.position; 
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(speedInput) > 0)
        {
            theRB.AddForce(transform.forward * speedInput);
        }
    }
}
