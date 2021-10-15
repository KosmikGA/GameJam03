using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    public int Score = 0;

    public float coins;


    // Start is called before the first frame update
    void Start()
    {
        coins = 0f;

        scoreText.text = Score.ToString() + "/5 Coins";
    }

    public void AddPoint()
    {
        coins += 1;
        scoreText.text = Score.ToString() + "/5 Coins";
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)coins + "/5 Coins";
    }

    public void GameEnd()
    {

    }
}
