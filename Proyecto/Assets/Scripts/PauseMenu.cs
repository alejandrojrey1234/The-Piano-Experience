using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject DesactivarMovimiento;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pauseMenuUI.SetActive(true);

            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Cursor.visible = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ScenesMenu()
    {
        SceneManager.LoadScene(1);
    }
}
