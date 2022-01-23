using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTriger3 : MonoBehaviour
{
    private static float trigger2p1, trigger2p2, trigger2p3, trigger2p4;


    void Start()
    {
        trigger2p4 = -1f;
        trigger2p2 = -1f;
        trigger2p3 = -1f;
        trigger2p4 = -1f;
      
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
                trigger2p1 = 1;
                Debug.Log("c3P1");
           // }
            if (other.tag == "Player2")
            {
                trigger2p2 = 1;
                Debug.Log("c3P2");
            }
            if (other.tag == "Player3")
            {
                trigger2p3 = 1;
                Debug.Log("c3P3");
            }
            if (other.tag == "Player4")
            {
                trigger2p4 = 1;
                Debug.Log("c3P4");
            }
        }
    }
}
