using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    // 플레이어 목숨관련 코드
    [SerializeField] RunTimeUI runtimeUI;       // 타 클래스에서 가져올 때 
    [Header("Life")]
    [SerializeField] int currentLife;
    [SerializeField] int maxLife = 5;
    [Header("Coin")]
    [SerializeField] int currentCoin;
    [SerializeField] int maxCoinForlife;
    

    // 게임을 시작할 때 현재 목숨을 최대 목숨으로 시작하거나 절반으로 시작한다. 

    private void Start()
    {
        currentLife = maxLife / 2;  // 현재 목숨을 최대 목숨으로 설정
        currentCoin = 0;        // 코인은 0으로 초기화
        OnLifeUpdated(0);
        OnCoinUpdated(currentCoin);
    }

    public void OnLifeUpdated(int amount)
    {
        currentLife += amount;      // 현재 목숨에 크기 전달하기 

        if (currentLife > maxLife)  // 현재 목숨이 최대 목숨개수를 넘어가면 
        {
            currentLife = maxLife;
        }

        runtimeUI.OnLifeUpdated(currentLife);
    }

    public void OnCoinUpdated(int amount)
    {
        currentCoin += amount;

        if (currentCoin > maxCoinForlife)
        {
            currentCoin = maxCoinForlife;       // 99개에서 10개를 먹으면 109가 되고 거기서 100을 빼면 9
            OnLifeUpdated(currentLife + 1);
        }

        runtimeUI.OnCoinUpdated(currentCoin);
    }
}
