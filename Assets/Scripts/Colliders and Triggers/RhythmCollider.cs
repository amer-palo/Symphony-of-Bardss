using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RhythmCollider : MonoBehaviour
{
    public GameObject rhythmUI;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rhythmUI.SetActive(true);
        Time.timeScale = 0f;
        player.GetComponent<Save_Player>().Save();

    }
    public void gotoRhytm()
    {
        
        SceneManager.LoadScene("Rhythm");
        Time.timeScale = 1f;
    }

    public void exitRhtyhm()
    {
        player.GetComponent<Save_Player>().Load();
        Debug.Log("This has run");
        rhythmUI.SetActive(false);
        Time.timeScale = 1f;
        
    }
}
