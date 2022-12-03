using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearThird : MonoBehaviour
{
    public GameObject arrowSetOne;
    public GameObject arrowSetTwo;
    public GameObject arrowSetThree;
    public GameObject arrowSetFour;
    public GameObject arrowSetFive;

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;
    public GameObject set4;
    public GameObject set5;

    public void Start()
    {
        arrowSetOne.SetActive(false);
        arrowSetTwo.SetActive(false);
        arrowSetThree.SetActive(false);
        arrowSetFour.SetActive(false);
        arrowSetFive.SetActive(false);

        StartCoroutine(WaitBeforeShown());
    }

    public void ShowArrows()
    {
        arrowSetOne.SetActive(true);
        arrowSetTwo.SetActive(true);
        arrowSetThree.SetActive(true);
        arrowSetFour.SetActive(true);
        arrowSetFive.SetActive(true);
    }

    IEnumerator WaitBeforeShown()
    {
        yield return new WaitForSeconds(8.2f);

        arrowSetOne.SetActive(true);
        arrowSetTwo.SetActive(true);
        arrowSetThree.SetActive(true);
        arrowSetFour.SetActive(true);
        arrowSetFive.SetActive(true);

        set1.SetActive(false);
        set2.SetActive(false);
        set3.SetActive(false);
        set4.SetActive(false);
        set5.SetActive(false);
    }
}
