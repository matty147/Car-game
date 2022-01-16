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
                Debug.Log($"1");
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true;//on
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = false;//off
                GameObject.Find("Player3").GetComponent<Carcontrols3>().enabled = false;//off
                GameObject.Find("Player4").GetComponent<Carcontrols4>().enabled = false;//off
                GameObject.Find("Cam1").GetComponent<Camera>().rect = new Rect(0f, 0f, 1f, 1f);
                GameObject.Find("Cam2").GetComponent<Camera>().rect = new Rect(1f, 1f, 0f, 0f); 
                GameObject.Find("Cam3").GetComponent<Camera>().rect = new Rect(1f, 1f, 0f, 0f); 
                GameObject.Find("Cam4").GetComponent<Camera>().rect = new Rect(1f, 1f, 0f, 0f); 
                break;
            case 2:
                Debug.Log($"2");
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true; //on
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = true; //on
                GameObject.Find("Player3").GetComponent<Carcontrols3>().enabled = false; //off
                GameObject.Find("Player4").GetComponent<Carcontrols4>().enabled = false; //off
                GameObject.Find("Cam1").GetComponent<Camera>().rect = new Rect(0f, 0.5f, 1f, 0.5f);
                GameObject.Find("Cam2").GetComponent<Camera>().rect = new Rect(0f, 0f, 1f, 0.5f);
                GameObject.Find("Cam3").GetComponent<Camera>().rect = new Rect(1f, 1f, 0f, 0f);
                GameObject.Find("Cam4").GetComponent<Camera>().rect = new Rect(1f, 1f, 0f, 0f);
                break;
            case 3:
                Debug.Log($"3");
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true; //on
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = true; //on
                GameObject.Find("Player3").GetComponent<Carcontrols3>().enabled = true; //on
                GameObject.Find("Player4").GetComponent<Carcontrols4>().enabled = false; //off
                GameObject.Find("Cam1").GetComponent<Camera>().rect = new Rect(0f, 0.5f, 0.5f, 0.5f);
                GameObject.Find("Cam2").GetComponent<Camera>().rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
                GameObject.Find("Cam3").GetComponent<Camera>().rect = new Rect(0f, 0f, 0.5f, 0.5f);
                GameObject.Find("Cam4").GetComponent<Camera>().rect = new Rect(0.5f, 0f, 0.5f, 0.5f);
                break;
            case 4:
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true;//on
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = true;//on
                GameObject.Find("Player3").GetComponent<Carcontrols3>().enabled = true;//on
                GameObject.Find("Player4").GetComponent<Carcontrols4>().enabled = true;//on
                GameObject.Find("Cam1").GetComponent<Camera>().rect = new Rect(0f, 0.5f, 0.5f, 0.5f);
                GameObject.Find("Cam2").GetComponent<Camera>().rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
                GameObject.Find("Cam3").GetComponent<Camera>().rect = new Rect(0f, 0f, 0.5f, 0.5f);
                GameObject.Find("Cam4").GetComponent<Camera>().rect = new Rect(0.5f, 0f, 0.5f, 0.5f);
                Debug.Log($"4");
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
    void FixedUpdate()
    {
       
            if (Input.GetKeyUp(Plus))
            {
                if (ActivePlayers < 4)
                {
                    ActivePlayers++;
                    UpdateActivePlayers();
                    
                }

            }
            if (Input.GetKeyUp(Minus))
            {
                if (ActivePlayers > 1)
                {
                    ActivePlayers--;
                    UpdateActivePlayers();
                    
                }
            }
        
    }
}
