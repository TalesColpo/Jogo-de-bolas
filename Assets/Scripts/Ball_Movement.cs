using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    private float speed = 400;

    Player_Movement player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player_Movement>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(20*Time.deltaTime*speed, 20 * Time.deltaTime * speed));

        player.myMultiDelegate += reduce;

       
    }
   
    public void reduce()
    {
        if(gameObject.tag == "red")
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Invoke("recover", 4);
        }

    }

    public void recover()
    {
        if (gameObject.tag == "red")
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }



    // Update is called once per frame
    void Update()
    {
        
    }

}
