using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private Rigidbody rig;
    private float setX;
    private float setZ;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        setX = Random.Range(LevelCreator.Instance.levelBounds.left + LevelCreator.Instance.templatesSize/2,
            LevelCreator.Instance.levelBounds.right - LevelCreator.Instance.templatesSize / 2);
        setZ= Random.Range(LevelCreator.Instance.levelBounds.top + LevelCreator.Instance.templatesSize / 2,
            LevelCreator.Instance.levelBounds.bottom - LevelCreator.Instance.templatesSize / 2);
        transform.position = new Vector3(setX, 0f, setZ);
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
