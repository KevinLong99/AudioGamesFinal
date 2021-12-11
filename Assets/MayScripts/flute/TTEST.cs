using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTEST : MonoBehaviour
{
    public AudioSource mySource;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;
    public float releaseTime = 0.5f;
    public float maxVolume = 1;
    public bool usePiano = false;
    bool stopplaying = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (usePiano)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                stopplaying = false;
                mySource.clip = clip1;
                mySource.volume = maxVolume;
                mySource.Play();

            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                stopplaying = true;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                stopplaying = false;
                mySource.volume = maxVolume;
                mySource.clip = clip2;
                mySource.Play();

            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                stopplaying = true;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                stopplaying = false;
                mySource.volume = maxVolume;
                mySource.clip = clip3;
                mySource.Play();

            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                stopplaying = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                stopplaying = false;
                mySource.volume = maxVolume;
                mySource.clip = clip4;
                mySource.Play();

            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                stopplaying = true;
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                stopplaying = false;
                mySource.volume = maxVolume;
                mySource.clip = clip5;
                mySource.Play();

            }
            if (Input.GetKeyUp(KeyCode.G))
            {
                stopplaying = true;
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                stopplaying = false;
                mySource.volume = maxVolume;
                mySource.clip = clip6;
                mySource.Play();

            }
            if (Input.GetKeyUp(KeyCode.H))
            {
                stopplaying = true;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                stopplaying = false;
                mySource.volume = maxVolume;
                mySource.clip = clip7;
                mySource.Play();

            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                stopplaying = true;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                stopplaying = false;
                mySource.volume = maxVolume;
                mySource.clip = clip8;
                mySource.Play();

            }
            if (Input.GetKeyUp(KeyCode.K))
            {
                stopplaying = true;
            }
        }

        if (stopplaying)
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
                stopplaying = false;
            }
            
        }
    }
}
