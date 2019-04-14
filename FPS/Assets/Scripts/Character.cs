using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private int health = 100;
    private Rigidbody rig;

    public Rigidbody Rig
    {
        get { return rig; }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (/*collision.gameObject.tag == "Trap"*/collision.rigidbody)
    //    {
    //        rig.AddForce(transform.forward*-1*10000, ForceMode.Impulse);
    //    }
    //}
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

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
