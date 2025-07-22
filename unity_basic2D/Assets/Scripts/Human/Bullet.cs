using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // �浹�� ��ü�� ���� ������Ʈ���� ������ ������ �� �ִ� ������Ʈ�� ������ �� ������ ���������� �ٲٱ�
            SpriteRenderer _sr = collision.GetComponent<SpriteRenderer>();
            if( _sr != null )
            {
                _sr.color = Color.red;
            }

            // SpriteRenderer _sr = collision.GetComponent<SpriteRenderer>(); �̰� ���� �ڵ�� �� ��
            //if (collision.TryGetComponent(out SpriteRenderer sr))
            //{
            //    sr.color = Color.red;
            //}
        }

    }
}
