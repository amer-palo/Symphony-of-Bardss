using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Player : Singleton<Save_Player>
{
    public Transform exitPosition;
    public Vector3 exitVector;
    public int firstStart = 0;
    public void Start()
    {
        
    }

    public void SavePosition(Transform exit)
    {
        exitPosition = exit;
        exitVector = exitPosition.position;
    }



    public Vector3 LoadPosition()
    {
        return exitVector;
    }
}
