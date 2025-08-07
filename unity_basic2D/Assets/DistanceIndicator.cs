using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceIndicator : MonoBehaviour
{
    [Header("플레이어와 목표 지점 연결하기")]
    [SerializeField] private Transform player;
    [SerializeField] private Transform target;
    [SerializeField] private Slider playerSlider;

    [Header("Enemy Slider")]
    [SerializeField] private Transform enemy;
    [SerializeField] private Slider enemySlider;

    private float playerStartX;
    private float enemyStartX;

    private void Start()
    {
        playerStartX = player.transform.position.x * -1;
    }
    public void SetPlayerValue(float value)     // 실수값으로 가져오기
    {   
        playerSlider.value = value;
    }

    public void SetEnemyValue(float value)
    {
        enemySlider.value = value;
    }

    private void Update()
    {
        float playerX = player.position.x + playerStartX;
        float targetX = target.position.x + playerStartX;
        float enemyX = enemy.position.x + enemyStartX;

        float sliderValue = playerX / targetX;
        float enemySilderValue = enemyX / targetX;
        SetPlayerValue(sliderValue);
        SetEnemyValue(enemySilderValue);


    }
}
