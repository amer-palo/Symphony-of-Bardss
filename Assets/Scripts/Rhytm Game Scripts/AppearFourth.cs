using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearFourth : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;
    public GameObject arrow5;

    public void Start()
    {
        arrow1.SetActive(false);
        arrow2.SetActive(false);
        arrow3.SetActive(false);
        arrow4.SetActive(false);
        arrow5.SetActive(false);

        StartCoroutine(WaitBeforeShown());
    }

    public void ShowArrows()
    {
        arrow1.SetActive(true);
        arrow2.SetActive(true);
        arrow3.SetActive(true);
        arrow4.SetActive(true);
        arrow5.SetActive(true);
    }

    IEnumerator WaitBeforeShown()
    {
        yield return new WaitForSeconds(10.7f);

        arrow1.SetActive(true);
        arrow2.SetActive(true);
        arrow3.SetActive(true);
        arrow4.SetActive(true);
        arrow5.SetActive(true);
    }
}
