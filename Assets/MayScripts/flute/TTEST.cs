using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTEST : MonoBehaviour
{
    public bool pianoIsOn = false;
    public AudioSource mySource;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;
    public float releaseTime = 1;
    public float maxVolume = 1;
    public bool usePiano = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            mySource.clip = clip1;
            mySource.volume = maxVolume;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            mySource.clip = clip2;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            mySource.clip = clip3;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            mySource.clip = clip4;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            mySource.clip = clip5;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            mySource.clip = clip6;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            mySource.clip = clip7;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            mySource.clip = clip8;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            if (mySource.volume > 0f)
            {
                mySource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                mySource.Stop();
            }
        }
    }
}
