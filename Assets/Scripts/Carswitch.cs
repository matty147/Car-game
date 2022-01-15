using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carswitch : MonoBehaviour
{
    private int ActivePlayers = 1;

   // [SerializeField]
   // KeyCode AllOff;

    [SerializeField]
    KeyCode Plus;

    [SerializeField]
    KeyCode Minus;


    void UpdateActivePlayers()
    {
        switch (ActivePlayers)
        {
            case 1:
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true;
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = false;
                GameObject.Find("Cam1").GetComponent<Camera>().rect = new Rect(0f, 0f, 1f, 1f);
                GameObject.Find("Cam2").GetComponent<Camera>().rect = new Rect(1f, 1f, 0f, 0f);
                break;
            case 2:
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true;
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = true;
                GameObject.Find("Cam1").GetComponent<Camera>().rect = new Rect(0f, 0f, 1f, 0.5f);
                GameObject.Find("Cam2").GetComponent<Camera>().rect = new Rect(0f, 0.5f, 1f, 0.5f);
                break;
            default:
                Debug.LogError($"Wrong number of players {ActivePlayers}.");
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ActivePlayers = 1;
        UpdateActivePlayers();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Plus))
        {
            if (ActivePlayers < 2)
            {
                ActivePlayers++;
                UpdateActivePlayers();
            }
 
        }
        if (Input.GetKey(Minus))
        {
            if (ActivePlayers > 1)
            {
                ActivePlayers--;
                UpdateActivePlayers();
            }
        }
    }
}
