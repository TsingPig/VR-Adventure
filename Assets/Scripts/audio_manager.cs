using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_manager : MonoBehaviour
{
    public GameObject boden1;
    public GameObject boden2;
    public GameObject player;
    public AudioSource clip1;
    public AudioClip clip2;

    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
       
        clip1.Play();
       
        
    }
}