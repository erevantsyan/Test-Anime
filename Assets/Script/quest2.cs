using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class quest2 : MonoBehaviour
{

    [SerializeField] private int sec = 0;
    [SerializeField] private int delta = 1;
    public TMP_Text textTime;

    public void TrueAnswer(){
        var index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index + 1);
    }

    public void FalseAnswer(){
        StaticResult.ResultAnswer -= 10f;
        var index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index + 1);
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
                var index = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(index + 1);
                StaticResult.ResultAnswer -= 10f;
            }
            yield return new WaitForSeconds(1);
        }
    }
}
