using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameStateCaller : ScriptableObject
{
    public event UnityAction _load;
    public event UnityAction _won;
    public event UnityAction _lost;
    public event UnityAction _menu;

    public void Load()
    {
        _load?.Invoke();
    }

    public void Won()
    {
        _won?.Invoke();
    }

    public void Lost()
    {
        _lost?.Invoke();
    }

    public void Menu()
    {
        _menu?.Invoke();
    }
}
