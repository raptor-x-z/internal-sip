using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //this.transform.position.x += 0.1f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
    }
}
