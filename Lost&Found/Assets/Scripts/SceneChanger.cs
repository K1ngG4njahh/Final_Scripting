using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public string victory = "Victory";
    public string lost = "GameOver";
    public string level = "Level1";
    public string menu = "main";

    IGameState states;
    [SerializeField] GameStateCaller events;

    private void OnEnable()
    {
        events._load += Load;
        events._won += Won;
        events._lost += Lost;
        events._menu += Menu;
    }

    private void OnDisable()
    {
        events._load -= Load;
        events._won -= Won;
        events._lost -= Lost;
        events._menu -= Menu;
    }

    public void Load()
    {
        states = new LoadState();
        states.execute(this);
    }

    public void Won()
    {
        states = new WonState();
        states.execute(this);
    }

    public void Lost()
    {
        states = new LostState();
        states.execute(this);
    }

    public void Menu()
    {
        states = new MainState();
        states.execute(this);
    }
}
