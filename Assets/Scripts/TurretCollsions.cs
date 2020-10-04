using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TurretCollsions : MonoBehaviour
{
    public int Armor = 5;
    int damageTaken = 0;
    public Slider health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damageTaken >= Armor)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullets")
        {
            Destroy(collision.gameObject);
            damageTaken++;
            health.value = damageTaken;
        }
        Debug.Log(damageTaken);
    }    
}
