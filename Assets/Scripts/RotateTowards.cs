using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowards : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {              
        Quaternion rotation = Quaternion.LookRotation(player.position);
        rotation *= Quaternion.Euler(90,0,0);    
        transform.rotation = Quaternion.Lerp(transform.rotation,rotation, speed * Time.deltaTime);
    }
}
