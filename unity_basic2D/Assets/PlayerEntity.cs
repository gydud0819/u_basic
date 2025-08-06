using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    // �÷��̾� ������� �ڵ�
    [SerializeField] RunTimeUI runtimeUI;       // Ÿ Ŭ�������� ������ �� 
    [Header("Life")]
    [SerializeField] int currentLife;
    [SerializeField] int maxLife = 5;
    [Header("Coin")]
    [SerializeField] int currentCoin;
    [SerializeField] int maxCoinForlife;
    

    // ������ ������ �� ���� ����� �ִ� ������� �����ϰų� �������� �����Ѵ�. 

    private void Start()
    {
        currentLife = maxLife / 2;  // ���� ����� �ִ� ������� ����
        currentCoin = 0;        // ������ 0���� �ʱ�ȭ
        OnLifeUpdated(0);
        OnCoinUpdated(currentCoin);
    }

    public void OnLifeUpdated(int amount)
    {
        currentLife += amount;      // ���� ����� ũ�� �����ϱ� 

        if (currentLife > maxLife)  // ���� ����� �ִ� ��������� �Ѿ�� 
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
            currentCoin = maxCoinForlife;       // 99������ 10���� ������ 109�� �ǰ� �ű⼭ 100�� ���� 9
            OnLifeUpdated(currentLife + 1);
        }

        runtimeUI.OnCoinUpdated(currentCoin);
    }
}
