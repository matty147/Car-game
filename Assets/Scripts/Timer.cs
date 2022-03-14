using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static public float time = 0.0f;
    public Text timer;

    private void Awake()
    {
        time = 0.0f;
    }
    void Update()
    {
        switch (StartCars.StartStatus)
        {
            case 3:
                timer.text = "";
                break;
            case 2:
                timer.text = "Ready";
                break;
            case 1:
                timer.text = "Set";
                break;
            default:
                if (time < 0.5)
                {
                    timer.text = "Go!";
                }
                else
                {
                    timer.text = time.ToString("0.000");
                } 
                time += Time.deltaTime;
                break;
        }
    }
}
