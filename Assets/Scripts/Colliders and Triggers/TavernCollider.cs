using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TavernCollider : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Tavern");
        player.GetComponent<Save_Player>().SaveOutside();
    }
}
