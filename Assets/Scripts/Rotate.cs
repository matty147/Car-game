using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeedy = 10f, rotateSpeedx = 10f, rotateSpeedz = 10f, mod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeedx * Time.deltaTime * mod, rotateSpeedy * Time.deltaTime * mod, rotateSpeedz * Time.deltaTime * mod);
    }
}
