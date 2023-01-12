using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveSurvive : GameBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GoToTavern();
    }
    public void GoToTavern()
    {
        _Save.firstStart = 0;
        _SC.FadeOut("Tavern 3.0");
        SceneManager.LoadScene("Tavern 3.0");

    }
}
