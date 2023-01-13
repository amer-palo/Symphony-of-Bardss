using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveTavern : GameBehaviour
{
    public GameObject player;
    public Transform exitPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _SC.FadeOut("Outside 2.0");
        _Save.SavePosition(exitPoint);

    }
}
