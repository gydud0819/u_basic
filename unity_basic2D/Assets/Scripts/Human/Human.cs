using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private HumanShape[] allShpaes;
    private Arm arm;
    private Head head;
    private Body body;

    [SerializeField] private Leg[] legs;
    [SerializeField] private Color _color;
    [SerializeField] private int _SortingOrder = 0;

    private void Start()
    {
        // 자기 자신으로부터 자식을 검색하여 가장 먼저 발견한 컴포넌트를 반환한다. 
        allShpaes = GetComponentsInChildren<HumanShape>();
        arm = GetComponentInChildren<Arm>();
        legs = GetComponentsInChildren<Leg>();
        head = GetComponentInChildren<Head>();


        for (int i = 0; i < allShpaes.Length; i++)
        {
            allShpaes[i].SetRenderProperty(_color, _SortingOrder);
        }

        //arm.SetRenderProperty(_color, _SortingOrder);

    }

}
