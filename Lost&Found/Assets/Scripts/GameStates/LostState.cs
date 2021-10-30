using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostState : IGameState
{
    public void execute(SceneChanger sceneChanger)
    {
        //Cargar escena de derrota

        SceneManager.LoadScene(sceneChanger.lost);
    }
}
