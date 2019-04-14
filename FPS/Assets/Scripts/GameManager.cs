using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    private static GameManager instance;
    private int destroyedTraps;

    public static GameManager Instance
    {
        get{return instance;}
    }

    public int Score
    {
        get { return score; }
    }

    public int DestroyedTraps
    {
        get { return destroyedTraps; }
    }

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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int s)
    {
        score += s;
    }

    public void AddTrap()
    {
        destroyedTraps++;
    }
}
