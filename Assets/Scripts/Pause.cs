using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    KeyCode pause;

    [SerializeField]
    KeyCode menu;
    private float StopTime;

    public float time;

    private void Start()
    {
        StopTime = 0;

        if (time == 0)
            {
                time = 1;
            }

        if (time >= 100)
        {
            time = 1;
            Debug.Log("timer too large");
        }
    }

    private void Update()
    {


            if (Input.GetKeyDown(menu))
        {
            SceneManager.LoadScene("Menu");
        }

        if (Input.GetKeyDown(pause))
        {
            StopTime++ ;
        } 

        if (StopTime == 2)
        {
            StopTime = 0;
        }


        if(StopTime == 1)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = time;
        }

        //Debug.Log(StopTime);

        if (time == 0)
        {
            time = 1;
        }

        if (time >= 100)
        {
            time = 1;
            Debug.Log("timer too large");
        }
    }
}