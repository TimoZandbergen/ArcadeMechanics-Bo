using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManuMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Map1");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}
