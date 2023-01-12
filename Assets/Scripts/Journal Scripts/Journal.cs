using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public GameObject journal;

    public GameObject BromText1;
    public GameObject BromText2;
    public GameObject BromText3;

    public GameObject AgathaText1;
    public GameObject AgathaText2;
    public GameObject AgathaText3;

    public GameObject JonText1;
    public GameObject JonText2;
    public GameObject JonText3;

    public GameObject AdenText1;
    public GameObject AdenText2;
    public GameObject AdenText3;

    public ItemSlot slot;
    public ItemSlot slot2;
    public ItemSlot slot3;


    public GameObject AgathaPanel;
    public GameObject BromPanel;
    public GameObject JonPanel;
    public GameObject AdenPanel;



    public bool agatha = false;
    public bool brom = false;
    public bool aden = false;
    public bool jon = false;

    public GameObject menuButton;
    public GameObject pauseMenu;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        AgathaArchive();
        BromArchive();
        AdenArchive();
        JonArchive();
    }





    public void LoadArchives()
    {
        AgathaPanel.SetActive(true);
        agatha = true;
        menuButton.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void NextArchive()
    {
        if(agatha == true)
        {
            AgathaPanel.SetActive(false);
            agatha = false;
            BromPanel.SetActive(true);
            brom = true;
        }
        else if (brom == true)
        {
            BromPanel.SetActive(false);
            brom = false;
            JonPanel.SetActive(true);
            jon = true;
        }
        else if (jon == true)
        {
            JonPanel.SetActive(false);
            jon = false;
            AdenPanel.SetActive(true);
            aden = true;
        }
    }
    public void PreviousArchive()
    {
        if (aden == true)
        {
            AdenPanel.SetActive(false);
            aden = false;
            JonPanel.SetActive(true);
            jon = true;
        }
        else if (jon == true)
        {
            JonPanel.SetActive(false);
            jon = false;
            BromPanel.SetActive(true);
            brom = true;
        }
        else if (brom == true)
        {
            BromPanel.SetActive(false);
            brom = false;
            AgathaPanel.SetActive(true);
            agatha = true;
        }
    }


    public void Exit()
    {
        journal.SetActive(false);
    }

    public void AgathaArchive()
    {
        if (slot.option1.tag == "Agatha")

        {
            AgathaText1 = slot.option1;
        }
        if (slot2.option2.tag == "Agatha")
        {
            AgathaText2 = slot.option2;
        }
        if (slot3.option3.tag == "Agatha")
        {
            AgathaText3 = slot.option3;
        }
    }
    public void BromArchive()
    {
        if (slot.option1.tag == "Brom")
        {
            BromText1 = slot.option1;
        }
        if (slot2.option2.tag == "Brom")
        {
            BromText2 = slot.option2;
        }
        if (slot3.option3.tag == "Brom")
        {
            BromText3 = slot.option3;
        }
    }
    public void AdenArchive()
    {
        if (slot.option1.tag == "Aden")
        {
            AdenText1 = slot.option1;
        }
        if (slot2.option2.tag == "Aden")
        {
            AdenText2 = slot.option2;
        }
        if (slot3.option3.tag == "Aden")
        {
            AdenText3 = slot.option3;
        }
    }
    public void JonArchive()
    {
        if (slot.option1.tag == "Jon")
        {
            JonText1 = slot.option1;
        }
        if (slot2.option2.tag == "Jon")
        {
            JonText2 = slot.option2;
        }
        if (slot3.option3.tag == "Jon")
        {
            JonText3 = slot.option3;
        }
    }
}
