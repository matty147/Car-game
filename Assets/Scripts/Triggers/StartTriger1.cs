using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTriger1 : MonoBehaviour
{
    private static float startp1, startp2, startp3, startp4;

    void Start()
    {
        startp1 = -1f;
        startp2 = -1f;
        startp3 = -1f;
        startp4 = -1f;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player1")
        {
            startp1 = 1;
            Debug.Log("c1P1");
        }
        if (other.tag == "Player2")
        {
            startp2 = 1;
            Debug.Log("c1P2");
        }
        if (other.tag == "Player3")
        {
            startp3 = 1;
            Debug.Log("c1P3");
        }
        if (other.tag == "Player4")
        {
            startp4 = 1;
            Debug.Log("c1P4");
        }
    }
}
