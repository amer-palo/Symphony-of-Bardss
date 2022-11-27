using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Colour")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
