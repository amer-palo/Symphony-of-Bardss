using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrinkMatchRules : GameBehaviour
{
    public GameObject drinkUI;
    public GameObject player;
    public Transform exitPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        drinkUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void gotoDrink()
    {
        Debug.Log("button hit");
        _Save.SavePosition(exitPoint);
        _SC.FadeOut("MatchTheDrinkGame");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MatchTheDrinkGame");
    }

    public void Back()
    {
        drinkUI.SetActive(false);
        Time.timeScale = 1f;
    }

}
