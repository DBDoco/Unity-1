using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private bool jump = false;
    private float jumpSpeed = 12;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        jump = Input.GetKeyDown(KeyCode.Space);
        if (jump)
        {
            body.velocity = new Vector2(body.velocity.x, jumpSpeed);
            source.PlayOneShot(clip);
        }

        transform.rotation = Quaternion.Euler(0f, 0f, body.velocity.y*2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
