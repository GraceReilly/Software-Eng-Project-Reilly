using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// the public class unserinterface ray activation is used to detect if the user is looking at the UI or not
public class UserInterfaceRayActivation : MonoBehaviour
{

    // the serialized field linkedhandposition is used to link the hand position to the UI
    [SerializeField] private Transform linkedhandposition;
    // the serialized field layerToHit is used to link the layer to hit to the UI, the layer mask is used to detect the UI
    [SerializeField] private LayerMask layerToHit;
    // the serialized field maxDistanceFromCanvas is used to link the max distance from canvas to the UI, it is a float value
    [SerializeField] private float maxDistanceFromCanvas;


// the header UI hover events is used to link the UI hover events to the UI
    [Header("UI Hover Events")]
    // the public unity event onUIHoverStart is used to link the UI hover start to the UI, the unity event is used to detect the UI hover start
    public UnityEvent onUIHoverStart;
    // the public unity event onUIHoverEnd is used to link the UI hover end to the UI, the unity event is used to detect the UI hover end
    public UnityEvent onUIHoverEnd;

// enum current interactor state is used to link the current interactor state to the UI
    enum CurrentInteractorState
    {
        // the default mode is used to link the default mode to the UI
        DefaultMode,
        UIMode
    }
    // the private current interactor state currentInteractorMode is used to link the current interactor mode to the UI
    private CurrentInteractorState currentInteractorMode;

// the private void awake is used to link the current interactor mode to the UI, the equal sign is used to assign the current interactor mode to the default mode
    private void Awake() => currentInteractorMode = CurrentInteractorState.DefaultMode;

// the private void fixed update is used to link the current interactor mode to the UI, the raycast hit is used to detect the raycast hit,
// the if statement is used to detect if the current interactor mode is not equal to the UI mode, the on UI hover start is used to detect the UI hover start,
// the current interactor mode is used to detect the current interactor mode, the else statement is used to detect if the current interactor mode is not equal 
//to the UI mode, the on UI hover end is used to detect the UI hover end, the current interactor mode is used to detect the current interactor mode
    private void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(linkedhandposition.position, linkedhandposition.forward, out hit, maxDistanceFromCanvas, layerToHit))
        {
            // not equal sign is used to detect if the current interactor mode is not equal to the UI mode
            if(currentInteractorMode != CurrentInteractorState.UIMode)
            {
                onUIHoverStart.Invoke();
                currentInteractorMode = CurrentInteractorState.UIMode;
            }
        }
        else
        {
            // not equal sign is used to detect if the current interactor mode is not equal to the UI mode
            if(currentInteractorMode != CurrentInteractorState.UIMode)
            {
                onUIHoverEnd.Invoke();
                currentInteractorMode = CurrentInteractorState.DefaultMode;
            }
        }
    }

}
