using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (/*collision.gameObject.tag == "Trap"*/collision.rigidbody)
        {
            collision.rigidbody.AddForce(transform.forward * -1 * 500, ForceMode.Impulse);
            Character character;
            if(character=collision.gameObject.GetComponent<Character>())
            {
                character.TakeDamage(50);
                Debug.Log("health" + character.Health);
            }
        }
    }
}
