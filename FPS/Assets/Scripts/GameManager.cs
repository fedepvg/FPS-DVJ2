using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;
    private static GameManager instance;
    private int destroyedTraps;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int s)
    {
        score += s;
    }

    public void ResetScore()
    {
        score = 0;
        destroyedTraps = 0;
    }

    public void AddTrap()
    {
        destroyedTraps++;
    }

    public static GameManager Instance
    {
        get { return instance; }
    }

    public int Score
    {
        get { return score; }
    }

    public int DestroyedTraps
    {
        get { return destroyedTraps; }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("EndGameScene");
    }
}
