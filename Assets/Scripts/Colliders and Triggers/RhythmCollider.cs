using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RhythmCollider : GameBehaviour
{
    public GameObject rhythmUI;
    public GameObject player;
    public Transform exitPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rhythmUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void gotoRhytm()
    {
        Debug.Log("button hit");
        _Save.SavePosition(exitPoint);
        _SC.FadeOut("Rhythm");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Rhythm");
    }

    public void Back()
    {
        rhythmUI.SetActive(false);
        Time.timeScale = 1f;
    }
    
}
