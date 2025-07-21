using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToword : MonoBehaviour
{
    [SerializeField] private Transform target;


    [SerializeField] private float moveSpeed = 1.5f;
    [SerializeField] private Vector3 startVector;


    // ������ �����͸� �־�����Ѵ�.
    // �������� �ʱ�ȭ�� �ʿ��ϴ�.

    // Start is called before the first frame update
    void Start()
    {
        //target = transform;
        // _tr���� : transform�� ����� �����͸� _tr�� �����϶�� �ǹ� 

        transform.position = transform.position + startVector;

        // �̵��ϴ� ���⸸ ǥ�����ִ� ��� (������ ����ȭ)
        startVector = startVector.normalized;

        // ���� �̵� �ڵ� (�� ���͸� ���� �ڿ� �ִ� �������� ������ġ, ���� �������� ��ǥ��ġ�̴�)
        startVector = (target.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += startVector * moveSpeed * Time.deltaTime;
    }
}
