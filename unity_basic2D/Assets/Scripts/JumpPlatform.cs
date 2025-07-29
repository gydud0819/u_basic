using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    // 1. Animator Component Awake �Լ����� �� �ʱ�ȭ �ϱ�
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        PlayTriggerAnimation("Start");
    }

    public void PlayTriggerAnimation(string paramName)
    {
        animator.SetTrigger(paramName);
    }

    private void Update()
    {
        // �浹 ������ �÷��̾ ������ ���� �����ϱ� 
       
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"));
    }
}
