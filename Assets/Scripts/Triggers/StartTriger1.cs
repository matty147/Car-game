using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTriger1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameStatus.registerCheckpoint(other.tag, 1);
    }
}
