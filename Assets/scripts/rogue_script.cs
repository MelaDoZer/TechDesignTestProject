using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rogue_script : MonoBehaviour
{
    AudioSource audio_source;
    public GameObject object_to_activate;

    // Start is called before the first frame update
    void Start()
    {
        audio_source = GetComponent<AudioSource>();
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    void OnMouseDown()
    {
        object_to_activate.SetActive(true);
        audio_source.Play();
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
