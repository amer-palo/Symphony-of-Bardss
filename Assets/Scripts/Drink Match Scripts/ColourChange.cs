using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour
{
    public Image myImage;
    public string newTag;
    public bool nullRed = false;
    public bool nullBlue = false;
    public bool nullYellow = false;
    public bool nullColour = true;
    public bool nullOrange = false;
    public bool nullGreen = false;
    public bool nullPurple = false;
    //public Image redMug;
    public Sprite redMugRenderer;
    public Sprite blueMugRenderer;
    public Sprite yellowMugRenderer;
    public Sprite orangeMugRenderer;
    public Sprite brownMugRenderer;
    public Sprite greenMugRenderer;
    public Sprite purpleMugRenderer;
    public Sprite emptyMugRenderer;


    private void Start()
    {
        gameObject.tag = "Mug";
        myImage = GetComponent<Image>();

        NullChanger();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Red")
        {
            RedChanger();
        }

        else if (other.gameObject.tag == "Blue")
        {
            BlueChanger();
        }

        else if (other.gameObject.tag == "Yellow")
        {
           YellowChanger();
        }

        else if (other.gameObject.tag == "Empty")
        {
            NullChanger();
        }
    }

    public void BlueChanger()
    {
        if (nullColour == true)
        {
            nullColour = false;
            nullBlue = true;
            this.gameObject.GetComponent<Image>().sprite = blueMugRenderer;
            gameObject.tag = "Blue";
            Debug.Log("Blue");
        }

        else if (nullOrange == true)
        {
            this.gameObject.GetComponent<Image>().sprite = brownMugRenderer;
            gameObject.tag = "Brown";
            Debug.Log("Brown");
        }

        else if (nullYellow == true && nullRed == false)
        {
            this.gameObject.GetComponent<Image>().sprite = greenMugRenderer;
            gameObject.tag = "Green";
            Debug.Log("Green");
            nullGreen = true;
        }

        else if (nullRed == true && nullYellow == false)
        {
            this.gameObject.GetComponent<Image>().sprite = purpleMugRenderer;
            gameObject.tag = "Purple";
            Debug.Log("Purple");
            nullPurple = true;
        }

    }

    public void YellowChanger()

    {
        if (nullColour == true)
        {
            nullColour = false;
            nullYellow = true;
            this.gameObject.GetComponent<Image>().sprite = yellowMugRenderer;
            gameObject.tag = "Yellow";
            Debug.Log("Yellow");
        }

        else if (nullPurple == true)
        {
            this.gameObject.GetComponent<Image>().sprite = brownMugRenderer;
            gameObject.tag = "Brown";
            
            Debug.Log("Brown");
        }
        else if (nullBlue == true && nullRed == false)
        {
            this.gameObject.GetComponent<Image>().sprite = greenMugRenderer;
            gameObject.tag = "Green";
            Debug.Log("Green");
            nullGreen = true;
        }

        else if (nullRed == true && nullBlue == false)
        {
            this.gameObject.GetComponent<Image>().sprite = orangeMugRenderer;
            gameObject.tag = "Orange";
            Debug.Log("Orange");
            nullOrange = true;
        }
    }

    public void RedChanger()
    {
        if (nullColour == true)
        {
            nullColour = false;
            nullRed = true;
            this.gameObject.GetComponent<Image>().sprite = redMugRenderer;
            gameObject.tag = "Red";
            Debug.Log("Red");
        }

        else if (nullGreen == true)
        {
            this.gameObject.GetComponent<Image>().sprite = brownMugRenderer;
            gameObject.tag = "Brown";
            Debug.Log("Brown");
        }

        else if (nullYellow == true && nullBlue == false)
        {
            this.gameObject.GetComponent<Image>().sprite = orangeMugRenderer;
            gameObject.tag = "Orange";
            Debug.Log("Orange");
            nullOrange = true;
        }

        else if (nullBlue == true && nullYellow == false)
        {
            this.gameObject.GetComponent<Image>().sprite = purpleMugRenderer;
            gameObject.tag = "Purple";
            Debug.Log("Purple");
            nullPurple = true;
        }

    }

    public void NullChanger()
    {
        nullGreen = false;
        nullOrange = false;
        nullPurple = false;
        nullColour = true;
        nullRed = false;
        nullYellow = false;
        nullBlue = false;
        this.gameObject.GetComponent<Image>().sprite = emptyMugRenderer;
        gameObject.tag = "Mug";
    }
}
