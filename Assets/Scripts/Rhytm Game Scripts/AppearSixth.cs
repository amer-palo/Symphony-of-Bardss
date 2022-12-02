using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearSixth : MonoBehaviour
{
    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    public GameObject note5;

    public void Start()
    {
        note1.SetActive(false);
        note2.SetActive(false);
        note3.SetActive(false);
        note4.SetActive(false);
        note5.SetActive(false);

        //ShowArrows();
        StartCoroutine(WaitBeforeShowinggg());
    }

    public void ShowArrows()
    {
        note1.SetActive(true);
        note2.SetActive(true);
        note3.SetActive(true);
        note4.SetActive(true);
        note5.SetActive(true);
    }

    IEnumerator WaitBeforeShowinggg()
    {
        yield return new WaitForSeconds(15.9f);

        note1.SetActive(true);
        note2.SetActive(true);
        note3.SetActive(true);
        note4.SetActive(true);
        note5.SetActive(true);
    }
}
