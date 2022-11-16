using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurviveCollider : MonoBehaviour
{
    public GameObject surviveUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       surviveUI.SetActive(true);
    }
    public void gotoSurvive()
    {
        SceneManager.LoadScene("Survive The Night Game");
    }

    public void exitSurvive()
    {
        surviveUI.SetActive(false);
    }
}
