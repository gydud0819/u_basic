using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtonContainer : MonoBehaviour
{
    public void ButtonRestart()
    {
        Debug.Log("����� �ϱ�");
        SceneManager.LoadScene(1);
    }

    public void ButtonTitle()
    {
        Debug.Log("Ÿ��Ʋ�� ���ư���");
        SceneManager.LoadScene(0);
    }

    public void ButtonExit()
    {
        Debug.Log("�����ϱ�");
    }
}
