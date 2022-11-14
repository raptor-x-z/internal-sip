using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public List<GameObject> pillarGameObjects = new List<GameObject>();
    public List<Material> objectMaterials = new List<Material>();

    // Start is called before the first frame update
    void Start()
    {

        //For every Pillar GameObject in the List
        for (int i = 0; i < pillarGameObjects.Count; i++ )
        {
            //Generate a random number, between 0 to the number of objects inside the Material's List
            int randomInt = Random.Range(0, objectMaterials.Count);

            //Assigned the Material based on the Index value of the Number generated
            pillarGameObjects[i].GetComponent<Renderer>().material = objectMaterials[randomInt];

            //Remove the assigned material from the List
            objectMaterials.RemoveAt(randomInt);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
