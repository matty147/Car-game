using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTriger3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameStatus.registerCheckpoint(other.tag, 3);
    }
}
