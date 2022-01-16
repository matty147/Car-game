using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontrols4 : MonoBehaviour
{
     public Rigidbody theRB;

    public float forwardaccel = 8f , reverseAccel = 4f, macSpeed = 50f , turnStrength = 180 , gravityForce = 10f, dragOnGround =3f;

    private float speedInput, turnInput;

    private bool grounded;

    public LayerMask whatIsGround;
    public float groundRayLength = .5f;
    public Transform groundRayPoint;
    public float defultRotation = 0;

    public Transform leftFrontWheel, rightFrontWheel;
    public float maxWheelTurn = 25f; 

    // Start is called before the first frame update
    void Start()
    {
        theRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        speedInput = 0f;
        if (Input.GetAxis("Vertical4") > 0)
        {
            speedInput = Input.GetAxis("Vertical4") * forwardaccel * 1000f;
        }
        
        else if (Input.GetAxis("Vertical4") < 0)
        {
            speedInput = Input.GetAxis("Vertical4") * reverseAccel * 1000f;
        }

        turnInput = Input.GetAxis("Horizontal4");

       // if (grounded)
        //{
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime/* * Input.GetAxis("Vertical")*/, 0f));
       // }       
    transform.position = theRB.transform.position;
    
        leftFrontWheel.localRotation = Quaternion.Euler(leftFrontWheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn) - 180, leftFrontWheel.localRotation.eulerAngles.z);
        rightFrontWheel.localRotation = Quaternion.Euler(rightFrontWheel.localRotation.eulerAngles.x, turnInput * maxWheelTurn, rightFrontWheel.localRotation.eulerAngles.z);
    }

    

    private void FixedUpdate()
    {
        grounded = false;
        RaycastHit hit;

        if  (Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundRayLength, whatIsGround))
        {
            grounded = true;

            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
        }
       
        if (grounded)
        {
            theRB.drag = dragOnGround;
            if (Mathf.Abs(speedInput) > 0)
            {
                theRB.AddForce(transform.forward * speedInput);
            }
        } 
        else
        {
            theRB.drag = 0.1f;
            theRB.AddForce(Vector3.up * -gravityForce * 100f);
        }
    }
}
