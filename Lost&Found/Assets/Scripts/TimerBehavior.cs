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

    [SerializeField] ClipBoard clipBoard;

    IObjectState state;
    [SerializeField] TimerStateCaller events;

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
            events.TurnOff();
        }
        if (seconds == 0 && minutes > 0)
        {
            seconds = 60;
            minutes--;
        }
        if (gameOver)
        {
            timer.text = "TIME'S OVER";
            seconds = 0;
            minutes = 0;
            finishtemp -= Time.deltaTime;
            playerControl.speed = 0;

            for (int i = 0; i < clipBoard.lostObjects.Count; i++)
            {
                clipBoard.lostObjects[i].SetActive(false);
            }
        }

        if (finishtemp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnEnable()
    {
        events._TurnOff += TurnOff;
    }

    private void OnDisable()
    {
        events._TurnOff -= TurnOff;
    }

    public void TurnOff()
    {
        state = new TurnedOffState();
        state.execute(this);
    }
}
