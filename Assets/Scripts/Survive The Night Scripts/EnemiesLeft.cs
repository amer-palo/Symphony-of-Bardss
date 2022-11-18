using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class EnemiesLeft : MonoBehaviour
{

    GameObject[] enemies;
    public TextMeshProUGUI enemiesText;

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        enemiesText.text = "Enemies : " + enemies.Length.ToString();
    }

}