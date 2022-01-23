using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTriger2 : MonoBehaviour
{
    private static float trigger1p1, trigger1p2, trigger1p3, trigger1p4;


    void Start()
    {
        trigger1p4 = -1f;
        trigger1p2 = -1f;
        trigger1p3 = -1f;
        trigger1p4 = -1f;
      
    }
    private void Update()
    {
        //var startp1 = GameObject.Find("Start").GetComponent<StartTriger1>();
        //Debug.Log("startp1");
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player1")
        {
            //if (startp1)
            //{
                trigger1p1 = 1;
                Debug.Log("c2P1");
           // }
            if (other.tag == "Player2")
            {
                trigger1p2 = 1;
                Debug.Log("c2P2");
            }
            if (other.tag == "Player3")
            {
                trigger1p3 = 1;
                Debug.Log("c2P3");
            }
            if (other.tag == "Player4")
            {
                trigger1p4 = 1;
                Debug.Log("c2P4");
            }
        }
    }
}
