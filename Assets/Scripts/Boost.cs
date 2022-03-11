using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public float Default = 1; // change in all Carcontrols1-4 (Defult + Boost)
    public float pBoost = 1;

    private mainCarcontrols GetCarControls(Collider other)
    {
        return GameObject.Find(other.tag).GetComponent<mainCarcontrols>();
    }


    void OnTriggerEnter(Collider other)
    {
        GetCarControls(other).boost = pBoost;
    }

    void OnTriggerExit(Collider other) 
    {
        GetCarControls(other).boost = Default;
    }

}
