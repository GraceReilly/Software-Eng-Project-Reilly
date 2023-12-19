using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

// tutorial followed for the below code - https://www.youtube.com/watch?v=iSYfs6NXZck&t=11s&ab_channel=DanielStringer
// the public class is managing the puzzle piece
public class PuzzlePiece : MonoBehaviour
{
    // the serialize field is used to show the variable in the inspector and is used to link the puzzle manager
    [SerializeField] private PuzzleManager linkedPuzzleManager;
    // the serialize field is used to show the transform in the inspector and is used to link the correct puzzle piece
    [SerializeField] private Transform CorrectPuzzlePiece;
    // the private XR socket interactor is used to link the socket
    private XRSocketInteractor socket;

// the private awake method is used to get the component, the socket is linked to the XR socket interactor 
    private void Awake() => socket = GetComponent<XRSocketInteractor>();
    
    // the private on enable is used toq add the listener for the select entered and select exited
    // the object snapped is called when the object is snapped and the object removed is called when the object is removed
    private void OnEnable()
    {
        socket.selectEntered.AddListener(ObjectSnapped);
        socket.selectExited.AddListener(ObjectRemoved);
    }

// the private on disable is used to remove the listener for the select entered and select exited
    private void OnDisable()
    {
        socket.selectEntered.RemoveListener(ObjectSnapped);
        socket.selectExited.RemoveListener(ObjectRemoved);
    }

// the private void is used to check if the object is removed and if the snapped object name is equal to the correct puzzle piece name
    private void ObjectRemoved(SelectExitEventArgs arg0)
    {
        var snappedObjectName = arg0.interactableObject;
        // if the snapped object name is equal to the correct puzzle piece name then the completed puzzle task is called
        if(snappedObjectName.transform.name == CorrectPuzzlePiece.name)
        {
            linkedPuzzleManager.CompletedPuzzleTask();
        
        }
    }
// the private void is used to check if the object is snapped and if the snapped object name is equal to the correct puzzle piece name
    private void ObjectSnapped(SelectEnterEventArgs arg0)
    {

        var removedObjectName = arg0.interactableObject;
        // if the removed object name is equal to the correct puzzle piece name then the puzzle piece removed is called
        if(removedObjectName.transform.name == CorrectPuzzlePiece.name)
        {
            // the puzzle piece removed is called
            linkedPuzzleManager.PuzzlePieceRemoved();
        }

    }

}
