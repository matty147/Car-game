using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SettingsMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip Beep;
    private float volume = 0;
    public AudioMixer audioMixer;
    public void SetVolume (float Volume)
    {
        Debug.Log(Volume);
        audioMixer.SetFloat("MainVolume", Volume);
        //audioSource.PlayOneShot(Beep, Volume);
    }
}
