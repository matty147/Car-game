using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTriger2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameStatus.registerCheckpoint(other.tag, 2);
    }
}
