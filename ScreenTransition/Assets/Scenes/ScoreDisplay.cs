using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreDisplay : MonoBehaviour
{
    
    public Text ScoreText;//テキスト変数

    void Start()
    {
        ScoreText.text = string.Format("Score:{0}", Transition.score);
    }

}