using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    public float damage;
    public GameObject blast;
    
    void Start()
    {
        rb.velocity = transform.right * speed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy Attacked");
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(damage);
        }

        Destroy(blast);
    }

}
