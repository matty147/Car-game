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

    private Camera getCam(int idx)
    {
        Debug.Log($"Camera: 'Cam{idx}'");
        return GameObject.Find($"Cam{idx}").GetComponent<Camera>();
    }

    enum Placement
    {
        Full,
        Top,
        Bottom,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
        Off
    }

    private Rect placementRect(Placement placement)
    {
        switch(placement)
        {
            case Placement.Full:
                return new Rect(0f, 0f, 1f, 1f);
            case Placement.Top:
                return new Rect(0f, 0.5f, 1f, 0.5f);
            case Placement.Bottom:
                return new Rect(0f, 0f, 1f, 0.5f);
            case Placement.TopLeft:
                return new Rect(0f, 0.5f, 0.5f, 0.5f);
            case Placement.TopRight:
                return new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            case Placement.BottomLeft:
                return new Rect(0f, 0f, 0.5f, 0.5f);
            case Placement.BottomRight:
                return new Rect(0.5f, 0f, 0.5f, 0.5f);
            case Placement.Off:
            default:
                return new Rect(0f, 0f, 0f, 0f);
        }
    }

    private void placeCamera(int idx, Placement placement)
    {
        getCam(idx).rect = placementRect(placement);
    }

    void UpdateActivePlayers()
    {
        switch (ActivePlayers)
        {
            case 1:
                Debug.Log($"1");
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true; //on
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = false; //off
                GameObject.Find("Player3").GetComponent<Carcontrols3>().enabled = false; //off
                GameObject.Find("Player4").GetComponent<Carcontrols4>().enabled = false; //off
                placeCamera(1, Placement.Full);
                placeCamera(2, Placement.Off);
                placeCamera(3, Placement.Off);
                placeCamera(4, Placement.Off);
                break;
            case 2:
                Debug.Log($"2");
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true; //on
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = true; //on
                GameObject.Find("Player3").GetComponent<Carcontrols3>().enabled = false; //off
                GameObject.Find("Player4").GetComponent<Carcontrols4>().enabled = false; //off
                placeCamera(1, Placement.Top);
                placeCamera(2, Placement.Bottom);
                placeCamera(3, Placement.Off);
                placeCamera(4, Placement.Off);
                break;
            case 3:
                Debug.Log($"3");
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true; //on
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = true; //on
                GameObject.Find("Player3").GetComponent<Carcontrols3>().enabled = true; //on
                GameObject.Find("Player4").GetComponent<Carcontrols4>().enabled = false; //off
                placeCamera(1, Placement.TopLeft);
                placeCamera(2, Placement.TopRight);
                placeCamera(3, Placement.BottomLeft);
                placeCamera(4, Placement.BottomRight);
                break;
            case 4:
                GameObject.Find("Player1").GetComponent<Carcontrols1>().enabled = true;//on
                GameObject.Find("Player2").GetComponent<Carcontrols2>().enabled = true;//on
                GameObject.Find("Player3").GetComponent<Carcontrols3>().enabled = true;//on
                GameObject.Find("Player4").GetComponent<Carcontrols4>().enabled = true;//on
                placeCamera(1, Placement.TopLeft);
                placeCamera(2, Placement.TopRight);
                placeCamera(3, Placement.BottomLeft);
                placeCamera(4, Placement.BottomRight);
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
