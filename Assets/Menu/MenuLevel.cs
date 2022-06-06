using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevel : MonoBehaviour
{
    public string Menu;
    public void LoadNewLevel()
    {
        SceneManager.LoadScene(Menu);
    }
}

