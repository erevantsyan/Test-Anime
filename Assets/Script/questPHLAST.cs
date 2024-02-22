using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class questPHLAST : MonoBehaviour
{
    [SerializeField] private int sec = 0;
    [SerializeField] private int delta = 1;
    public TMP_Text textTime;

    public void TrueAnswer(){
        SceneManager.LoadScene(1);
    }

    public void FalseAnswer(){
        StaticResult.ResultAnswer -= 6.25f;
        SceneManager.LoadScene(1);
    }

    private void Start()
    {
        StartCoroutine(ITimer());
    }

    IEnumerator ITimer()
    {
        while (true)
        {
            sec += delta;
            textTime.text = sec + "";
            if (sec == 10)
            {
                sec = 0;
                StaticResult.ResultAnswer -= 6.25f;
                SceneManager.LoadScene(1);
            }
            yield return new WaitForSeconds(1);
        }
    }
}
