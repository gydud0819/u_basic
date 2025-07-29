using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)     // c#���� Collider2D* Collider2D& ó�� ���ص��ȴ�.
    {

        if (collision.CompareTag("Enemy"))       // tag�� �̸��� Enemy�϶��� �����ϱ� 
        {
            Debug.Log("�浹�� ��ü�� �̸� : " + collision.gameObject.name); // �浹�� ����� �̸� + ������ Ÿ�� 

            // 1. �浹�� ��� �ı���Ű��
            Destroy(collision.gameObject);    // ���� 

            // 2. �浹�� �ڱ� �ڽ��� �ı���Ű��
            //Destroy(gameObject);
        }

        if(collision.CompareTag("Player"))
        {
            Debug.Log("�浹�� ��ü�� �̸� : " + collision.gameObject.name); // �浹�� ����� �̸� + ������ Ÿ�� 
        }
    }
}
