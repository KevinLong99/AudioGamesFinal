using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
public class fluteControl : MonoBehaviour
{
    public AudioMixerSnapshot normal;
    public AudioMixerSnapshot reverb;
    public AudioMixerSnapshot sad;
    public AudioMixerSnapshot happy;
    public AudioMixerSnapshot annoyed;
    [SerializeField] TMP_Text mytext;

    public GameObject FlutePlayer;
    public GameObject player;


    public float normalMaxVol = 1;
    public float normalAttackTime = 1;
    public float normalReleaseTime = 1;
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
            Globals.FmaxVolume = normalMaxVol;
            Globals.FattackTime = normalAttackTime;
            Globals.FreleaseTime = 0.5f;
            mytext.text = "normal";
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            reverb.TransitionTo(0);
            Debug.Log("reverb");
            Globals.FmaxVolume = normalMaxVol;
            Globals.FattackTime = normalAttackTime;
            Globals.FreleaseTime = 2F;
            mytext.text = "reverb";
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            sad.TransitionTo(0);
            Debug.Log("sad");
            Globals.FmaxVolume = 0.6F;
            Globals.FattackTime = 4F;
            Globals.FreleaseTime = 2F;
            mytext.text = "sad";
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            happy.TransitionTo(0);
            Debug.Log("happy");
            Globals.FmaxVolume = 1F;
            Globals.FattackTime = 0.4F;
            Globals.FreleaseTime = 0.5F;
            mytext.text = "happy";
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            annoyed.TransitionTo(0);
            Debug.Log("annoy");
            mytext.text = "misarible";
            Globals.FmaxVolume = normalMaxVol;
            Globals.FattackTime = normalAttackTime;
            Globals.FreleaseTime = 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("change to piano");
            FlutePlayer.SetActive(true) ;
            player.GetComponent<TTEST>().usePiano = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            FlutePlayer.SetActive(false);
            player.GetComponent<TTEST>().usePiano = true;
        }
    }

    public static class Globals
    {
        public static float FmaxVolume =1;
        public static float FattackTime =1;
        public static float FreleaseTime =1;



    }
}


