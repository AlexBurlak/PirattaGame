using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OpenSettings()
    {
        SingletoneSceneManager.Instance.PreviousSceneNumber = 0;
        SceneManager.LoadScene(1);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Awake()
    {
        Debug.Log($"Difficulty level: {SettingsManager.Instance.Difficulty}");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
