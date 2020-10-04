using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFiring : MonoBehaviour
{
    public GameObject OriginalPlayerBullet;
    public AudioSource myAudio;
    float Timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && Timer >= 1f)
        {
            GameObject ClonePlayerBullet;
            ClonePlayerBullet = Instantiate(OriginalPlayerBullet, transform.position, Quaternion.identity);
            Timer = 0f;
            myAudio.Play();
        }
    }
}
