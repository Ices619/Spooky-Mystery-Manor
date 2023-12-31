using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //These are all scenes that are loadable
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        Cursor.visible = true;

        Time.timeScale = 1.0f;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void second()
    {
        SceneManager.LoadScene(2);
    }
}
