using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_cam : MonoBehaviour
{
    public Camera plane_cam;
    public Camera Player_cam;
    public GameObject plane;
    public GameObject player;
    public GameObject player2;
    public GameObject player_sound;
    public Rigidbody Origin_Rigidbody;
    public AudioListener Listener;
    public AudioListener Listener2;

    // Start is called before the first frame update
    void Start()
    {
        plane_cam.enabled = true;
        Player_cam.enabled = false;
        Origin_Rigidbody = player.
            GetComponent<Rigidbody>();
        Listener = player_sound.GetComponent<AudioListener>();
        Listener2 = player2.GetComponent<AudioListener>();
        Listener.enabled = false;
        Listener2.enabled = true;

    }

    void Update()
    {
        if(plane.transform.position.z > -40)
        {
            Listener.enabled = true;
            Listener2.enabled = false;
            plane_cam.enabled = false;
            Player_cam.enabled = true;
            Origin_Rigidbody.constraints = RigidbodyConstraints.None;
            Origin_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }
}
