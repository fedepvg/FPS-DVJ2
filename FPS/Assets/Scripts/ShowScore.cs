using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    int finalScore;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score =GetComponent<Text>();
        finalScore = GameManager.Instance.Score;
    }

    // Update is called once per frame
    void Update()
    {
        score.text ="Score: "+finalScore.ToString()+"       Enemies Killed: "+ GameManager.Instance.DestroyedTraps;
    }
}
