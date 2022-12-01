using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeAnimation : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           FadeToLevel(1);
        }

    }

     public void FadeToLevel (int levelName)
     {
          animator.SetTrigger("FadeOut");
     }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Symphony of Bards");
    }
}