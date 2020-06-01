using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject rechts_arm, links_arm, rechts_arm_zwart, links_arm_zwart;

    Vector2 rechts_armInitialPos, links_armInitialPos;

    public void Start()
    {
        rechts_armInitialPos = rechts_arm.transform.position;
        links_armInitialPos = links_arm.transform.position;
    }

    public void Dragrechts_arm()
    {
        rechts_arm.transform.position = Input.mousePosition;
    }

    public void Draglink_sarm()
    {
        links_arm.transform.position = Input.mousePosition;
    }

    public void Droprechts_arm()
    {
        float Distance = Vector3.Distance(rechts_arm.transform.position, rechts_arm_zwart.transform.position);
        if(Distance<50)
        {
            rechts_arm.transform.position = rechts_arm.transform.position;
        }
        else
        {
            rechts_arm.transform.position = rechts_armInitialPos;
        }
    }

    public void Droplinks_arm()
    {
        float Distance = Vector3.Distance(links_arm.transform.position, links_arm_zwart.transform.position);
        if (Distance < 50)
        {
            links_arm.transform.position = links_arm.transform.position;
        }
        else
        {
            links_arm.transform.position = links_armInitialPos;
        }
    }
}
