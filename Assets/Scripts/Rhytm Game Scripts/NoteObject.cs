using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    private bool obtained = false;

    public GameObject noteHiteBard;
    public GameObject noteMissedBard;
    public ParticleSystem particleSystem;

    void Start()
    {
        noteHiteBard.SetActive(true);
        noteMissedBard.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                obtained = true;
                gameObject.SetActive(false);

                RhythmManager.instance.NoteHit();
                obtained = true;
                noteMissedBard.SetActive(false);
                noteHiteBard.SetActive(true);
                particleSystem.Play();  
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            if (!obtained)
            {
                RhythmManager.instance.NoteMissed();
                noteHiteBard.SetActive(false);
                noteMissedBard.SetActive(true);
            }

            
        }
    }

}
