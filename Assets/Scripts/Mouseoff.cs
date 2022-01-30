using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mouseoff : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; // keep confined in the game window
        Cursor.lockState = CursorLockMode.Confined;   // keep confined to center of screen
        //Cursor.lockState = CursorLockMode.None;     // set to default default
        
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

