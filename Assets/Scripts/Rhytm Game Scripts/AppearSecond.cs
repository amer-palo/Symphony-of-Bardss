using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearSecond : MonoBehaviour
{
    public GameObject arrowOne1;
    public GameObject arrowTwo2;
    public GameObject arrowThree3;
    public GameObject arrowFour4;
    public GameObject arrowFive5;

    public void Start()
    {
        arrowFive5.SetActive(false);
        arrowOne1.SetActive(false);
        arrowTwo2.SetActive(false);
        arrowThree3.SetActive(false);
        arrowFour4.SetActive(false);

        StartCoroutine(WaitBeforeShowing());
    }

    public void ShowArrows()
    {
        arrowFive5.SetActive(true);
        arrowOne1.SetActive(true);
        arrowTwo2.SetActive(true);
        arrowThree3.SetActive(true);
        arrowFour4.SetActive(true);
    }

    IEnumerator WaitBeforeShowing()
    {
        yield return new WaitForSeconds(10f);

        arrowFive5.SetActive(true);
        arrowOne1.SetActive(true);
        arrowTwo2.SetActive(true);
        arrowThree3.SetActive(true);
        arrowFour4.SetActive(true);
    }
}
