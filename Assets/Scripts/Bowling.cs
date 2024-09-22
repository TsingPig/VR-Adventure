using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowling : MonoBehaviour
{
public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(-0.1f, -0.18f, 0.37f);
        //startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 1f) {
            transform.position = startPosition;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
