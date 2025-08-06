using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RunTimeUI : MonoBehaviour
{
    [Header("목숨 Life")]
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private Image lifeImage;
    [Header("동전 Coin")]
    [SerializeField] private TextMeshProUGUI coinText;
    [Header("점수 Score")]
    [SerializeField] private TextMeshProUGUI scoreText;
    private float timeValue = 60;
    [Header("시간 Time")]
    [SerializeField] private TextMeshProUGUI timeText;


    public void OnLifeUpdated(int lifeCount)     // 목숨이 변경되었을 때 (증가 및 감소)
    {
        lifeText.SetText($"x{lifeCount}");
    }

    public void OnCoinUpdated(int coinCount)
    {
        // 코인의 개수가 음수가 될 수도 있기에 예외 처리 해주기 
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
