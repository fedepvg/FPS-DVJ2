using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    //[SerializeField]
    //private Button button;

    //void Awake()
    //{
    //    //if (button == null)
    //    //    button = GetComponent<Button>();

    //    //button.onClick.AddListener(OnClick);
    //}

    public void QuitGame()
    {
        Application.Quit();
    }
}
