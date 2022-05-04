using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDifficultyChange(TMPro.TMP_Dropdown sender)
    {
        SettingsManager.Instance.Difficulty = sender.value;
        Debug.Log($"Dropdown value: {sender.value}");
    }

    public void OnOk()
    {
        int index = SingletoneSceneManager.Instance.PreviousSceneNumber;
        SceneManager.LoadScene(index);
    }
}
