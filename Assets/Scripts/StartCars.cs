using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class StartCars : MonoBehaviour
{
    public int WaitForXSec;

    public AudioMixer audioMixer;

    public AudioSource audioSource;
    public AudioClip ReadySetGO;
    public float volume = 0;

    // Nothing = 3, Ready = 2, Set = 1, Go = 0
    public static int StartStatus;
    // Go => 1, otherwise => 0
    public static int CarGo;

    // Start is called before the first frame update
    void Start()
    {
        StartStatus = 3;
        CarGo = 0;
        StartCoroutine(StartTimer());
     }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartTimer()
    {
        StartStatus = 3;
        CarGo = 0;
        yield return new WaitForSeconds(WaitForXSec);
        audioSource.PlayOneShot(ReadySetGO, volume);
        StartStatus = 2;
        Debug.Log("Ready");
        yield return new WaitForSeconds(WaitForXSec);
        StartStatus = 1;
        Debug.Log("Set");
        yield return new WaitForSeconds(WaitForXSec);
        StartStatus = 0;
        CarGo = 1;
        Debug.Log("Go!");
    }

}
