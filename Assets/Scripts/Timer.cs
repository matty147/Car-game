using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    static public float time = 0.0f;
    public Text timer;
    void Update()
    {
        time += Time.deltaTime;
        if (time < 0)
        {
            
        }
        //Debug.Log(time);
        timer.text = time.ToString("0.0000");
    }
}
