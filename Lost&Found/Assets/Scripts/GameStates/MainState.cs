using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainState : IGameState
{
    public void execute(SceneChanger sceneChanger)
    {
        //Cargar escena de menu

        SceneManager.LoadScene(sceneChanger.menu);
    }
}
