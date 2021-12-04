using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneChanger : MonoBehaviour
{
    public string Scene1;
    public string Scene2;

    void Start()
    {
        SceneManager.LoadScene(Scene1);
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene("Options");
    }
   
    public void Exit()
    {
        Application.Quit();
    }
}
