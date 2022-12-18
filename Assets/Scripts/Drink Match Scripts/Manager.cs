using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject bottlePieceOne, bottlePieceTwo, bottlePieceThree, bottlePieceFour, bottlePieceFive, bottleSlotOne, bottleSlotTwo, bottleSlotThree, bottleSlotFour, bottleSlotFive;
    public GameObject blueShower, yellowShower, purpleShower, brownShower, greenShower;

    Vector2 bottleOnePos, bottleTwoPos, bottleThreePos, bottleFourPos, bottleFivePos;
    void Start()
    {
       bottleOnePos = bottlePieceOne.transform.position;
       bottleTwoPos = bottlePieceOne.transform.position;
       bottleThreePos = bottlePieceOne.transform.position;
       bottleFourPos = bottlePieceFour.transform.position;
       bottleFivePos = bottlePieceFive.transform.position;
    }

   public void DragBottleOne()
   {
        bottlePieceOne.transform.position = Input.mousePosition;
   }

    public void DragBottleTwo()
    {
        bottlePieceTwo.transform.position = Input.mousePosition;
    }

    public void DragBottleThree()
    {
        bottlePieceThree.transform.position = Input.mousePosition;
    }

    public void DragBottleFour()
    {
        bottlePieceFour.transform.position = Input.mousePosition;
    }

    public void DragBottleFive()
    {
        bottlePieceFive.transform.position = Input.mousePosition;
    }



    public void DropBottleOne()
    {
        
        float distance = Vector3.Distance(bottlePieceOne.transform.position, bottleSlotOne.transform.position);
        if (bottlePieceOne.tag == "Blue")
        {
            if (distance < 50)
            {
                bottlePieceOne.transform.position = bottleSlotOne.transform.position;
                Destroy(bottlePieceOne);
                Destroy(bottleSlotOne);
                bottlePieceTwo.SetActive(true);
                bottleSlotTwo.SetActive(true);
                blueShower.SetActive(false);
                yellowShower.SetActive(true);
            }

            else
            {
                bottlePieceOne.transform.position = bottleOnePos;
            }
        }
        else
        {
            ResetOne();
        }
    }

    public void DropBottleTwo()
    {

        float distance = Vector3.Distance(bottlePieceTwo.transform.position, bottleSlotTwo.transform.position);
        if (bottlePieceTwo.tag == "Yellow")
        {
            if (distance < 50)
            {
                bottlePieceTwo.transform.position = bottleSlotTwo.transform.position;
                Destroy(bottlePieceTwo);
                Destroy(bottleSlotTwo);
                bottlePieceThree.SetActive(true);
                bottleSlotThree.SetActive(true);
                yellowShower.SetActive(false);
                purpleShower.SetActive(true);
            }

            else
            {
                bottlePieceTwo.transform.position = bottleTwoPos;
            }
        }
        else
        {
           ResetTwo();
        }
    }

    public void DropBottleThree()
    {

        float distance = Vector3.Distance(bottlePieceThree.transform.position, bottleSlotThree.transform.position);
        if (bottlePieceThree.tag == "Purple")
        {
            if (distance < 50)
            {
                bottlePieceThree.transform.position = bottleSlotThree.transform.position;
                Destroy(bottlePieceThree);
                Destroy(bottleSlotThree);
                bottlePieceFour.SetActive(true);
                bottleSlotFour.SetActive(true);
                purpleShower.SetActive(false);
                brownShower.SetActive(true);

            }

            else
            {
                bottlePieceThree.transform.position = bottleThreePos;
            }
        }
        else
        {
            ResetThree();
        }
    }

    public void DropBottleFour()
    {

        float distance = Vector3.Distance(bottlePieceFour.transform.position, bottleSlotFour.transform.position);
        if (bottlePieceFour.tag == "Brown")
        {
            if (distance < 50)
            {
                bottlePieceFour.transform.position = bottleSlotFour.transform.position;
                Destroy(bottlePieceFour);
                Destroy(bottleSlotFour);
                bottlePieceFive.SetActive(true);
                bottleSlotFive.SetActive(true);
                brownShower.SetActive(false);
                greenShower.SetActive(true);
            }

            else
            {
                bottlePieceFour.transform.position = bottleFourPos;
            }
        }
        else
        {
            ResetFour();
        }
    }

    public void DropBottleFive()
    {

        float distance = Vector3.Distance(bottlePieceFive.transform.position, bottleSlotFive.transform.position);
        if (bottlePieceFive.tag == "Green")
        {
            if (distance < 50)
            {
                bottlePieceFive.transform.position = bottleSlotFive.transform.position;
                Destroy(bottlePieceFive);
                Destroy(bottleSlotFive);
            }

            else
            {
                bottlePieceFive.transform.position = bottleFivePos;
            }
        }
        else
        {
            ResetFive();
        }
    }

    public void ResetOne()
    {
        if (bottlePieceOne.tag == "Red")
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }

        if (bottlePieceOne.tag == "Blue")
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }

        if (bottlePieceOne.tag == "Orange")
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }

        if (bottlePieceOne.tag == "Purple")
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }

        if (bottlePieceOne.tag == "Yellow")
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }

        if (bottlePieceOne.tag == "Brown")
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }

        if (bottlePieceOne.tag == "Green")
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }

        if (bottlePieceOne.tag == "Mug")
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }
    }

    public void ResetTwo()
    {
        if(bottlePieceTwo.tag == "Blue")
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }

        if (bottlePieceTwo.tag == "Yellow")
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }

        if (bottlePieceTwo.tag == "Orange")
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }

        if (bottlePieceTwo.tag == "Green")
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }

        if (bottlePieceTwo.tag == "Brown")
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }

        if (bottlePieceTwo.tag == "Purple")
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }

        if (bottlePieceTwo.tag == "Red")
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }

        if (bottlePieceTwo.tag == "Mug")
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }

    }

    public void ResetThree()
    {
        if(bottlePieceThree.tag == "Red")
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }

        if (bottlePieceThree.tag == "Blue")
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }

        if (bottlePieceThree.tag == "Green")
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }

        if (bottlePieceThree.tag == "Purple")
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }

        if (bottlePieceThree.tag == "Yellow")
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }

        if (bottlePieceThree.tag == "Brown")
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }

        if (bottlePieceThree.tag == "Orange")
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }

        if (bottlePieceThree.tag == "Mug")
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }
    }

    public void ResetFour()
    {
        if (bottlePieceFour.tag == "Red")
        {
            bottlePieceFour.transform.position = bottleFourPos;
        }

        if (bottlePieceFour.tag == "Blue")
        {
            bottlePieceFour.transform.position = bottleFourPos;
        }

        if (bottlePieceFour.tag == "Yellow")
        {
            bottlePieceFour.transform.position = bottleFourPos;
        }

        if (bottlePieceFour.tag == "Brown")
        {
            bottlePieceFour.transform.position = bottleFourPos;
        }

        if (bottlePieceFour.tag == "Orange")
        {
            bottlePieceFour.transform.position = bottleFourPos;
        }

        if (bottlePieceFour.tag == "Purple")
        {
            bottlePieceFour.transform.position = bottleFourPos;
        }

        if (bottlePieceFour.tag == "Green")
        {
            bottlePieceFour.transform.position = bottleFourPos;
        }

        if (bottlePieceFour.tag == "Mug")
        {
            bottlePieceFour.transform.position = bottleFourPos;
        }
    }

    public void ResetFive()
    {
        if(bottlePieceFive.tag == "Red")
        {
            bottlePieceFive.transform.position = bottleFivePos;
        }

        if (bottlePieceFive.tag == "Blue")
        {
            bottlePieceFive.transform.position = bottleFivePos;
        }

        if (bottlePieceFive.tag == "Yellow")
        {
            bottlePieceFive.transform.position = bottleFivePos;
        }

        if (bottlePieceFive.tag == "Orange")
        {
            bottlePieceFive.transform.position = bottleFivePos;
        }

        if (bottlePieceFive.tag == "Green")
        {
            bottlePieceFive.transform.position = bottleFivePos;
        }

        if (bottlePieceFive.tag == "Purple")
        {
            bottlePieceFive.transform.position = bottleFivePos;
        }

        if (bottlePieceFive.tag == "Brown")
        {
            bottlePieceFive.transform.position = bottleFivePos;
        }

        if (bottlePieceFive.tag == "Empty")
        {
            bottlePieceFive.transform.position = bottleFivePos;
        }
    }    

}
