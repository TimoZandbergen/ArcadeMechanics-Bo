using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainPlayMap");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}
