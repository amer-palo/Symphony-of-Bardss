using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState { Play, Talk, Other}
public enum Direction { Up, Down, Left, Right}
public class CharacterController2D : GameBehaviour
{
    Animator anim;

    private const float MOVE_SPEED = 4f;

    private static CharacterController2D instance;

    private Rigidbody2D rigidbody2D;
    private Vector3 moveDir;

    public PlayerState playerState;
    public Direction direction;
    public bool hasKeys = false;

    public Transform startPosition;

 
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        if (_Save.firstStart == 0)
        {
            transform.position = startPosition.position;
            _Save.firstStart = 1;
            Debug.Log("First Spawn");
        }
        else
        transform.position = _Save.LoadPosition();
    }
    private void Awake()
    {
        
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        if (_SC.gameState == GameState.Loading)
            return;


        float moveX = 0f;
        float moveY = 0f;
        if (playerState == PlayerState.Play && _SC.gameState == GameState.Play)
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveY = +1f;
                direction = Direction.Up;
                anim.SetInteger("Walk", 1);
                Debug.Log("Up");
            }
            else if (Input.GetKey(KeyCode.S))
            {
                moveY = -1f;
                direction = Direction.Down;
                anim.SetInteger("Walk", 2);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                moveX = -1f;
                direction = Direction.Left;
                anim.SetInteger("Walk", 3);
            }
            else if(Input.GetKey(KeyCode.D))
            {
                moveX = +1f;
                direction = Direction.Right;
                anim.SetInteger("Walk", 4);
            }
            else 
            {
                //Debug.Log("you are pressing nothing");
                anim.SetInteger("Walk", 0);
            }

            moveDir = new Vector3(moveX, moveY).normalized;
        }
        
    }
   
    public void ChangePlayerState(PlayerState state)
    {
        playerState = state;
        Debug.Log("PlayerState = " + playerState);
    }
    private void FixedUpdate()
    {
        rigidbody2D.velocity = moveDir * MOVE_SPEED;
    }

    public static CharacterController2D GetInstance()
    {
        return instance;
    }
}
