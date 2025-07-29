using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������� : Tag�� �̿��ؼ� ������ ���ӿ�����Ʈ�� �ڵ带 ������ �� �ֵ��� �ϱ�

public class CollsionCheck : MonoBehaviour
{
    // ��Ͽ� ���� ����
    public bool isLava;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "�� �浹�ߴ�.");
            Debug.Log("���� ��Ͽ� ������.");

            isLava = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log(collision.gameObject.name + "�� �����.");
            Debug.Log("��Ͽ��� �������Դ�.");

            isLava = false;
        }
    }
}
