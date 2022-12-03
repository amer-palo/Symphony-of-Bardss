using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearFifth : MonoBehaviour
{
    public GameObject noteOne;
    public GameObject noteTwo;
    public GameObject noteThree;
    public GameObject noteFour;
    public GameObject noteFive;

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;
    public GameObject set4;
    public GameObject set5;


    public void Start()
    {
        noteFive.SetActive(false);
        noteOne.SetActive(false);
        noteTwo.SetActive(false);
        noteThree.SetActive(false);
        noteFour.SetActive(false);

        //ShowArrows();
        StartCoroutine(WaitBeforeShowingg());
    }

    public void ShowArrows()
    {
        noteFive.SetActive(true);
        noteOne.SetActive(true);
        noteTwo.SetActive(true);
        noteThree.SetActive(true);
        noteFour.SetActive(true);
    }

    IEnumerator WaitBeforeShowingg()
    {
        yield return new WaitForSeconds(13.2f);

        noteFive.SetActive(true);
        noteOne.SetActive(true);
        noteTwo.SetActive(true);
        noteThree.SetActive(true);
        noteFour.SetActive(true);

        set1.SetActive(false);
        set2.SetActive(false);
        set3.SetActive(false);
        set4.SetActive(false);
        set5.SetActive(false);
    }
}
