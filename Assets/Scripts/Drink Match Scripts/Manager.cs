using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject bottlePieceOne, bottlePieceTwo, bottlePieceThree, bottleSlotOne, bottleSlotTwo, bottleSlotThree;

    Vector2 bottleOnePos, bottleTwoPos, bottleThreePos;
    void Start()
    {
       bottleOnePos = bottlePieceOne.transform.position;
       bottleTwoPos = bottlePieceTwo.transform.position;
       bottleThreePos = bottlePieceThree.transform.position;
        
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
        if(distance<50)
        {
            bottlePieceOne.transform.position = bottleSlotOne.transform.position;
        }
        else
        {
            bottlePieceOne.transform.position = bottleOnePos;  
        }
    }

    public void DropBottleTwo()
    {
        float Distance = Vector3.Distance(bottlePieceTwo.transform.position, bottleSlotTwo.transform.position);
        if (Distance < 50)
        {
            bottlePieceTwo.transform.position = bottleSlotTwo.transform.position;
        }
        else
        {
            bottlePieceTwo.transform.position = bottleTwoPos;
        }
    }

    public void DropBottleThree()
    {
        float Distance = Vector3.Distance(bottlePieceThree.transform.position, bottleSlotThree.transform.position);
        if (Distance < 50)
        {
            bottlePieceThree.transform.position = bottleSlotThree.transform.position;
        }
        else
        {
            bottlePieceThree.transform.position = bottleThreePos;
        }
    }
}
