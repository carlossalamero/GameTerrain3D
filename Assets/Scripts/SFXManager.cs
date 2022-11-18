using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip danceSFX;
    // Start is called before the first frame update
    void Awake()
    {

        _audioSource = GetComponent<AudioSource>();

    }

     public void dance()
    {
       _audioSource.PlayOneShot(danceSFX);
    }
    public void StopBGM()
    {
        _audioSource.Stop();
    }
}
