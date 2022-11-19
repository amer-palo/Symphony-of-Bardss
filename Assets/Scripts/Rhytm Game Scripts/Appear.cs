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
        yield return new WaitForSeconds(4.5f);

        arrowFive.SetActive(true);
        arrowOne.SetActive(true);
        arrowTwo.SetActive(true);
        arrowThree.SetActive(true);
        arrowFour.SetActive(true);
    }
}
