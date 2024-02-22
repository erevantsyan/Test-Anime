using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestQv : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    // Start is called before the first frame update
    void Start()
    {
        ShowAdv();
    }

    // Общий
    public void TestAll(){
        SceneManager.LoadScene(2);
    }

    // Магическая битва
    public void TestJK(){
        SceneManager.LoadScene(27);
    }

    // Атака титанов
    public void TestSK(){
        SceneManager.LoadScene(47);
    }

    // ДжоДжо
    public void TestJJ(){
        SceneManager.LoadScene(37);
    }

    //Наруто
    public void TestN(){
        SceneManager.LoadScene(57);
    }

    // Клинок, рассекающий демонов
    public void TestKY(){
        SceneManager.LoadScene(67);
    }

    // Блич
    public void TestB(){
        SceneManager.LoadScene(77);
    }

    // фото
    public void TestPH(){
        SceneManager.LoadScene(87);
    }
}
