using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButtonContainer : MonoBehaviour
{
    // 4���� ��ư�� ���ԵǾ� �ִ�. (����, Ʃ�丮��, �ɼ�, ������)
    public void ButtonStart()
    {
        Debug.Log("���� �����ϱ�");       // Ȯ�ο� �α� 

        SceneManager.LoadScene(1);
    }

    public void ButtonTutorial(GameObject tut)
    {
        Debug.Log("Ʃ�丮�� �ȳ��� �б�");

        tut.SetActive(true);     // �ܺο��� �����;��ϱ��� 
    }

    public void ButtonOption()
    {
        Debug.Log("ȯ�漳������ ����");
    }

    public void ButtonExit()
    {
        Debug.Log("���� �����ϱ�");

        Application.Quit();     // ���� �����ε� ��� ����Ƽ�� ������ �ȵ�


#if UNITY_EDITOR                // �̰� ����� ����Ƽ ������ ���ᰡ �ȴ�
        EditorApplication.isPlaying = false;
#endif
    }

}
