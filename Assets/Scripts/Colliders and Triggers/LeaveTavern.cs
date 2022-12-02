using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveTavern : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Symphony of Bards");
        player.GetComponent<Save_Player>().LoadOutside();
    }
}
