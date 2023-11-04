using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

// Define the hand left & right
public enum HandType
{
    Left,
    Right
}
public class XRHandController : MonoBehaviour
{
    // Variable for deciding the left and right hands
    public HandType handType;
    // public variable to control speed of the thumbs
    public float thumbMoveSpeed = 0.1f;
    private Animator animator;
    private InputDevice inputDevice;

// variables for the index, thumb and three finger values
    private float indexValue;
    private float thumbValue;
    private float threeFingerValue;

    // Start is called before the first frame update
    void Start()
    {
        // getting animator component and input device
        animator = GetComponent<Animator>();
        inputDevice = GetInputDevice();
    }

    // Update is called once per frame
    void Update()
    {
        // calling the animate hand function to animate the hand
        AnimateHand();
    }
// function to get the input device
    InputDevice GetInputDevice()
    {
        // defining the controller characteristics i.e held in hand and controller
       InputDeviceCharacteristics controllerCharacteristics = InputDeviceCharacteristics.HeldInHand | InputDeviceCharacteristics.Controller;

// if else statement to decide the hand type, so if the hand type is left then the controller characteristics will be left else it will be right
       if (handType == HandType.Left)
       {
           controllerCharacteristics |= InputDeviceCharacteristics.Left;
       }
       else
       {
           controllerCharacteristics |= InputDeviceCharacteristics.Right;
       }
       // creating a list to keep the input devices and getting the devices with the controller characteristics
       List<InputDevice> inputDevices = new List<InputDevice>();
       InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, inputDevices);

// then returning the input devices found in the list
       return inputDevices[0];
    }
    // function to animate the hand
    void AnimateHand()
    {
        // getting the values of the index, thumb and three finger values
        inputDevice.TryGetFeatureValue(CommonUsages.trigger, out indexValue);
        inputDevice.TryGetFeatureValue(CommonUsages.grip, out threeFingerValue);

//getting the bool values of the secondary and primary touch
        inputDevice.TryGetFeatureValue(CommonUsages.primaryTouch, out bool primaryTouched);
        inputDevice.TryGetFeatureValue(CommonUsages.secondaryTouch, out bool secondaryTouched);

// if else statement to decide the thumb value and as a result the speed, if the primary or secondary touch is true then the thumb value will increase else it will decrease
        if (primaryTouched || secondaryTouched)
        {
            thumbValue += thumbMoveSpeed;
        }
        else
        {
            thumbValue -= thumbMoveSpeed;
        }
// the thumb value is clamped between 0 and 1
        thumbValue = Mathf.Clamp(thumbValue, 0, 1);
        // setting the float values of the index, thumb and three finger values
            animator.SetFloat("Index", indexValue);
            animator.SetFloat("Thumb", thumbValue);
            animator.SetFloat("ThreeFinger", threeFingerValue);
        
    }
}
