using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragChanger : MonoBehaviour
{
    public float Default; // change in all Carcontrols1-4 (Defult + DragChanged)
    public float DragChanged;
    public Rigidbody TheRB1;
    public Rigidbody TheRB2;
    public Rigidbody TheRB3;
    public Rigidbody TheRB4;
    void OnTriggerStay(Collider other) //Enter
    {
        if (other.tag == "Player1")
        {
            TheRB1.drag = DragChanged;
        }
        if (other.tag == "Player2")
        {
            TheRB2.drag = DragChanged;
        }
        if (other.tag == "Player3")
        {
            TheRB3.drag = DragChanged;
        }
        if (other.tag == "Player4")
        {
            TheRB4.drag = DragChanged;
        }


    }
    void OnTriggerExit(Collider other) //Enter
    {
        if (other.tag == "Player1")
        {
            TheRB1.drag = Default;
        }
        if (other.tag == "Player2")
        {
            TheRB2.drag = Default;
        }
        if (other.tag == "Player3")
        {
            TheRB3.drag = Default;
        }
        if (other.tag == "Player4")
        {
            TheRB4.drag = Default;
        }
    }
  
}
