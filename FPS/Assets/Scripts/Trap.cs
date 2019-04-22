using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private Rigidbody rig;
    private float setX;
    private float setZ;
    public int damage = 50;
    public float trapImpulse = 500;
    private LevelCreator level;

    void Awake()
    {
        rig = GetComponent<Rigidbody>();
        level = LevelCreator.Instance;
    }

    private void OnEnable()
    {
        setZ= Random.Range(level.levelBounds.top + level.templatesSize / 2, level.levelBounds.bottom - level.templatesSize / 2);
        setX = Random.Range(level.levelBounds.left + level.templatesSize/2, level.levelBounds.right - level.templatesSize / 2);
        transform.position = new Vector3(setX, 0f, setZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            Character character;
            if(character=collision.gameObject.GetComponent<Character>())
            {
                character.TakeDamage(damage,trapImpulse);
                Debug.Log("health" + character.Health);
            }
        }
    }
}
