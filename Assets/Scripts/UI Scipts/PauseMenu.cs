using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : GameBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenu;
    public GameObject popupMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
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
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in audios)
        {
            a.Play();
        }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        /*foreach (AudioSource a in audios)
        {
            a.Pause();
        }
        */
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        _SC.FadeOut("Start");
    }
    public void Back()
    {
        popupMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in audios)
        {
            a.Play();
        }
    }
    public void Quitting()
    {
        Debug.Log("QUITTING!");
        Application.Quit();
    }

    public void GoToTavern()
    {
        _SC.FadeOut("Tavern 3.0");

    }
}
