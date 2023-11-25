using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class GameManager : MonoBehaviour
{
    // header title for timer components
    [Header("Timer Components")]
    // measuring game time using float, this is max time of game
    [SerializeField] private float gameTime;
    // text box to display time
    [SerializeField] TextMeshProUGUI timeTextBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // updating game timer method, every frame it will update
        UpdateGameTimer();
    }

    private void UpdateGameTimer()
    {
        // taking the game time and subtracting it by delta time
        gameTime -= Time.deltaTime;
        // displaying the time in minutes and seconds, using string format. Using mathf to round the time. The seconds minus the minutes as the game manager is counting down
        var minutes = Mathf.FloorToInt(gameTime / 60);
        var seconds = Mathf.FloorToInt(gameTime - minutes * 60);
        string gameTimeClockDisplay = string.Format("{0:00}:{1:00}", minutes, seconds);
        // then it passed to the time text box to display
        timeTextBox.text = gameTimeClockDisplay;
    }
}
