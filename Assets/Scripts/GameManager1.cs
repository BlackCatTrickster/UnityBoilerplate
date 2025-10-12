using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public bool gamePaused = false;
    [SerializeField] GameObject pauseMenu;
    void Update()
    {
        Debug.Log("Update");

        if (Input.GetKeyDown(KeyCode.Escape) && gamePaused == false)
        {

            Time.timeScale = 0;
            gamePaused = true;
            pauseMenu.SetActive(true);

        }
        else if ((Input.GetKeyDown(KeyCode.Escape) && gamePaused == true))
        {
            Time.timeScale = 1;
            gamePaused = false;
            pauseMenu.SetActive(false);
        }
    }
}
