using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject bottlePieceOne, bottleSlotOne, bottleSlotTwo, bottleSlotThree;

    Vector2 bottleOnePos;
    void Start()
    {
       bottleOnePos = bottlePieceOne.transform.position; 
    }

   public void DragBottleOne()
   {
        bottlePieceOne.transform.position = Input.mousePosition;
   }

   

    public void DropBottleOne()
    {
        
        float distance = Vector3.Distance(bottlePieceOne.transform.position, bottleSlotOne.transform.position);
        if (bottlePieceOne.tag == "Red")
        {
            if (distance < 50)
            {
                bottlePieceOne.transform.position = bottleSlotOne.transform.position;
                Destroy(bottlePieceOne);
                Destroy(bottleSlotOne);
            }
        }
        else
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }
    }

    public void DropBottleTwo()
    {

        float distance = Vector3.Distance(bottlePieceOne.transform.position, bottleSlotTwo.transform.position);
        if (bottlePieceOne.tag == "Blue")
        {
            if (distance < 50)
            {
                bottlePieceOne.transform.position = bottleSlotTwo.transform.position;
            }
        }
        else
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }
    }

    public void DropBottleThree()
    {

        float distance = Vector3.Distance(bottlePieceOne.transform.position, bottleSlotTwo.transform.position);
        if (bottlePieceOne.tag == "Green")
        {
            if (distance < 50)
            {
                bottlePieceOne.transform.position = bottleSlotOne.transform.position;
            }
        }
        else
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }
    }


}
