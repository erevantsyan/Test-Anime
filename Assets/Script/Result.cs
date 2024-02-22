using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{


    public TMP_Text textResult;
    // Start is called before the first frame update
    void Start()
    {
        if (StaticResult.ResultAnswer < 0)
        {
            StaticResult.ResultAnswer = 0;
        }
        if (StaticResult.ResultAnswer == 100f)
            textResult.text = StaticResult.ResultAnswer + " % - ты самый настоящий анимешник";
        if (StaticResult.ResultAnswer < 100f && StaticResult.ResultAnswer >= 60f)
            textResult.text = StaticResult.ResultAnswer + " % - хорошо знаешь аниме, но лучше подучить";
        if (StaticResult.ResultAnswer < 60f && StaticResult.ResultAnswer >= 20f)
            textResult.text = StaticResult.ResultAnswer + " % - иди смотри аниме";
        if (StaticResult.ResultAnswer < 20f)
            textResult.text = StaticResult.ResultAnswer + " % - позер";
    }

    public void RetryTest(){
        StaticResult.ResultAnswer = 100;
        SceneManager.LoadScene(0);
    }
}
