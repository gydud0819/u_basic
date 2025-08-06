using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var Life = collision.GetComponent<PlayerEntity>();      // var�� Ÿ�� �߷����ִ� ��
            Life.OnLifeUpdated(-1);
            
            // SavePoint�� ���ư��Բ� �����ϱ� 
           //GameOverPanel.SetActive(true);
        }
    }
}
