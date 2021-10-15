using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOver;
    public ScoreManager scoreManager;

    void Start()
    {
        Time.timeScale = 1;
    }

   public void GameFail()
    {
        scoreManager.GameEnd();

        GameOver.SetActive(true);
        Time.timeScale = 1;
    }
}
