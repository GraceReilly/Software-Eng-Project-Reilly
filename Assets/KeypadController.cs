using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;
using Unity.VisualScripting;
// tutorial followed for the below code - https://www.youtube.com/watch?v=hz_iVyYO-MY&ab_channel=DanielStringer
// the public class is managing the keypad
public class KeypadController : MonoBehaviour
{

// the public list is used to show the variable in the inspector and is used to store the correct password as a list of integers
   public List<int> correctPassword = new List<int>();
   // the private list is used to store the input password as a list of integers
   private List<int> inputPasswordList = new List<int>();
    // the private TMP input field is used to show the variable in the inspector and is used to display the code
   [SerializeField] private TMP_InputField codeDisplay;
   // the private float is used to show the variable in the inspector and is used to reset the time every 2 seconds
   [SerializeField] private float resetTime = 2f;
   // the serialize field is used to show the variable in the inspector and is used to show the success text
   [SerializeField] private string successText;
   // the space 5f is used to show the variable in the inspector and is used to add space
   [Space(5f)]
   // the header is used to show the variable in the inspector and shows the keypad entry events
   [Header("Keypad Entry Events")]
   // the unity event is used to invoke the correct password
   public UnityEvent onCorrectPassword;
   // the unity event is used to invoke the incorrect password
   public UnityEvent onIncorrectPassword;

// the public bool is used to show the variable in the inspector and is used to allow multiple activations this is set to false
   public bool allowMultipleActivations = false;
    // the private bool is used to check if the correct code has been used adnd is equal to false
   private bool hasUsedCorrectCode = false;

   // the public bool is used to show the variable in the inspector and is used to check if the correct code has been used 
   public bool HasUsedCorrectCode { get { return hasUsedCorrectCode; } }

// the public void is used to check the players number entry and if the input password list is greater than or equal to 4 then the player cannot enter any more numbers
   public void UserNumberEntry(int selectedNum)
   {
    if(inputPasswordList.Count >= 4)
    return;
// the input password list is added to the selected number
    inputPasswordList.Add(selectedNum);
// the update display is called because the input password list has been updated
    UpdateDisplay();

    if(inputPasswordList.Count >= 4)
    CheckPassword();
    
   }
// the private void is used to update the display
    private void UpdateDisplay()
    {
        // the code display text is equal to null
        codeDisplay.text = null;
        // the for loop is used to loop through the input password list and add the input password list to the code display text
        for(int i = 0; i < inputPasswordList.Count; i++)
        {
            // the code display text is equal to the input password list
            codeDisplay.text += inputPasswordList[i];
        }
    }

// the private void is used to check the password and if the input password list is not equal to the correct password then the incorrect password is called
    private void CheckPassword()
{
    // the for loop is used to loop through the correct password and if the input password list is not equal to the correct password then the incorrect password is called
        for (int i = 0; i < correctPassword.Count; i++)
    {
        // if the input password list is not equal to the correct password then the incorrect password is called
        if(inputPasswordList[i] != correctPassword[i])
        {
            // the incorrect password is returned
            IncorrectPassword();
            return;
        }   
    }
    // the correct password given is called
    correctPasswordGiven();
}
// the private void is used to check if the correct password has been given and if the correct password has been given then the on correct password is invoked
    private void correctPasswordGiven()
    {
        // if the allow multiple activations is true then the on correct password is invoked
        if(allowMultipleActivations)
        {
            onCorrectPassword.Invoke();
            // the code display text is equal to the success text
            codeDisplay.text = successText;
            // the reset key code is called the coroutine basically waits for the reset time and then resets the key code
            StartCoroutine(ResetKeyCode());
        }
        // else if the allow multiple activations is false and the correct code has not been used then the on correct password is invoked
        else if(!allowMultipleActivations && !hasUsedCorrectCode)
        {
            onCorrectPassword.Invoke();
            // the code display text is equal to the success text if the correct code has not been used
            hasUsedCorrectCode = true;
            codeDisplay.text = successText;
        }
    }

// the private void is used to check if the incorrect password has been given and if the incorrect password has been given then the on incorrect password is invoked
    private void IncorrectPassword()
    {
        onIncorrectPassword.Invoke();
        StartCoroutine(ResetKeyCode());
    }
// the ienumerator is used to reset the key code and waits for the reset time
    IEnumerator ResetKeyCode()
    {
        // the yield return new wait for seconds is used to wait for the reset time
        yield return new WaitForSeconds(resetTime);
        inputPasswordList.Clear();
        // the update display is called because the input password list has been updated and as a result the code display text is equal to enter code
        codeDisplay.text = "Enter Code...";
    }

// the public void is used to delete the entry and if the input password list is less than or equal to 0 then the return is called
    public void DeleteEntry()
    {
        // if the input password list is less than or equal to 0 then the return is called
        if(inputPasswordList.Count <= 0)
        return;
// the list position is equal to the input password list count minus 1, it deletes the last input into the password list
        var listposition = inputPasswordList.Count - 1;
        inputPasswordList.RemoveAt(listposition);
// then is updated because the input password list has one less number
        UpdateDisplay();
    }
}

