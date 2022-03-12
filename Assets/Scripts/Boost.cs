using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public float Default = 1f; // change in all Carcontrols1-4 (Defult + Boost)
    public float StartBoost = 2f;

    private void Awake()
    {
    }
    private MainCarControls GetCarControls(Collider other)
    {
        return GameObject.Find(other.tag).GetComponent<MainCarControls>();
    }


    void OnTriggerStay(Collider other)
    {
        GetCarControls(other).boost = StartBoost;
    }


    void OnTriggerExit(Collider other) 
    {
        //GetCarControls(other).boost = Default;
    }
}
