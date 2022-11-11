using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 2;
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;

    public GameObject circle;

    public GameObject circlered;

    public GameObject purple;

    public GameObject pink;

    public delegate void MultiDelegate();
    public MultiDelegate myMultiDelegate;


    

    public int number;
    private Animator anim;
    private bool dead;

    void Start()
    {
        

        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x = pos.x + horizontal * speed * Time.deltaTime;
        pos.y = pos.y + vertical * speed * Time.deltaTime;
        rb.MovePosition(pos);
        anim.SetBool("run", horizontal !=0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "green":
                Score.scoreAmount += 1;
            
                number = Random.Range(1, 3);
                SpawnObjects();
               

                if (number == 2)
                {
                    SpawnObjectsred();
                }
                else
                {
                    SpawnObjectpurple();
                }
                  
                Destroy(collision.gameObject);

                break;
            case "red":
                anim.SetTrigger("die");
                enabled = false;
                break;
            case "purple":
                anim.SetTrigger("die");
                enabled = false;
                break;

            case "pink":

                if (myMultiDelegate != null)
                {
                    myMultiDelegate();
                }
                

                Destroy(collision.gameObject);
                break;

        }
    }

    private void SpawnObjects()
    {

        float spawnY = Random.Range(-3.55f, 3.30f);
        float spawnX = Random.Range(-7f, 7f);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(circle, spawnPosition, Quaternion.identity);
       

    }
    private void SpawnObjectsred()
    {

        float spawnY = Random.Range(-3.55f, 3.30f);
        float spawnX = Random.Range(-7f, 7f);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(circlered, spawnPosition, Quaternion.identity);
    }
    private void SpawnObjectpurple()
    {

        float spawnY = Random.Range(-3.55f, 3.30f);
        float spawnX = Random.Range(-7f, 7f);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(purple, spawnPosition, Quaternion.identity);
    }

    
}