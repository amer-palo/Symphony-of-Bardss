using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public CharacterController2D characterController;

    bool CanFire = true;
    public Transform firePointUp;
    public Transform firePointDown;
    public Transform firePointLeft;
    public Transform firePointRight;

    public GameObject blastPrefab;
    
    public int reloadTime = 1;

    public void Update()
    {
        if (Input.GetMouseButton(0) && CanFire)
        {
            Blast();
        }
        
    }
    public void Blast()
    {
        if (characterController.direction == Direction.Up)
        {
            CanFire = false;

            Instantiate(blastPrefab, firePointUp.position, firePointUp.rotation);

            ResetFire();
            
        }
        if (characterController.direction == Direction.Down)
        {
            CanFire = false;

            Instantiate(blastPrefab, firePointDown.position, firePointDown.rotation);

            ResetFire();
           
        }
        if (characterController.direction == Direction.Left)
        {
            CanFire = false;

            Instantiate(blastPrefab, firePointLeft.position, firePointLeft.rotation);

            ResetFire();
            
        }
        if (characterController.direction == Direction.Right)
        {
            CanFire = false;

            Instantiate(blastPrefab, firePointRight.position, firePointRight.rotation);

            ResetFire();
            
        }
    }
    public void ResetFire()
    {
        Debug.Log("Reset");
        StartCoroutine(Delay());
       
        
        
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(reloadTime);
        CanFire = true;
        StopCoroutine(Delay());
    }
}

