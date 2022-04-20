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
        Debug.Log($"{Checkpoints.PlayerLap}/4");
    }
}
