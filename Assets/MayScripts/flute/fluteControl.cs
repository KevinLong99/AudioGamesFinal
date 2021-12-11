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
        }
    }
}
