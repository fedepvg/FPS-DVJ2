using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainScene : MonoBehaviour
{
    int health;
    int destroyedTraps;
    [SerializeField]
    private Text healthText;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Character character;

    // Update is called once per frame
    void Update()
    {
        if (health != character.Health)
        {
            health = character.Health;
            if(healthText)
                healthText.text = "Health: " + health.ToString();
        }
        if (destroyedTraps != GameManager.Instance.DestroyedTraps)
        {
            destroyedTraps = GameManager.Instance.DestroyedTraps;
            if(scoreText)
                scoreText.text = "Enemies Killed: " + GameManager.Instance.DestroyedTraps.ToString();
        }else if(destroyedTraps==0)
        {
            if (scoreText)
                scoreText.text = "Enemies Killed: " + GameManager.Instance.DestroyedTraps.ToString();
        }
    }
}
