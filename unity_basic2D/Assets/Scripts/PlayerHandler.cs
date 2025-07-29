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
        rigidbody2D.velocity = new Vector2(0, 0);       // �߷��� �ޱ� ������ �̰ɷ� ������� ���� �����ϴ�. (y ��ǥ�� ����, x�� �¿��̵� (x�� ������) )
    }

    private void Setup()
    {
        rigidbody2D.freezeRotation = true;
    }


    private void Update()
    {
        // �ڵ� �ۼ� �� �Լ��� �����ϱ� (�׽�Ʈ �ϰ���� ��)
        // �ڵ尡 �ϼ��� �Ǹ� �Լ��� �����ϱ� 

        // 1. �÷��̾��� �Է� �ޱ� ex) A, D �Ǵ� <-, -> �� �Է� �޾Ƽ� x��ǥ �����ϱ�
        // 2. rigidbody.velocity �����ؼ� �̵� �����ϱ�




        Move();     // c# ����Ű : ctrl+. = �޼ҵ� ����
        Jump();
    }

    private void Jump()
    {
        // ���� ���� : if
        if (CanJump())
        {
            // ���� 5�� ��� ������ ����ũ��(jumpPower)�� ǥ���ϱ�
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpPower);
        }
        Debug.DrawRay(transform.position, Vector3.down * 1.2f, Color.red);
    }

    private bool CanJump()
    {
        return Input.GetKeyDown(Jumpkey) && GroundCheck();
    }

    private bool GroundCheck()      // �ٴ�(������ Ȯ���ϴ� �Լ�)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.2f, groundLayer);
        return hit.collider != null;
        
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        //Debug.Log($"horizontal�� �� : {horizontal}, {horizontal} ");      // ���ڿ� ����Ҷ� shift+4 ������ �ۼ��ϱ� ��������)
        //Debug.Log($"jump�� �� : {jump}, {jump} ");      // ���ڿ� ����Ҷ� shift+4 ������ �ۼ��ϱ� ��������)

        // �����ִ� horizontal�� �̿��ؼ� vector2�� x���� �����ϴ� �ڵ� �����
        // ��� ������ �̵� �ӵ� ������ �߰��ؼ� vector�� ���� ũ�⿡ �ӵ��� ���� ������ �̵��ϵ��� �ڵ� �����
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
