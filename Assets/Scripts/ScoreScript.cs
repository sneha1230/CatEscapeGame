using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;

    public int score = 0;
    public int highscore = 0;
    public int High;
    public static ScoreScript scoreInstance;
    private void Awake()
    {
        scoreInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void IncrementScore()
    {
        score++;
        ScoreText.text = "Score : " + score;
        if (score > highscore)
        {
            High = score;
            highscore = score;
        }
        else
        {
            High = highscore;
        }
    }
}
