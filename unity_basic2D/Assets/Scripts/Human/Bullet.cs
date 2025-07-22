using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // 충돌한 물체의 게임 오브젝트에서 색상을 변경할 수 있는 컴포넌트가 있으면 그 색깔을 빨간색으로 바꾸기
            SpriteRenderer _sr = collision.GetComponent<SpriteRenderer>();
            if( _sr != null )
            {
                _sr.color = Color.red;
            }

            // SpriteRenderer _sr = collision.GetComponent<SpriteRenderer>(); 이게 밑의 코드로 들어간 것
            //if (collision.TryGetComponent(out SpriteRenderer sr))
            //{
            //    sr.color = Color.red;
            //}
        }

    }
}
