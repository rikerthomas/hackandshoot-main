using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestSounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSource.isPlaying == false)
        {
            audioSource.Play();
        }

    }
}
