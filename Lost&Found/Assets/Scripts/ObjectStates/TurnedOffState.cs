using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnedOffState : IObjectState
{
    public void execute(TimerBehavior timerBehaviour)
    {
        timerBehaviour.gameOver = true;
    }
}
