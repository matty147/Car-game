using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapsCounter : MonoBehaviour
{
    public static int Finished1, Finished2, Finished3, Finished4;
    public int MaxLapCount, WaitForXSec;

    [SerializeField]
    GameObject Counter1, Counter2, Counter3, Counter4, EndGame;

    public Text LapCounter1, LapCounter2, LapCounter3, LapCounter4;

    // Start is called before the first frame update
    void Start()
    {
     if (MainMenu.NumberOfPlayers == 1)
        {
            Counter1.SetActive(false);//right up
            Counter2.SetActive(false);//left up
            Counter3.SetActive(false);//left down
            Counter4.SetActive(true); //right down
        }
     if (MainMenu.NumberOfPlayers == 2)
        {
            Counter1.SetActive(true);//right up
            Counter2.SetActive(false);//left up
            Counter3.SetActive(false);//left down
            Counter4.SetActive(true); //right down
        }
     if (MainMenu.NumberOfPlayers == 3)
        {
            Counter1.SetActive(true);//right up
            Counter2.SetActive(true);//left up
            Counter3.SetActive(true);//left down
            Counter4.SetActive(false); //right down
        }
     if (MainMenu.NumberOfPlayers == 4)
        {
            Counter1.SetActive(true);//right up
            Counter2.SetActive(true);//left up
            Counter3.SetActive(true);//left down
            Counter4.SetActive(true); //right down
        }
        Debug.Log($"{Checkpoints.PlayerLap[0]}:{Checkpoints.PlayerLap[1]}:{Checkpoints.PlayerLap[2]}:{Checkpoints.PlayerLap[3]}");
    }

    private void reportLap(Text counter, int playerIdx)
    {
        counter.text = (Checkpoints.PlayerLap[playerIdx] + 1).ToString("0");
    }
    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(WaitForXSec);
        SceneManager.LoadScene("Menu");
    }
    private void FixedUpdate()
    {
       if (MainMenu.NumberOfPlayers == 1)
        {
            reportLap(LapCounter4, 0);
            if (Finished1 >= 1)
            {
                Debug.Log("EndGame (1)");
                EndGame.SetActive(true);
                StartCoroutine(StartTimer());
            }
            //else EndGame.SetActive(false);
        }
        if (MainMenu.NumberOfPlayers == 2)
        {
            reportLap(LapCounter1, 0);
            reportLap(LapCounter4, 1);
            if (Finished1 + Finished2 >= 1)
            {
                Debug.Log("EndGame (2)");
                EndGame.SetActive(true);
                StartCoroutine(StartTimer());
            }
            //else EndGame.SetActive(false);
        }
        if (MainMenu.NumberOfPlayers == 3)
        {
            reportLap(LapCounter2, 0);
            reportLap(LapCounter1, 1);
            reportLap(LapCounter3, 2);
            if (Finished1 + Finished2 + Finished3 >= 2)
            {
                Debug.Log("EndGame (3)");
                EndGame.SetActive(true);
                StartCoroutine(StartTimer());
            }
           // else EndGame.SetActive(false);
        }
        if (MainMenu.NumberOfPlayers == 4)
        {
            reportLap(LapCounter2, 0);
            reportLap(LapCounter1, 1);
            reportLap(LapCounter3, 2);
            reportLap(LapCounter4, 3);
            if (Finished1 + Finished2 + Finished3 + Finished4 >= 3)
            {
                Debug.Log("EndGame (4)");
                EndGame.SetActive(true);
                StartCoroutine(StartTimer());
            }
            //else EndGame.SetActive(false);
        }

        if (Checkpoints.PlayerLap[0] >= MaxLapCount)
        {
            Finished1 = 1;
        }
        else Finished1 = 0;

        if (Checkpoints.PlayerLap[1] >= MaxLapCount)
        {
            Finished2 = 1;
        }
        else Finished2 = 0;
        if (Checkpoints.PlayerLap[2] >= MaxLapCount)
        {
            Finished3 = 1;
        }
        else Finished3 = 0;

        if (Checkpoints.PlayerLap[3] >= MaxLapCount)
        {
            Finished4 = 1;
        }
        else Finished4 = 0;

    }
}
