using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;

    public const string highScoreKey = "HighScore";

    private float score;

    public static string HighScoreKey => highScoreKey;


    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime*scoreMultiplier;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()
    {
        int currentHighscore = PlayerPrefs.GetInt("HighScore",0);

        if(score>currentHighscore)
        {
            PlayerPrefs.SetInt(HighScoreKey,Mathf.FloorToInt(score));
        }
    }
}
