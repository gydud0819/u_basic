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
        // �ڱ� �ڽ����κ��� �ڽ��� �˻��Ͽ� ���� ���� �߰��� ������Ʈ�� ��ȯ�Ѵ�. 
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
