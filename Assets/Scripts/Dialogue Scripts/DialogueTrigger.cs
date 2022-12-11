using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    private bool playerInRange;

    [Header("Ink JSON")]

    [SerializeField] private TextAsset inkJSON;
    [SerializeField] private TextAsset inkJSON2;
    [SerializeField] private TextAsset BromInkJSON2;

    [SerializeField] public GameObject character;

    SpriteRenderer sprite;

   public bool interaction1 = false;

   

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        character.SetActive(false);
        

    }
    public void Start()
    {
        sprite = GetComponentInParent<SpriteRenderer>();
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if (InputManager.GetInstance().GetInteractPressed())
            {
                DialogueManager.GetInstance().NPC = character;
                
                Debug.Log("character Active");
                if (interaction1 == false)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                    interaction1 = true;
                }
                else if (interaction1 == true)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON2);
                    interaction1 = false;
                }
                else if (interaction1 == true && CharacterController2D.GetInstance().hasKeys == true)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(BromInkJSON2);
                    interaction1 = false;
                }
               

            }
        }
        else
            visualCue.SetActive(false);
            
        if (DialogueManager.GetInstance().bardSpeak == true)
        {
            
            sprite.color = new Color(255, 255, 255, 127);
        }
        else
            sprite.color = new Color(255, 255, 255, 255);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
   
}
