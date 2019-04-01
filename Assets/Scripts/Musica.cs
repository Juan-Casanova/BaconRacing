using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    public AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void MusicBackGroundTrack1(AudioSource audioSource)
    {
        audioSource.Play();
        audioSource.loop = true;
    }

    public void SoundEffect(AudioSource audioSource)
    {
        audioSource.Play();
        audioSource.loop = false;

    }
}
