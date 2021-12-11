using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTEST : MonoBehaviour
{
    public AudioSource mySource;
    public AudioClip clip1;
    public AudioClip clip2;
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
        if (Input.GetKeyDown(KeyCode.P))
        {
            mySource.clip = clip1;
            mySource.volume = maxVolume;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.P))
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

        if (Input.GetKeyDown(KeyCode.O))
        {
            mySource.clip = clip2;
            mySource.Play();

        }
        if (Input.GetKeyUp(KeyCode.O))
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
