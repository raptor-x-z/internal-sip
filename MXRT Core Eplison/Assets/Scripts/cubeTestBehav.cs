using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTestBehav : MonoBehaviour
{

    [HideInInspector]
    public static bool hoverEffectBool = false;
    public static bool lockPosition = false;
    public static Vector3 lockedPosition = new Vector3();

    Vector3 tempPosition = new Vector3();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    void FixedUpdate()
    {
        //Alters the object's rotation on the World's Axis at every Fixed Frame Update
        this.transform.Rotate(0.5f, 0.5f, 0, Space.World);

        if (lockPosition)
        {
            transform.position = new Vector3(lockedPosition.x, lockedPosition.y + 0.5f, lockedPosition.z);

            //StartCoroutine(hoveringEffectDelay());
        }
    }

    private void hoveringEffect()
    {
        //Makes the object float up and down using the Sin curve
        tempPosition = this.transform.position;
        tempPosition.y += Mathf.Sin(Time.fixedTime * Mathf.PI * 0.5f) * 0.005f;
        this.transform.position = new Vector3(this.transform.position.x, tempPosition.y, this.transform.position.z);

        //transform.position = new Vector3(pillarTest.staticLockVector3Pos.x, tempPosition.y, pillarTest.staticLockVector3Pos.z);
    }

    IEnumerator hoveringEffectDelay()
    {
        yield return new WaitForSeconds(1f);
        hoveringEffect();

    }
}
