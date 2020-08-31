using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    public static int collectibleCount;
    public int highScore;

    public Text ScoreText;
    public Text HighScoreText;

    private void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore", highScore);
            HighScoreText.text = highScore.ToString();
        }

    }

    void Start()
    {
        collectibleCount = 0;
    }

    void Update()
    {
        ScoreText.text = collectibleCount.ToString();
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        if (collectibleCount > highScore)
            highScore = collectibleCount;

        ScoreText.text = collectibleCount.ToString();

        PlayerPrefs.SetInt("HighScore", highScore);

    }

    public void ResetScore()
    {
        collectibleCount = 0;
        HighScoreText.text = highScore.ToString();


    }
}
