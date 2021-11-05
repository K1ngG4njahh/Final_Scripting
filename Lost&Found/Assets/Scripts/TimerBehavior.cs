using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerBehavior : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] PlayerMovement playerControl;
    public float seconds , minutes, finishtemp;
    public bool gameOver;

    IGameState states;
    [SerializeField] GameStateCaller events;

    private void Start()
    {
        finishtemp = 1;
    }
    void Update()
    {
        if(seconds > 0)
        {
            seconds -= 1 * Time.deltaTime;
            timer.text = minutes.ToString("0") + ":" + seconds.ToString("0.0");
        }        
        else if (minutes <= 0 && seconds <= 0 )
        {
            timer.text = "TIME'S OVER";
            seconds = 0;
            minutes = 0;
            gameOver = true;
            finishtemp -= Time.deltaTime;
            playerControl.speed = 0;
        }
        if (seconds == 0 && minutes > 0)
        {
            seconds = 60;
            minutes--;
        }

        if (finishtemp <= 0)
        {
            events.Lost();
            SceneManager.LoadScene("GameOver");
        }
    }
}
