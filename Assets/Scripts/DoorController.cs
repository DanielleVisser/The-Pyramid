using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;

    // Update is called once per frame
    void Update()
    {
        
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 3); //Slowing down the opening of the gateway

        }
        if (Door.transform.position.y > 15f) //How far does the gate open
        {
            doorIsOpening = false;
        }

    }

    void OnMouseDown()
    {
        doorIsOpening = true;
    }
}
