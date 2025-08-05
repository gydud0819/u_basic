using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtonContainer : MonoBehaviour
{
    public void ButtonRestart()
    {
        Debug.Log("재시작 하기");
        SceneManager.LoadScene(1);
    }

    public void ButtonTitle()
    {
        Debug.Log("타이틀로 돌아가기");
        SceneManager.LoadScene(0);
    }

    public void ButtonExit()
    {
        Debug.Log("종료하기");
    }
}
