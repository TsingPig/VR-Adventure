using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butest : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(0, 3, 0);
    }
}
