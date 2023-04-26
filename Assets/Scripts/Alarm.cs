using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlaySound()
    {
        audioSource.Play();
    }

    public void StopSound()
    {
        audioSource.Stop();
    }

    public void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
