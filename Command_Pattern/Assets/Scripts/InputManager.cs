using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Lightbulb Lightbulb;
    LightSwitch _lightSwitch;
    void Start() 
    {
        // Set Up Invoker
        ICommand turnOnCommand = new TogglePowerCommand(Lightbulb);
        _lightSwitch = new LightSwitch(turnOnCommand);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _lightSwitch.TogglePower();
        }
    }
}
