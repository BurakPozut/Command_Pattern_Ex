using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCommand : ICommand
{
    Lightbulb _lightbulb;
    Color _previousColor;
    public ChangeColorCommand(Lightbulb lightbulb)
    {
        _lightbulb = lightbulb;
        _previousColor = lightbulb.GetComponent<Renderer>().material.color;
    }

    public void Execute()
    {
        _lightbulb.SetRandomLightColor();
    }

    public void Undo()
    {
        _lightbulb.SetLightColor(_previousColor);
    }
}
