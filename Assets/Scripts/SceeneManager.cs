using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceeneManager : MonoBehaviour
{
    private static int CurrentMap = 0;

    private static readonly List<string> Maps = new List<string>()
    {
        "maintrack",
        "luigi's circuit",
        "SNES Mario Circuit 3",
        "TLOZ-temple"
    };


    [SerializeField]
    KeyCode PrevMap;

    [SerializeField]
    KeyCode NextMap;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Load Manager: {CurrentMap}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PrevMap))
            {
                Debug.Log($"  Scene: Minus0 '{CurrentMap}' > {Maps[CurrentMap]}");

                CurrentMap--;
                if (CurrentMap < 0) CurrentMap = Maps.Count - 1;
                SceneManager.LoadScene(sceneName: Maps[CurrentMap]);

                Debug.Log($"  Scene: Minus1 '{CurrentMap}' > {Maps[CurrentMap]}");
            }
            else if (Input.GetKeyDown(NextMap))
            {
                Debug.Log($"  Scene: Plus0 '{CurrentMap}' > {Maps[CurrentMap]}");

                CurrentMap++;
                if (CurrentMap >= Maps.Count) CurrentMap = 0;
                SceneManager.LoadScene(sceneName: Maps[CurrentMap]);

                Debug.Log($"  Scene: Plus1 '{CurrentMap}' > {Maps[CurrentMap]}");
            }
            
        
    }
}
