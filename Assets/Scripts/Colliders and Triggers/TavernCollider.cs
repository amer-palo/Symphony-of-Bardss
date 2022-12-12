using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TavernCollider : GameBehaviour
{
    public GameObject player;
    public Transform exitPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GoToTavern();
    }
    public void GoToTavern()
    {
        _Save.SavePosition(exitPoint);
        _SC.FadeOut("Tavern 3.0");
    }
}
