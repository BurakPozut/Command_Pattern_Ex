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

    public void SetLightColor(Color newColor)
    {
        Material material = GetComponent<Renderer>().material;
        material.color = newColor;
        material.SetColor("_EmissionColor", newColor);
    }

    public void SetRandomLightColor()
    {
        Color randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        Material material = GetComponent<Renderer>().material;
        material.color = randomColor;
        material.SetColor("_EmissionColor", randomColor);
    }
}
