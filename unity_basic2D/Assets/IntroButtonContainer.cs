using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButtonContainer : MonoBehaviour
{
    // 4개의 버튼이 포함되어 있다. (시작, 튜토리얼, 옵션, 나가기)
    public void ButtonStart()
    {
        Debug.Log("게임 시작하기");       // 확인용 로그 

        SceneManager.LoadScene(1);
    }

    public void ButtonTutorial(GameObject tut)
    {
        Debug.Log("튜토리얼 안내서 읽기");

        tut.SetActive(true);     // 외부에서 가져와야하구나 
    }

    public void ButtonOption()
    {
        Debug.Log("환경설정으로 들어가기");
    }

    public void ButtonExit()
    {
        Debug.Log("게임 종료하기");

        Application.Quit();     // 게임 종료인데 얘는 유니티에 적용이 안됨


#if UNITY_EDITOR                // 이걸 써줘야 유니티 내에서 종료가 된다
        EditorApplication.isPlaying = false;
#endif
    }

}
