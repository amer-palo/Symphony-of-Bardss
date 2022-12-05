using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TavernCollider : GameBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GoToTavern();
    }
    public void GoToTavern()
    {
        
        _SC.FadeOut("Tavern");
    }
}
