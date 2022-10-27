using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RhythmManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static RhythmManager instance;

    public int currentScore;
    public int scorePerNote = 100;

   
    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;


    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI multiText;

    void Start ()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;
    }
    void Update ()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;
                
                theMusic.Play();    
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        multiText.text = "Multiplier x" + currentMultiplier;

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");

        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "Multiplier x" + currentMultiplier;
    }
}
