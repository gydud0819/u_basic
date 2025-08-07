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

            // SavePoint로 돌아가게끔 구현하기 
            GameOverPanel.SetActive(true);
        }
    }
}
