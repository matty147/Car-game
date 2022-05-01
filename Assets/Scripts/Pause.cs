using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    KeyCode pause;

    [SerializeField]
    GameObject PauseTxt, Timer, Counter1, Counter2, Counter3, Counter4;

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

        //detect how many player are playing(can do it with a private void thing) and then switch on/off counters when paused.
        if(StopTime == 1)
        {
            Time.timeScale = 0;
            PauseTxt.SetActive(true);
           // Timer.SetActive(false);
         /*   Counter1.SetActive(false);
            Counter2.SetActive(false);
            Counter3.SetActive(false);
            Counter4.SetActive(false);*/
        }
        else
        {
            Time.timeScale = time;
            PauseTxt.SetActive(false);
            //Timer.SetActive(true);
          /*  Counter1.SetActive(true);
            Counter2.SetActive(true);
            Counter3.SetActive(true);
            Counter4.SetActive(true);*/
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