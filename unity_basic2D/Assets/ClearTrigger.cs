using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTrigger : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 

            // SavePoint�� ���ư��Բ� �����ϱ� 
            GameOverPanel.SetActive(true);
        }
    }
}
