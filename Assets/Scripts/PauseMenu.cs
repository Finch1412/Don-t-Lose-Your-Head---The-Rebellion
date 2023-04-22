using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject controlsPanel;
    //public GameObject player;
    public static bool isPaused;
    public string menu;
    public AudioSource settingButton;
    public AudioClip errorSound;
    public bool controlsOpen;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        //player.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
        controlsPanel.SetActive(false);
        controlsOpen = false;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        //player.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
        controlsOpen = false;

    }

    public void GoToMenu()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(menu);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        settingButton.PlayOneShot(errorSound);
    }

    public void Controls()
    {
        if (!controlsOpen)
        {
            controlsPanel.SetActive(true);
            controlsOpen = true;
        }
        else
        {
            controlsPanel.SetActive(false);
            controlsOpen = false;
        }
        
    }

}
