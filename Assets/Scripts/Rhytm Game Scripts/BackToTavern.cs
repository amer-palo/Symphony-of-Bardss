using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTavern : MonoBehaviour
{
    public void backtoTavern()
    {
        SceneManager.LoadScene("Tavern");
        Time.timeScale = 1f;
    }
}
