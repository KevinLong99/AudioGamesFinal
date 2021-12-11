using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class fluteControl : MonoBehaviour
{
    public AudioMixerSnapshot normal;
    public AudioMixerSnapshot reverb;
    public AudioMixerSnapshot sad;
    public AudioMixerSnapshot happy;
    public AudioMixerSnapshot annoyed;

    public GameObject FlutePlayer;
    public GameObject PianoPlayer;

    public float normalMaxVol = 1;
    public float normalAttackTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            normal.TransitionTo(0);
            Debug.Log("normal");
            //F
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            reverb.TransitionTo(0);
            Debug.Log("reverb");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            sad.TransitionTo(0);
            Debug.Log("sad");
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            happy.TransitionTo(0);
            Debug.Log("happy");
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            annoyed.TransitionTo(0);
            Debug.Log("annoy");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            FlutePlayer.SetActive(false) ;
            PianoPlayer.SetActive(true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            FlutePlayer.SetActive(true);
            PianoPlayer.SetActive(false);
        }
    }

    public static class Globals
    {
        public static float FmaxVolume;
        public static float FattackTime;
        public static float FreleaseTime;



    }
}


