using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void Enter(string sceneName)
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
