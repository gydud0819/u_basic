using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 도전과제 : Tag를 이용해서 선택한 게임오브젝트만 코드를 실행할 수 있도록 하기

public class CollsionCheck : MonoBehaviour
{
    // 용암에 들어온 상태
    public bool isLava;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "이 충돌했다.");
            Debug.Log("현재 용암에 빠졌다.");

            isLava = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "이 벗어났다.");
            Debug.Log("용암에서 빠져나왔다.");

            isLava = false;
        }
    }
}
