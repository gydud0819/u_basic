using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using UnityEngine.UI;

public class TitleLocalize : MonoBehaviour
{
    TextMeshProUGUI titleText;      // ��Ʈ���� Ŭ����

    // string Ÿ�� �����ϱ�
    [SerializeField] string englishTitle;
    [SerializeField] string koreanTitle;

    public bool IsKorean = true;        // ���۰��� �ѱ����� 

    private void Awake()
    {
        titleText = GetComponent<TextMeshProUGUI>();

    }

    private void Start()
    {
        //titleText.text = englishTitle;      // �ؽ�Ʋ ���� �ٲ��ִ� �ڵ�
        if (IsKorean)
            titleText.SetText(koreanTitle);
        else
            titleText.SetText(englishTitle);
        
    }
}
