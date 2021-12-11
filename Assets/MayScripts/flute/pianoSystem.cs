using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianoSystem : MonoBehaviour
{
    public AudioSource pianoSource;

    public float maxVolume;
    public float attackTime;
    public float releaseTime;

    public KeyCode keyToPlay = KeyCode.A;

    public GameObject musicNote;

    // Start is called before the first frame update
    void Start()
    {
        musicNote.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            musicNote.SetActive(true);
        }
        else
        {
            musicNote.SetActive(false);
        }

        //if we press down "A" for the length of attack time, we reach max volume
        if (Input.GetKey(keyToPlay))
        {
            //musicNote.SetActive(true);
            pianoSource.Play();
        }

        if (Input.GetKeyUp(keyToPlay)){
            if (pianoSource.volume > 0f)
            {
                pianoSource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
            }
            else
            {
                pianoSource.Stop();
            }
        }

    }
}
