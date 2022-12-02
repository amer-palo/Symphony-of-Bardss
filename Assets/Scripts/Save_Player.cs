using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Player : MonoBehaviour
{
    public float x, y, z;
    public float a, b, c;



    public void Start()
    {
        Save();
        Load();
    }

    public void Save()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z ;


        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
    }



    public void Load()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(x, y, z);
        transform.position = LoadPosition;
    }

    public void SaveOutside()
    {
        a = transform.position.x;
        b = transform.position.y;
        c = transform.position.z;


        PlayerPrefs.SetFloat("x", a);
        PlayerPrefs.SetFloat("y", b);
        PlayerPrefs.SetFloat("z", c);
    }



    public void LoadOutside()
    {
        a = PlayerPrefs.GetFloat("x");
        b = PlayerPrefs.GetFloat("y");
        c = PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(a, b, c);
        transform.position = LoadPosition;
    }
}
