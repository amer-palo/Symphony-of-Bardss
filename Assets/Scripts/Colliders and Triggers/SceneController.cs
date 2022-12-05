using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public enum GameState { Play, Loading }
public class SceneController : Singleton<SceneController>
{
    public GameState gameState;


    public CanvasGroup black;
    public float fadeSpeed = 2f;
    
    void Start()
    {
        gameState = GameState.Loading;
        //black.DOFade(1, 0);
        //FadeIn();
    }

    void LoadLevel(string level)
    {
        Debug.Log("Fade");
        SceneManager.LoadScene(level);
    }
    public void FadeOut(string level)
    {
        
        gameState = GameState.Loading;
        black.DOFade(1, fadeSpeed).SetUpdate(true).OnComplete(()=>
        {
            Time.timeScale = 1;
            LoadLevel(level);
        }); //lambda expression: calling a fuction from within a function call

    }
    public void FadeIn()
    {
        black.DOFade(1, 0);
        black.DOFade(0, fadeSpeed).OnComplete(() => gameState = GameState.Play);
    }

    void OnEnable()
    {
    //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
    SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
         
    void OnDisable()
    {
     
     SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }
    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Level Loaded");
        FadeIn();
    }

}
