using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour
{
    public Image myImage;
    public string newTag;


    private void Start()
    {
        gameObject.tag = "Bottle";
        myImage = GetComponent<Image>();
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Red")
        {
            gameObject.tag = "Red";
            myImage.color = Color.red;
            Debug.Log("Coll");
        }

        if (other.gameObject.tag == "Blue")
        {
            gameObject.tag = "Blue";
            myImage.color = Color.blue;
            Debug.Log("Coll");
        }

        if (other.gameObject.tag == "Green")
        {
            gameObject.tag = "Green";
            myImage.color = Color.green;
            Debug.Log("Coll");
        }
    }


}
