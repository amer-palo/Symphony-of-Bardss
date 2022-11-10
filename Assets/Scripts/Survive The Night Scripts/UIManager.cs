using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject deathUI;

    public void ToggleDeathUI()
    {
        deathUI.SetActive(!deathUI.activeSelf);
    }
}
