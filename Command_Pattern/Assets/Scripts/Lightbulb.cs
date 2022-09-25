using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbulb : MonoBehaviour
{
    bool isPowerOn = false;
    public void TogglePower()
    {
        if(!isPowerOn)
        {
            GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            isPowerOn = true;
        }
        else
        {
            GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            isPowerOn = false;
        }
    }
}
