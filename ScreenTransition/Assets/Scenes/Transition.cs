using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Transition : MonoBehaviour
{
    //点数を結果画面に持っていくためのstatic変数
    static public int score = 1000;

    public void PushGoToMainButton()
    {
        SceneManager.LoadScene("Main");
    }
    public void PushGoToResultButton100()
    {
        score = 100;
        SceneManager.LoadScene("Result");
    }

    public void PushGoToResultButton1000()
    {
        score = 1000;
        SceneManager.LoadScene("Result");
    }

    public void PushGoToTitleButton()
    {
        score = 0;
        SceneManager.LoadScene("Title");
    }
}