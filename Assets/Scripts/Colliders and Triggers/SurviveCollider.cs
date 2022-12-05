using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurviveCollider : GameBehaviour
{
    public GameObject surviveUI;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       surviveUI.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void gotoSurvive()
    {

        _SC.FadeOut("Survive The Night Game");
        Time.timeScale = 1f;
    }

    public void exitSurvive()
    {
        
        surviveUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
