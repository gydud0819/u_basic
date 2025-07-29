using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    // 1. Animator Component Awake 함수에서 값 초기화 하기
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
        // 충돌 영역에 플레이어가 들어왔을 때만 실행하기 
       
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"));
    }
}
