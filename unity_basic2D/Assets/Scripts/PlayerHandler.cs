using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed = 2.0f;

    [SerializeField] private KeyCode Jumpkey = KeyCode.Space;
    [SerializeField] private float jumpPower = 3.0f;

    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundDistance = 1.2f;

    private PlayerAnimatorCtrl playerAnimatorCtrl;
    private void Awake()
    {
        rigidbody2D.GetComponent<Rigidbody2D>();
        playerAnimatorCtrl.GetComponent<PlayerAnimatorCtrl>();
    }

    private void Start()
    {
        Setup();
        rigidbody2D.velocity = new Vector2(0, 0);       // 중력을 받기 때문에 이걸로 점프기능 구현 가능하다. (y 좌표는 점프, x는 좌우이동 (x가 마찰력) )
    }

    private void Setup()
    {
        rigidbody2D.freezeRotation = true;
    }


    private void Update()
    {
        // 코드 작성 후 함수로 추출하기 (테스트 하고싶을 때)
        // 코드가 완성이 되면 함수로 추출하기 

        // 1. 플레이어의 입력 받기 ex) A, D 또는 <-, -> 로 입력 받아서 x좌표 변경하기
        // 2. rigidbody.velocity 변경해서 이동 구현하기




        Move();     // c# 단축키 : ctrl+. = 메소드 생성
        Jump();
    }

    private void Jump()
    {
        // 점프 조건 : if
        if (CanJump())
        {
            // 숫자 5를 멤버 변수의 점프크기(jumpPower)로 표현하기
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpPower);
        }
        Debug.DrawRay(transform.position, Vector3.down * 1.2f, Color.red);
    }

    private bool CanJump()
    {
        return Input.GetKeyDown(Jumpkey) && GroundCheck();
    }

    private bool GroundCheck()      // 바닥(땅인지 확인하는 함수)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.2f, groundLayer);
        return hit.collider != null;
        
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        //Debug.Log($"horizontal의 값 : {horizontal}, {horizontal} ");      // 문자열 출력할때 shift+4 누르면 작성하기 간결해짐)
        //Debug.Log($"jump의 값 : {jump}, {jump} ");      // 문자열 출력할때 shift+4 누르면 작성하기 간결해짐)

        // 위에있는 horizontal을 이용해서 vector2의 x값을 변경하는 코드 만들기
        // 멤버 변수로 이동 속도 변수를 추가해서 vector의 현재 크기에 속도를 곱한 값으로 이동하도록 코드 만들기
        if (horizontal==0)
        {
            playerAnimatorCtrl.PlayBoolAnimation("IsMove", true);
            playerAnimatorCtrl.PlayBoolAnimation("IsTurn", false); 
        }
        else
        {
            playerAnimatorCtrl.PlayBoolAnimation("IsMove", false);
            playerAnimatorCtrl.PlayBoolAnimation("IsTurn", true);
        }

        rigidbody2D.velocity = new Vector2((horizontal * moveSpeed), rigidbody2D.velocity.y);
    }
}
