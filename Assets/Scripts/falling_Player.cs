using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_Player : MonoBehaviour
{
    Rigidbody Origin_Rigidbody;


    public void Start()
    {
        Origin_Rigidbody = GetComponent<Rigidbody>();
        Origin_Rigidbody.constraints = RigidbodyConstraints.None;
    }
    public void unfreeze()
    {
        Origin_Rigidbody.constraints = RigidbodyConstraints.None;
    }
}
