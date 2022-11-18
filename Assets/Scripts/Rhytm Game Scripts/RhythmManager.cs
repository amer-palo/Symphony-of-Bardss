using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class RhythmManager : MonoBehaviour
{
    public AudioSource theMusic;
    public AudioSource audioBehaviour;
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

    public float totalNotes;
    public float notesHit;
    public float notesMissed;

    public GameObject resultsScreen;
    public TextMeshProUGUI percentHitText,notesHitText, notesMissedText, rankText, finalScoreText;

    void Start ()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;
        totalNotes = FindObjectsOfType<NoteObject>().Length;
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
          else
          {
               if(!theMusic.isPlaying && !resultsScreen.activeInHierarchy)
               {
                resultsScreen.SetActive(true);

                notesHitText.text = "" + notesHit;
                notesMissedText.text = "" + notesMissed;

                float totalHit = notesHit;
                float percentHit = (totalHit / totalNotes) * 100f;

                percentHitText.text = percentHit.ToString("F1") + "%";

                string rankVal = "F";

                 if(percentHit > 40)
                 {
                    rankVal = "D";

                    if(percentHit > 55)
                    {
                        rankVal = "C";

                        if(percentHit > 70)
                        {
                            rankVal = "B";

                             if(percentHit > 85)
                             {

                              rankVal = "A";

                              if(percentHit > 95)
                              {
                                  rankVal = "S";
                              }

                             }    

                        }
                    }
                 }

                rankText.text = rankVal;

                finalScoreText.text = currentScore.ToString();
               
               }
                
          }
        
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");
        audioBehaviour.time = 0.5f;
        audioBehaviour.Play();

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

        notesHit++;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");

        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "Multiplier x" + currentMultiplier;

        notesMissed++;
    }

    public void LoadTavern()
    {
        SceneManager.LoadScene("Tavern");
    }
}
