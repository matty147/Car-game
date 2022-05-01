using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private void FixedUpdate()
    {
       if (MainMenu.NumberOfPlayers == 1)
        {
            reportLap(LapCounter4, 0);
        }
        if (MainMenu.NumberOfPlayers == 2)
        {
            reportLap(LapCounter1, 0);
            reportLap(LapCounter4, 1);
        }
        if (MainMenu.NumberOfPlayers == 3)
        {
            reportLap(LapCounter2, 0);
            reportLap(LapCounter1, 1);
            reportLap(LapCounter3, 2);
        }
        if (MainMenu.NumberOfPlayers == 4)
        {
            reportLap(LapCounter2, 0);
            reportLap(LapCounter1, 1);
            reportLap(LapCounter3, 2);
            reportLap(LapCounter4, 3);
        }

    }
}
