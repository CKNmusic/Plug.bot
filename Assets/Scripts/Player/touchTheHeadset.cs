using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchTheHeadset : MonoBehaviour
{
    public bool songFilter = false;

    public AudioLowPassFilter lpf;
    public AudioHighPassFilter hpf;

    public GameObject headset;
    public AudioSource ambience;
    public GameObject Speakers;
    public GameObject sourceAudio;

    // Start is called before the first frame update
    void Start()
    {
        songFilter = false;
        lpf.enabled = false;
        hpf.enabled = false;
        headset.SetActive(false);
        ambience.enabled = false;
        Speakers.SetActive(true);
        sourceAudio.transform.position = Speakers.transform.position;

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (songFilter)
        {
            songFilter = false;
            lpf.enabled = false;
            hpf.enabled = false;
            headset.SetActive(false);
            ambience.enabled = false;
            Speakers.SetActive(true);
            sourceAudio.transform.position = Speakers.transform.position;
        }
        else
        {
            songFilter = true;
            lpf.enabled = true;
            hpf.enabled = true;

            headset.SetActive(true);
            ambience.enabled = true;
            Speakers.SetActive(false);
            sourceAudio.transform.position = headset.transform.position;
        }
    }
}
