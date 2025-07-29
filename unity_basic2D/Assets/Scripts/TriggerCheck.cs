using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)     // c#에서 Collider2D* Collider2D& 처럼 안해도된다.
    {

        if (collision.CompareTag("Enemy"))       // tag의 이름이 Enemy일때만 실행하기 
        {
            Debug.Log("충돌한 물체의 이름 : " + collision.gameObject.name); // 충돌한 대상의 이름 + 데이터 타입 

            // 1. 충돌한 대상 파괴시키기
            Destroy(collision.gameObject);    // 성공 

            // 2. 충돌한 자기 자신을 파괴시키기
            //Destroy(gameObject);
        }

        if(collision.CompareTag("Player"))
        {
            Debug.Log("충돌한 물체의 이름 : " + collision.gameObject.name); // 충돌한 대상의 이름 + 데이터 타입 
        }
    }
}
