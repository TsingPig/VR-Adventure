using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_controll : MonoBehaviour
{
    public Collider sphere;
    public AudioSource music;



    // Start is called before the first frame update
    void Start()
    {
        music.Play(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        music.Stop();
    }
   
}
