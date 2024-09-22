using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball_treffer : MonoBehaviour
{
    public Collider sphere;
    public AudioSource music;




    private void OnTriggerExit(Collider other)
    {
        music.Play();
    }

}