using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fluteSystem : MonoBehaviour
{
    public AudioSource audioSource;

    public float maxVolume;
    public float attackTime;
    public float releaseTime;

    public KeyCode keyToPlay = KeyCode.A;


    public enum ASRState { inactive = 0, attack, sustain, release }
    public ASRState asrState;

    public GameObject musicNote;

    // Start is called before the first frame update
    void Start()
    {
        asrState = ASRState.inactive;
        audioSource.volume = 0f;
        musicNote.SetActive(false);
}

    // Update is called once per frame
    void Update()
    {
        maxVolume = fluteControl.Globals.FmaxVolume;
        attackTime = fluteControl.Globals.FattackTime;
        releaseTime = fluteControl.Globals.FreleaseTime;
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
            switch (asrState)
            {
                case ASRState.inactive:
                    asrState = ASRState.attack;
                    break;
                case ASRState.attack:
                    if (audioSource.volume < maxVolume)
                    {
                        audioSource.volume += (Time.deltaTime / attackTime) * maxVolume;
                    }

                    else if (audioSource.volume >= maxVolume)
                    {
                        audioSource.volume = maxVolume;
                        asrState = ASRState.sustain;
                    }
                    break;
                case ASRState.sustain:
                    break;
                case ASRState.release:
                    asrState = ASRState.attack;
                    break;
            }
        }

        else
        {
            //musicNote.SetActive(false);
            switch (asrState)
            {
                case ASRState.inactive:
                    break;
                case ASRState.attack:
                    asrState = ASRState.release;
                    break;
                case ASRState.sustain:
                    asrState = ASRState.release;
                    break;
                case ASRState.release:

                    if (audioSource.volume > 0f)
                    {
                        audioSource.volume -= (Time.deltaTime / releaseTime) * maxVolume;
                    }
                    else
                    {
                        audioSource.volume = 0f;
                        asrState = ASRState.inactive;
                    }
                    break;
            }
        }

    }
}
