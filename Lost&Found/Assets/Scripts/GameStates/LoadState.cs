using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadState : IGameState
{
    public void execute(SceneChanger sceneChanger)
    {
        //Cargar escena de nivel

        SceneManager.LoadScene(sceneChanger.level);
    }
}
