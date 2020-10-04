using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDirection : MonoBehaviour
{
    public GameObject Player;
    public float BulletSpeed = 20;   
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Aim");
        transform.LookAt(Player.transform.position);
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.forward * BulletSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
