using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceeneManager : MonoBehaviour
{
    private float Clicktimer;
    public float Pause;

    [SerializeField]
    KeyCode PrevMap;

    [SerializeField]
    KeyCode NextMap;

    private int CurrentMap = 0;

    private readonly List<string> Maps = new List<string>()
    {
        "maintrack",
        "luigi's circuit"
    };

    // Start is called before the first frame update
    void Start()
    {
        Clicktimer = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        // SceneManager.LoadScene (sceneName:"Put the name of the scene here");
        if (Clicktimer == 0)
        {
            if (Input.GetKeyUp(PrevMap))
            {
                Debug.Log($"Scene: Minus0 '{CurrentMap}' > {Maps[CurrentMap]}");
                CurrentMap--;
                if (CurrentMap < 0) CurrentMap = Maps.Count - 1;
                SceneManager.LoadScene(sceneName: Maps[CurrentMap]);
                Debug.Log($"Scene: Minus1 '{CurrentMap}' > {Maps[CurrentMap]}");
                Clicktimer = Pause;
            }
            else if (Input.GetKeyUp(NextMap))
            {
                Debug.Log($"Scene: Plus0 '{CurrentMap}' > {Maps[CurrentMap]}");
                CurrentMap++;
                if (CurrentMap >= Maps.Count) CurrentMap = 0;
                SceneManager.LoadScene(sceneName: Maps[CurrentMap]);
                Debug.Log($"Scene: Plus1 '{CurrentMap}' > {Maps[CurrentMap]}");
                Clicktimer = Pause;
            }
        }else if (Clicktimer > 0)
        {
            Clicktimer--;
        }else
        {
            Debug.Log($"error");
        }
    }
}
