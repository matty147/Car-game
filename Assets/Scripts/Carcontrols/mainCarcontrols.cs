using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCarControls : MonoBehaviour
{
    public int playerNmb;
    //public static int NumberOfPlayers { get; private set; } = 1;
    public Rigidbody theRB;

    public float forwardAccel = 8f, reverseAccel = 4f, maxSpeed = 50f, turnStrength = 180f, gravityForce = 10f, dragOnGround = 3f;

    //Player nmb for the controls

    public float defaultDrag; // change in all DragChanger(Defult + DragChanged)
    public float dragChanged;

    private float speedInput;
    public float boost;
    public float BoostDecrease = 1;

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
        //GameObject.Find("SceneManager").GetComponent<StartCars>();
    }

    void Awake()
    {
        Debug.Log($"{playerNmb}");
        //make all a = all preset var;
        //macSpeed = macSpeed;        
    }
    // Update is called once per frame
    void Update()
    {
        var vertical = Input.GetAxis($"Vertical{playerNmb}");
        var turnInput = Input.GetAxis($"Horizontal{playerNmb}");
        /*
        if (PlayerNmb == 2)
        {S
            Debug.Log($"{PlayerNmb},{vertical},{turnInput}");
        }
        */
        speedInput = 0f;
        if (vertical > 0)
        {
            speedInput = vertical * forwardAccel * 1000f;
        }   
        else if (vertical < 0)
        {
            speedInput = vertical * reverseAccel * 1000f;
        }

       // if (grounded)
        //{
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime/* * Input.GetAxis("Vertical1")*/, 0f));
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
            if (theRB.drag == dragChanged)
            {
                dragOnGround = dragChanged;
                turnStrength = TurnMod;
            }
            else
            {
                dragOnGround = defaultDrag;
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
                theRB.AddForce(transform.forward * speedInput * boost * StartCars.CarGo);
            }
        } 
        else
        {
            theRB.drag = 0.1f;
            theRB.AddForce(Vector3.up * -gravityForce * 100f);
        }

        if (boost > 1.000f)
        {
            boost -= BoostDecrease * 0.05f;
            //Debug.Log($"Boost: {boost}");
        } else
        {
            boost = 1;
        }


    }
}
