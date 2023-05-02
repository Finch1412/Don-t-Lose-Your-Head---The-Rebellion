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
        //Makes sure the game isn't pasued on start.
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Escape assigned as pause button.
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

    //Sets pause as true while enabling the pause menu panel and freezing in game time.
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        //player.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
        controlsPanel.SetActive(false);
        controlsOpen = false;
    }

    //Closes the pause menu and unfreezes time.
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        //player.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
        controlsOpen = false;

    }

    //Unfreezes time and transitions back the main game menu.
    public void GoToMenu()
    {
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(menu);
    }

    //Quits the game.
    public void QuitGame()
    {
        Application.Quit();
    }

    //Plays an error sound.
    public void Settings()
    {
        settingButton.PlayOneShot(errorSound);
    }

    //opens and closed the controls panel within the pause menu.
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
