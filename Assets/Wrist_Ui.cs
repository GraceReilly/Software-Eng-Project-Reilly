using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// I used this tutorial for the below code and to set up and create the UI for the wrist menu - https://www.youtube.com/watch?v=YISa0PvQTGk&ab_channel=FistFullofShrimp
// defining a class called wrist_ui
public class Wrist_Ui : MonoBehaviour
{
    // define a variable called inputActions of type InputActionAsset
    public InputActionAsset inputActions;

// define a variable called _wristUICanvas for the Canvas
    private Canvas _wristUICanvas;
// defining a variable called _menu of type InputAction, this will be used to keep track of the inoput action for the menu button
    private InputAction _menu;

// defining a function called Start, which is called before the first frame update
    private void Start()
    {
        // get the canvas component, and assign it to the _wristUICanvas variable
    _wristUICanvas = GetComponent<Canvas>();
    // getting the input action map called "XRI LeftHand", and then find the action called "Menu"
    _menu = inputActions.FindActionMap("XRI LeftHand").FindAction("Menu");
    _menu.Enable();
    // adding in the toggle menu function for when the menu button is pressed
    _menu.performed += ToggleMenu;
    }

    // ondestroy is called when the object is destroyed
   private void OnDestroy()
    {
        // getting rid of the toggle menu function for when the menu button is pressed
        _menu.performed -= ToggleMenu;
    }

    // creating a function for when the menu button is pressed, player will be able to see the menu
    public void ToggleMenu(InputAction.CallbackContext context)
    {
        // toggling the menu on and off, this will be hiding the menu from the player so they can go in between viewing the menu and not viewing the menu
        _wristUICanvas.enabled = !_wristUICanvas.enabled;
    }

}
