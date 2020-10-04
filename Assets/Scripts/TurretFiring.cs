using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFiring : MonoBehaviour
{
    public GameObject OriginalBullet;
    float Timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 2f)
        {
            GameObject CloneBullet;
            CloneBullet = Instantiate(OriginalBullet, transform.position, transform.rotation);
            Timer = 0f;
        }
        
    }
}
