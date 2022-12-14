using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurviveCollider : GameBehaviour
{
    public GameObject surviveUI;
    public GameObject player;
    public Transform exitPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       surviveUI.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void gotoSurvive()
    {
        _Save.SavePosition(exitPoint);
        _SC.FadeOut("Survive The Night Game");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Survive The Night Game");
    }

    public void exitSurvive()
    {
        
        surviveUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
