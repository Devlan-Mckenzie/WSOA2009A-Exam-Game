using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletDirection : MonoBehaviour
{
    public GameObject TurretCentre;
    public float PlayerBulletSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        TurretCentre = GameObject.FindWithTag("TurretCentre");
        transform.LookAt(TurretCentre.transform.position);
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.forward * PlayerBulletSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
