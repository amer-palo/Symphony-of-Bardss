using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearNinth : MonoBehaviour
{
    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    public GameObject note5;

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;
    public GameObject set4;
    public GameObject set5;
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
        yield return new WaitForSeconds(23.9f);

        note1.SetActive(true);
        note2.SetActive(true);
        note3.SetActive(true);
        note4.SetActive(true);
        note5.SetActive(true);

        set1.SetActive(false);
        set2.SetActive(false);
        set3.SetActive(false);
        set4.SetActive(false);
        set5.SetActive(false);
    }
}
