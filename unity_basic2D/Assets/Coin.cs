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
            var Coin = collision.GetComponent<PlayerEntity>();      // var�� Ÿ�� �߷����ִ� ��
            Coin.OnCoinUpdated(coinAmount);
            Destroy(gameObject);

            // SavePoint�� ���ư��Բ� �����ϱ� 
            //GameOverPanel.SetActive(true);
        }
    }
}
