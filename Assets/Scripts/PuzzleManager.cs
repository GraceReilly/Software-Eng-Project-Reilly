using UnityEngine;
using UnityEngine.Events;

// tutorial followed for the below code - https://www.youtube.com/watch?v=iSYfs6NXZck&t=11s&ab_channel=DanielStringer
// mono behaviour to manage the puzzle
public class PuzzleManager : MonoBehaviour
{
    // the below serialize field is used to show the variable in the inspector and shows the number of tasks to complete
   [SerializeField] private int numberofTasksToComplete;
   // the below serialize field is used to show the variable in the inspector and shows the number of tasks completed it is set to 0
   [SerializeField] private int currentlyCompletedTasks = 0;

// header is used to show the variable in the inspector and shows the completion events
   [Header("Completion Events")]

   // the unity event is used to invoke the puzzle completion
   public UnityEvent OnPuzzleCompletetion;

// the below method is used to add the puzzle task, currently completed tasks is incremented and the check for puzzle completion is called
   public void CompletedPuzzleTask()
   {
      currentlyCompletedTasks++;
      CheckForPuzzleCompletion();
     
   }
// the private void is checking for puzzle completion and if the currently completed tasks is greater
// than or equal to the number of tasks to complete then the puzzle completion is invoked
    private void CheckForPuzzleCompletion()
    {
        if(currentlyCompletedTasks >= numberofTasksToComplete)
        {
            OnPuzzleCompletetion.Invoke();
        }
    }
// the below method is used to remove the puzzle piece and the currently completed tasks is decreased
    public void PuzzlePieceRemoved()
    {
        currentlyCompletedTasks--;
    }

}
