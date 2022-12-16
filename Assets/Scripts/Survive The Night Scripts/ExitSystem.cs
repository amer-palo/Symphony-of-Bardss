using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSystem : MonoBehaviour
{
    public GameObject winUI;
    public WaveSystem WS;
    public GameObject waveSpawner;
    public void Update()
    {
        if (WS.gameOver == true)
        {
            waveSpawner.SetActive(false);
        }
    }


    public void  ContinueGame()
    {
        Debug.Log("Presed");
        winUI.SetActive(false);
    }
}
