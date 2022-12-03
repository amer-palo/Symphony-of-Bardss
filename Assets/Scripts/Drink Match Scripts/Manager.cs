using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject bottlePieceOne, bottleSlotOne;

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
        if(distance<50)
        {
            bottlePieceOne.transform.position = bottleSlotOne.transform.position;
        }
        else
        {
            bottlePieceOne.transform.position = bottleOnePos;  
        }
    }

    
}
