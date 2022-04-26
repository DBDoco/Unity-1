using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private float TimeToLive = 5f;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D info)
    {
        Destroy(gameObject);
        Debug.Log(info.name);
        Destroy(gameObject);
    }

    //Brisanje
    /*void Update()
    {
        if (transform.position.x < -100 || transform.position.x > 100)
            Destroy(gameObject);
    }*/

    private void Update()
    {
        Destroy(gameObject, TimeToLive);
    }
}
