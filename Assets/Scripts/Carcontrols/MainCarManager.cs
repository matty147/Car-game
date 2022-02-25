using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCarManager : MonoBehaviour
{
    
    public float forwardaccel = 8f, reverseAccel = 4f, macSpeed = 50f, turnStrength = 180, gravityForce = 10f, dragOnGround = 3f;
    
    public float Default; // change in all DragChanger(Defult + DragChanged)
    public float DragChanged;

    private float speedInput;

    private bool grounded;

    public float groundRayLength = .5f;
    public float TurnMod;
    private float TurnDef;
    public float maxWheelTurn = 25f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
