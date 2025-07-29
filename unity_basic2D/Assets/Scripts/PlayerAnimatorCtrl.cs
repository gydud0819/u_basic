using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimatorCtrl : MonoBehaviour
{
    // Animator Component 가져와서 실행하는 함수 만들기
    private Animator animator;      // Start? Awake? 
    private void Awake()    // Awake 맞나 
    {
        animator = GetComponent<Animator>();
    }

    public void PlayerMoveAnimation()
    {
        PlayBoolAnimation("IsMove", true);
        PlayBoolAnimation("IsTurn", false);
    }

    public void PlayerTurnAnimation()
    {
        PlayBoolAnimation("IsMove", false);
        PlayBoolAnimation("IsTurn", true);
    }

    public void PlayBoolAnimation(string paraName, bool enable)
    {
        animator.SetBool(paraName, enable);
    }

    // PlayerHandler에 PlayerAnimatorCtrl 클래스를 참조할 수 있도록 연결하기
    
    // PlayerHandler에서 PlayerAnimatorCtrl 
}
