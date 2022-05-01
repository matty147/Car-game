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
    private void FixedUpdate()
    {
       if (MainMenu.NumberOfPlayers == 1)
        {
            LapCounter4.text = Checkpoints.PlayerLap[0].ToString("0");
        }
        if (MainMenu.NumberOfPlayers == 2)
        {
            LapCounter1.text = Checkpoints.PlayerLap[0].ToString("0");
            LapCounter4.text = Checkpoints.PlayerLap[1].ToString("0");
        }
        if (MainMenu.NumberOfPlayers == 3)
        {
            LapCounter2.text = Checkpoints.PlayerLap[0].ToString("0");
            LapCounter1.text = Checkpoints.PlayerLap[1].ToString("0");
            LapCounter3.text = Checkpoints.PlayerLap[2].ToString("0");
        }
        if (MainMenu.NumberOfPlayers == 4)
        {
            LapCounter2.text = Checkpoints.PlayerLap[0].ToString("0");
            LapCounter1.text = Checkpoints.PlayerLap[1].ToString("0");
            LapCounter3.text = Checkpoints.PlayerLap[2].ToString("0");
            LapCounter4.text = Checkpoints.PlayerLap[3].ToString("0");
        }

    }
}
