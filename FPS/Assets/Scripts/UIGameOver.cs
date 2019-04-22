using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIGameOver : MonoBehaviour
{
    int finalScore;
    int finalDestroyedTraps;
    [SerializeField]
    Text scoreText;
    [SerializeField]
    Text enemiesKilledText;
    GameManager gm;

    void Awake()
    {
        if (!GameManager.Instance)
        {
            gm = new GameManager();
        }
        else
        {
            gm = GameManager.Instance;
        }
        finalScore = gm.Score;
        finalDestroyedTraps = gm.DestroyedTraps;
    }

    private void OnEnable()
    {
        if(scoreText)
            scoreText.text = "Score: " + finalScore.ToString();
        if(enemiesKilledText)
            enemiesKilledText.text = "Enemies Killed: " + finalDestroyedTraps;
    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
}
