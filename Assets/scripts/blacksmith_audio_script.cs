using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blacksmith_audio_script : MonoBehaviour
{
    AudioSource audio_source;

    // Start is called before the first frame update
    void Start()
    {
        audio_source = GetComponent<AudioSource>();
    }

    public void play_sound()
    {
        audio_source.Play();
    }

    void OnMouseDown()
    {
        audio_source.mute = true;
    }
}