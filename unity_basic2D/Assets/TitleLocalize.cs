using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using UnityEngine.UI;

public class TitleLocalize : MonoBehaviour
{
    TextMeshProUGUI titleText;      // 폰트관련 클래스

    // string 타입 선언하기
    [SerializeField] string englishTitle;
    [SerializeField] string koreanTitle;

    public bool IsKorean = true;        // 시작값이 한글인지 

    private void Awake()
    {
        titleText = GetComponent<TextMeshProUGUI>();

    }

    private void Start()
    {
        //titleText.text = englishTitle;      // 텍스틀 직접 바꿔주는 코드
        if (IsKorean)
            titleText.SetText(koreanTitle);
        else
            titleText.SetText(englishTitle);
        
    }
}
