using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ItemSlot : MonoBehaviour,  IDropHandler
{
    public bool Slot1;
    public bool Slot2;
    public bool Slot3;

    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Slot1 == true)
        {
            option1 = collision.gameObject;
        }
        if (Slot2 == true)
        {
            option2 = collision.gameObject;
        }
        if (Slot3 == true)
        {
            option3 = collision.gameObject;
        }
    }
}
