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
    }
    public void gotoRhytm()
    {
        SceneManager.LoadScene("Rhythm");
    }

    public void exitRhtyhm()
    {
        rhythmUI.SetActive(false);
    }
}
