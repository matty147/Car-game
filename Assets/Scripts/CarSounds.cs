using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CarSounds : MonoBehaviour
{
    public AudioMixer audioMixer;

    public AudioSource audioSource;
    public AudioClip StartCar;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown("2"))
        {
            Debug.Log("2");
            //audioSource.PlayOneShot(StartCar, 1); Not good :(
        }
    }
}
