using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matatrampas : MonoBehaviour
{
    public LayerMask raycastLayer;
    public float rayDistance = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.parent.position, transform.parent.forward, out hit, rayDistance, raycastLayer))
        {
            Debug.DrawRay(transform.parent.position, transform.parent.forward * rayDistance, Color.yellow);

            string layerHitted = LayerMask.LayerToName(hit.transform.gameObject.layer);

            if (layerHitted == "Trap")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.gameObject.SetActive(false);
                    GameManager.Instance.AddScore(100);
                    GameManager.Instance.AddTrap();
                    Debug.Log("Score" + GameManager.Instance.Score);
                    Debug.Log("Traps" + GameManager.Instance.DestroyedTraps);
                }
            }
        }
        else
        {
            Debug.DrawRay(transform.parent.position, transform.parent.forward * rayDistance, Color.white);
        }
    }
}
