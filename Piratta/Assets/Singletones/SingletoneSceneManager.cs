using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletoneSceneManager : MonoBehaviour
{
    public int PreviousSceneNumber;
    public static SingletoneSceneManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
