using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purple_track : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 LastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        LastVelocity = rb.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var target = GameObject.FindGameObjectWithTag("Player").transform;

        var speed = LastVelocity.magnitude;
        var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);

        switch (collision.gameObject.tag)
        {
            case "wall":

                rb.velocity = new Vector2((target.position.x - rb.position.x), (target.position.y - rb.position.y));


                break;
          

        }
    }

}

