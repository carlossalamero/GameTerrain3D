using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    private AudioSource _audiosource;

    // Start is called before the first frame update
    void Awake()
    {
        
        _audiosource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Start()
    {
        _audiosource.Play();
    }

    public void StopBGM()
    {
        _audiosource.Stop();
    }
}
