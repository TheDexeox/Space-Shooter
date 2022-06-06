using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHighscore : MonoBehaviour
{
    public TMP_Text highscoreText;
    public Highscore highscore;

    void Start()
    {
        if (highscore.IsHighscoreBeaten())
        {
            highscoreText.text = "new highscore!\n" + highscore.GetHighscore();
        }
        else
        {
            highscoreText.text = "highscore\n" + highscore.GetHighscore();
        }

    }
}
