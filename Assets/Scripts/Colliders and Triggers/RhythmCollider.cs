using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RhythmCollider : MonoBehaviour
{
    public GameObject rhythmUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rhythmUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void gotoRhytm()
    {
        SceneManager.LoadScene("Rhythm");
        Time.timeScale = 1f;
    }

    public void exitRhtyhm()
    {
        rhythmUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
