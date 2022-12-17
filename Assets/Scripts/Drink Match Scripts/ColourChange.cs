using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour
{
    public Image myImage;
    public string newTag;
    //public Image redMug;
    public Sprite redMugRenderer;
    public Sprite blueMugRenderer;
    public Sprite yellowMugRenderer;
    public Sprite orangeRenderer;
    public Sprite brownRenderer;
    public Sprite greenMugRenderer;
    public Sprite purpleMugRenderer;


    private void Start()
    {
        gameObject.tag = "Mug";
        myImage = GetComponent<Image>();
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Red")
        {
            this.gameObject.GetComponent<Image>().sprite = redMugRenderer;
            gameObject.tag = "Red";
            Debug.Log("Coll");
        }

        if (other.gameObject.tag == "Blue")
        {
            this.gameObject.GetComponent<Image>().sprite = blueMugRenderer;
            gameObject.tag = "Blue";
            Debug.Log("Coll");
        }

        if (other.gameObject.tag == "Yellow")
        {
            this.gameObject.GetComponent<Image>().sprite = yellowMugRenderer;
            gameObject.tag = "Yellow";
            Debug.Log("Coll");
        }
    }


}
