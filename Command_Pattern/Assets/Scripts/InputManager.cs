using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Lightbulb _lightbulb;
    LightApp _lightApp;
    void Start() 
    {
        // Set Up Invoker
        _lightApp = new LightApp();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           ICommand togglePoweCommand = new TogglePowerCommand(_lightbulb);
           _lightApp.AddCommand(togglePoweCommand);
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            ICommand changeColorCommand = new ChangeColorCommand(_lightbulb);
            _lightApp.AddCommand(changeColorCommand);
        }
        else if(Input.GetKeyDown(KeyCode.Z))
        {
            _lightApp.UndoCommand();
        }
    }
}
