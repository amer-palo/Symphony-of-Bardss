using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public GameObject arrowOne;
    public GameObject arrowTwo;
    public GameObject arrowThree;
    public GameObject arrowFour;
    public GameObject arrowFive;

    public GameObject firstOne;
    public GameObject firstTwo;
    public GameObject firstThree;
    public GameObject firstFour;
    public GameObject firstFive;    

    public void Start()
    {
        arrowFive.SetActive(false);
        arrowOne.SetActive(false);
        arrowTwo.SetActive(false);
        arrowThree.SetActive(false);
        arrowFour.SetActive(false);

        //ShowArrows();
        StartCoroutine(WaitBeforeShow());
    }

    public void ShowArrows()
    {
        arrowFive.SetActive(true);
        arrowOne.SetActive(true);
        arrowTwo.SetActive(true);
        arrowThree.SetActive(true);
        arrowFour.SetActive(true);
    }

    IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(3.5f);

        arrowFive.SetActive(true);
        arrowOne.SetActive(true);
        arrowTwo.SetActive(true);
        arrowThree.SetActive(true);
        arrowFour.SetActive(true);

        firstOne.SetActive(false);
        firstTwo.SetActive(false);
        firstThree.SetActive(false);
        firstFour.SetActive(false);
        firstFive.SetActive(false);
    }
}
