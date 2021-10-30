using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonState : IGameState
{
    public void execute(SceneChanger sceneChanger)
    {
        //Cargar escena de victoria

        SceneManager.LoadScene(sceneChanger.victory);
    }
}
