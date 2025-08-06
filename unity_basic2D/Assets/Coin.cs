using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int coinAmount = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var Coin = collision.GetComponent<PlayerEntity>();      // var는 타입 추론해주는 것
            Coin.OnCoinUpdated(coinAmount);
            Destroy(gameObject);

            // SavePoint로 돌아가게끔 구현하기 
            //GameOverPanel.SetActive(true);
        }
    }
}
