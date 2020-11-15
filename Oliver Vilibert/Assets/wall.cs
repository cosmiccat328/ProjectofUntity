using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public int health;
    public GameObject explosion;
    // Start is called before the first frame update

    public void Takedamage()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
            GameObject f= Instantiate(explosion, transform.position, transform.rotation);
            Destroy(f, 6);
        }
    }
}








