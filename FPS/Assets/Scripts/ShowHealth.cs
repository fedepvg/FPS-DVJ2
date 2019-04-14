using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHealth : MonoBehaviour
{
    int Health;
    Text uiHealth;
    [SerializeField]
    private Character character;

    // Start is called before the first frame update
    void Start()
    {
        uiHealth = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Health = character.Health;
        uiHealth.text = "Health: " + Health.ToString() + "\n"+"Enemies Killed: " + GameManager.Instance.DestroyedTraps;
    }
}
