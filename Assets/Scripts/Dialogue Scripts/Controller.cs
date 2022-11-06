using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] Sprite newSprite;
    [SerializeField] Sprite newSprite2;
    [SerializeField] Sprite newSprite3;
    [SerializeField] Sprite newSprite4;
    [SerializeField] Sprite newSprite5;

    SpriteRenderer myspriteRenderer;

    private const float MOVE_SPEED = 5f;

    [SerializeField] private LayerMask dashLayerMask;


    private Rigidbody2D rigidbody2D;
    private Vector3 moveDir;
    private bool isDashButtonDown;

    void Start()
    {
        myspriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Awake()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
            myspriteRenderer.sprite = newSprite3;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
            myspriteRenderer.sprite = newSprite4;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
            myspriteRenderer.sprite = newSprite;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
            myspriteRenderer.sprite = newSprite2;
        }
        if (Input.GetKey(KeyCode.None))
        {
            myspriteRenderer.sprite = newSprite5;
        }

        moveDir = new Vector3(moveX, moveY).normalized;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDashButtonDown = true;
        }
    }

    private void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        rigidbody2D.velocity = moveDir * MOVE_SPEED;

        if (isDashButtonDown)
        {
            float dashAmount = 1f;
            Vector3 dashPosition = transform.position + moveDir * dashAmount;

            RaycastHit2D raycastHit2d = Physics2D.Raycast(transform.position, moveDir, dashAmount, dashLayerMask);
            if (raycastHit2d.collider != null)
            {
                dashPosition = raycastHit2d.point;
            }



            rigidbody2D.MovePosition(dashPosition);
            isDashButtonDown = false;
        }
    }
}
