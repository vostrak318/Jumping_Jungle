using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    GameObject menu;

    public void Play()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;

    }
    public void Settings()
    {
        SceneManager.LoadScene("Set");
        Time.timeScale = 1;

    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
