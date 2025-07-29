using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimatorCtrl : MonoBehaviour
{
    // Animator Component �����ͼ� �����ϴ� �Լ� �����
    private Animator animator;      // Start? Awake? 
    private void Awake()    // Awake �³� 
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

    // PlayerHandler�� PlayerAnimatorCtrl Ŭ������ ������ �� �ֵ��� �����ϱ�
    
    // PlayerHandler���� PlayerAnimatorCtrl 
}
