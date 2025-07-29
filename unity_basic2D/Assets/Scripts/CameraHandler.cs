using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] private Transform target;    // 카메라가 따라갈 대상 
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
        Debug.Log($"대상의 현재 위치 : {offset} ");

    }

    private void Update()
    {
        transform.position = target.position + offset;      // 카메라의 현재 위치에서 대상의 위치를 더한다?
    }
}
