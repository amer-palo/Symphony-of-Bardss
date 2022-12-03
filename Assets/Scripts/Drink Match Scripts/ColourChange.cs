using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour
{
    public Image myImage;


    private void Start()
    {
        myImage = GetComponent<Image>();
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myImage.color = Color.red;
        Debug.Log("Coll");
    }


}
