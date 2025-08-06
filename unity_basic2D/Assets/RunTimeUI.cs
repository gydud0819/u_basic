using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RunTimeUI : MonoBehaviour
{
    [Header("��� Life")]
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private Image lifeImage;
    [Header("���� Coin")]
    [SerializeField] private TextMeshProUGUI coinText;
    [Header("���� Score")]
    [SerializeField] private TextMeshProUGUI scoreText;
    private float timeValue = 60;
    [Header("�ð� Time")]
    [SerializeField] private TextMeshProUGUI timeText;


    public void OnLifeUpdated(int lifeCount)     // ����� ����Ǿ��� �� (���� �� ����)
    {
        lifeText.SetText($"x{lifeCount}");
    }

    public void OnCoinUpdated(int coinCount)
    {
        // ������ ������ ������ �� ���� �ֱ⿡ ���� ó�� ���ֱ� 
        coinText.SetText($"x{coinCount}");
    }

    public void OnScoreUpdated() 
    { 

    }

    public void OnTimeUpdated() 
    {
        timeText.SetText($"{timeValue}");
    }

    private void Update()
    {
        timeValue = Time.deltaTime;
        OnTimeUpdated();
    }
}
