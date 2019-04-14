using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private int health = 100;
    private Rigidbody rig;

    private void OnEnable()
    {
        health = 100;
        GameManager.Instance.ResetScore();
    }

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0 || transform.position.y<-10)
        {
            GameManager.Instance.GameOver();
        }
    }

    public Rigidbody Rig
    {
        get { return rig; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public void TakeDamage(int d)
    {
        health -= d;
    }
}
