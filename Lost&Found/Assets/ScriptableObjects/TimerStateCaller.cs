using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class TimerStateCaller : ScriptableObject
{
    public event UnityAction _TurnOff;

    public void TurnOff()
    {
        _TurnOff?.Invoke();
    }
}
