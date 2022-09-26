using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePowerCommand : ICommand
{
    Lightbulb _lightbulb;
    public TogglePowerCommand(Lightbulb lightbulb)
    {
        _lightbulb = lightbulb;
    }
    public void Execute()
    {
        _lightbulb.TogglePower();
    }

    public void Undo()
    {
        _lightbulb.TogglePower();
    }
}
