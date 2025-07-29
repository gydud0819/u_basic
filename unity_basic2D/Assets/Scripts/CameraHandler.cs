using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] private Transform target;    // ī�޶� ���� ��� 
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
        Debug.Log($"����� ���� ��ġ : {offset} ");

    }

    private void Update()
    {
        transform.position = target.position + offset;      // ī�޶��� ���� ��ġ���� ����� ��ġ�� ���Ѵ�?
    }
}
