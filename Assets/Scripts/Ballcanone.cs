using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcanone : MonoBehaviour
{
    public GameObject ball;
    public Transform SpawnPoint;
    public Collider speedRange;
    


        //Start is called before the first frame update

        public void Update()
        {

         
        }
    // Update is called once per frame
    private void OnCollisionStay(Collision collision)
    {
        ball.GetComponent<Rigidbody>().velocity = SpawnPoint.position * 2;
    }
}


