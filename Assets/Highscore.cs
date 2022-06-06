using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    public int GetHighscore()
    {
        return PlayerPrefs.GetInt("highscore", 0);
    }

    public bool IsHighscoreBeaten()
    {
        int result = PlayerPrefs.GetInt("highscore_beaten", 0);
        return result > 0;
    }

    public void SetHighscore(int highscore)
    {
        int currentHighscore = GetHighscore();
        PlayerPrefs.SetInt("highscore_beaten", highscore > currentHighscore ? 1 : 0);

        if (highscore > currentHighscore)
        {
            PlayerPrefs.SetInt("highscore", highscore);
            Debug.Log("New highscore: " + highscore);
        }
    }
}
