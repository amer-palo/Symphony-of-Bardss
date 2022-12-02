using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurviveCollider : MonoBehaviour
{
    public GameObject surviveUI;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       surviveUI.SetActive(true);
        Time.timeScale = 0f;
        player.GetComponent<Save_Player>().Save();
    }
    public void gotoSurvive()
    {
        
        SceneManager.LoadScene("Survive The Night Game");
        Time.timeScale = 1f;
    }

    public void exitSurvive()
    {
        player.GetComponent<Save_Player>().Load();
        surviveUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
