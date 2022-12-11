using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject bottlePieceOne, bottlePieceTwo, bottlePieceThree, bottleSlotOne, bottleSlotTwo, bottleSlotThree;

    Vector2 bottleOnePos, bottleTwoPos, bottleThreePos;
    void Start()
    {
       bottleOnePos = bottlePieceOne.transform.position;
       bottleTwoPos = bottlePieceOne.transform.position;
       bottleThreePos = bottlePieceOne.transform.position;
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
                bottlePieceTwo.SetActive(true);
            }
        }
        else
        {
            bottlePieceOne.transform.position = bottleOnePos;
        }
    }

    public void DropBottleTwo()
    {

        float distance = Vector3.Distance(bottlePieceTwo.transform.position, bottleSlotTwo.transform.position);
        if (bottlePieceTwo.tag == "Blue")
        {
            if (distance < 50)
            {
                bottlePieceTwo.transform.position = bottleSlotTwo.transform.position;
                Destroy(bottlePieceTwo);
                Destroy(bottleSlotTwo);
                bottlePieceThree.SetActive(true);
            }
        }
        else
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }
    }

    public void DropBottleThree()
    {

        float distance = Vector3.Distance(bottlePieceThree.transform.position, bottleSlotThree.transform.position);
        if (bottlePieceThree.tag == "Green")
        {
            if (distance < 50)
            {
                bottlePieceThree.transform.position = bottleSlotThree.transform.position;
                Destroy(bottlePieceThree);
                Destroy(bottleSlotThree);
            }
        }
        else
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }
    }


}
