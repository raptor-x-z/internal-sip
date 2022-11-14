using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillarTest : MonoBehaviour
{

    public GameObject positionLock;

    public static Vector3 staticLockVector3Pos = new Vector3();
    
    // Start is called before the first frame update
    void Start()
    {
        staticLockVector3Pos = positionLock.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Renderer>().material.name == this.gameObject.GetComponent<Renderer>().material.name)
        {
            Debug.Log("Object is correctly matched!");

            cubeTestBehav.lockPosition = true;
            cubeTestBehav.lockedPosition = this.transform.position;
        }

        else
        {
            //Debug.Log("Object is not correctly matched!");
            cubeTestBehav.lockPosition = false;
        }
    }
}
