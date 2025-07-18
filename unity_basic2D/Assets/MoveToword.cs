using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToword : MonoBehaviour
{
    [SerializeField] private Transform target;


    [SerializeField] private float moveSpeed = 1.5f;
    [SerializeField] private Vector3 startVector;


    // 변수의 데이터를 넣어줘야한다.
    // 데이터의 초기화가 필요하다.

    // Start is called before the first frame update
    void Start()
    {
        //target = transform;
        // _tr공간 : transform에 저장된 데이터를 _tr에 저장하라는 의미 

        transform.position = transform.position + startVector;

        // 이동하는 방향만 표현해주는 방법 (벡터의 정규화)
        startVector = startVector.normalized;

        // 방향 이동 코드 (두 벡터를 뺄때 뒤에 있는 포지션이 시작위치, 앞의 포지션이 목표위치이다)
        startVector = (target.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += startVector * moveSpeed * Time.deltaTime;
    }
}
