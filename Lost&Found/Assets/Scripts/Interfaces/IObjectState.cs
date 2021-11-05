using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectState
{
    void execute(TimerBehavior timerBehaviour);
}
