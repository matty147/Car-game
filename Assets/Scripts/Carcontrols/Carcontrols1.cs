using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontrols1 : MonoBehaviour
{
     public Rigidbody theRB;

    public float forwardaccel = 8f , reverseAccel = 4f, macSpeed = 50f , turnStrength = 180 , gravityForce = 10f, dragOnGround =3f;

    public float Default; // change in all DragChanger(Defult + DragChanged)
    public float DragChanged;

    private float speedInput, turnInput;

    private bool grounded;

    public LayerMask whatIsGround;
    public float groundRayLength = .5f;
    public Transform groundRayPoint;
    public float TurnMod;
    private float TurnDef;

    public Transform leftFrontWheel, rightFrontWheel;
    public float maxWheelTurn = 25f;
   
    // Start is called before the first frame update
    void Start()
    {
        theRB.transform.parent = null;
        TurnDef = turnStrength;
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
            if (theRB.drag == DragChanged)
            {
                dragOnGround = DragChanged;
                turnStrength = TurnMod;
            }
            else
            {
                dragOnGround = Default;
                turnStrength = TurnDef;
            }

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
