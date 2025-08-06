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
            var Life = collision.GetComponent<PlayerEntity>();      // var는 타입 추론해주는 것
            Life.OnLifeUpdated(-1);
            
            // SavePoint로 돌아가게끔 구현하기 
           //GameOverPanel.SetActive(true);
        }
    }
}
