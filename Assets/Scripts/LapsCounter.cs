using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapsCounter : MonoBehaviour
{
    [SerializeField]
    GameObject Counter1;

    [SerializeField]
    GameObject Counter2;

    [SerializeField]
    GameObject Counter3;

    [SerializeField]
    GameObject Counter4;

    // Start is called before the first frame update
    void Start()
    {
        Counter1.SetActive(false);
        Counter2.SetActive(false);
        Counter3.SetActive(false);
        Counter4.SetActive(true);
    }

}
