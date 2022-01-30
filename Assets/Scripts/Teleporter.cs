using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public float x, y, z;
    public Rigidbody theRB1;
    public Rigidbody theRB2;
    public Rigidbody theRB3;
    public Rigidbody theRB4;
   
    void OnTriggerEnter(Collider other)
    {
            if (other.tag == "Player1")
                {
                    theRB1.transform.position = new Vector3(x, y, z);
                    Debug.Log("tp1");
                }
           if (other.tag == "Player2")
                {
                    theRB2.transform.position = new Vector3(x, y, z);
                    Debug.Log("tp2");
                }
            if (other.tag == "Player3")
                {
                    theRB3.transform.position = new Vector3(x, y, z);
                    Debug.Log("tp3");
                }
            if (other.tag == "Player4")
                {
                    theRB4.transform.position = new Vector3(x, y, z);
                    Debug.Log("tp4");
                }
        }
    }

    /* Set cusom x, y, z, rotatecion
 
                   var rotationVector = transform.rotation.eulerAngles;
                   rotationVector.x = 0;
                   rotationVector.z = 0;
                   rotationVector.y = 0;
                   transform.rotation = Quaternion.Euler(rotationVector);
    */
