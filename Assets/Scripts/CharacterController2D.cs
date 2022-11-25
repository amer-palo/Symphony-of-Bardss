using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState { Play, Talk, Other}
public enum Direction { Up, Down, Left, Right}
public class CharacterController2D : MonoBehaviour
{
    [SerializeField] Sprite newSprite;
    [SerializeField] Sprite newSprite2;
    [SerializeField] Sprite newSprite3;
    [SerializeField] Sprite newSprite4;
    [SerializeField] Sprite newSprite5;

    //[SerializeField] Transform hand;

    SpriteRenderer myspriteRenderer;

    private const float MOVE_SPEED = 5f;

    [SerializeField] private LayerMask dashLayerMask;

    
    private Rigidbody2D rigidbody2D;
    private Vector3 moveDir;
    private bool isDashButtonDown;

    public PlayerState playerState;
    public Direction direction;


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
        if (playerState == PlayerState.Play)
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveY = +1f;
                myspriteRenderer.sprite = newSprite3;
                direction = Direction.Up;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveY = -1f;
                myspriteRenderer.sprite = newSprite4;
                direction = Direction.Down;
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveX = -1f;
                myspriteRenderer.sprite = newSprite;
                direction = Direction.Left;
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveX = +1f;
                myspriteRenderer.sprite = newSprite2;
                direction = Direction.Right;
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
        //RotateHand();
    }
   /* void RotateHand()
    {
        float angle = Utility.AngleTowardsMouse(hand.position);
        hand.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }*/
    public void ChangePlayerState(PlayerState state)
    {
        playerState = state;
        Debug.Log("PlayerState = " + playerState);
    }
    private void FixedUpdate()
    {
        rigidbody2D.velocity = moveDir * MOVE_SPEED;

       /* if (isDashButtonDown)
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
        }*/
    } 

    
}
