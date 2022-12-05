using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    public Animator animator;
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 65.0f;
    public static int acorn;
    public static int health;
    bool level1 = true;

    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(0.0f, 0.0f);
        player = gameObject.transform;
        player.transform.position = new Vector2(-0.0f, 0.0f);
        m_Rigidbody = GetComponent<Rigidbody2D>();
        acorn = 0;
        health = 3;


    }

    // Update is called once per frame
    void Update()
    {
       
        float arrowInput = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(arrowInput));
        float y = Input.GetAxis("Vertical");
        xMove.x = arrowInput * 5;
        xMove.y = y;
        player.Translate(xMove * Time.deltaTime);
        // Vector2 flip = new Vector2(-1.0f, 1.0f);
        //transform.localScale *=  flip;

        if (Input.GetAxis("Horizontal") > 0)
        {
            player.localScale = new Vector3(5, 5, 1);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector3(-5, 5, 1);

        }

        if (y > 0)
        {

            if (m_Rigidbody.velocity.y == 0)
            {
                m_Rigidbody.AddForce(transform.up * m_Thrust);
                animator.SetBool("IsJumping", true);
            }

            if (health == 0)
            {
                
                Debug.Log("Game Over");
                Destroy(gameObject);


            }
        }

        if (acorn == 8)
        {
            level1 = false;
            SceneManager.LoadScene("WIN");
        }
       

  

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "ground")
        {
            animator.SetBool("IsJumping", false);


        }
        if (col.gameObject.tag == "acorn")
        {
            animator.SetBool("IsJumping", false);
            Debug.Log("NOM NOM");
            acorn = acorn + 1;

        }
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("OUCH!");
            health = health - 1;
        }

        if (col.gameObject.tag == "door")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            level1 = false;
        }

        if (col.gameObject.tag == "doorback")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            level1 = false;
        }

        if (col.gameObject.tag == "Potion")
        {
            health = health + 1;

        }


    }
    void OnBecameInvisible()
    {
        
        health = 0;
        if (health == 0 && level1 == true){
            Debug.Log("Game Over");
            SceneManager.LoadScene("GameOver");

        }


    }
}

   
  
    



  



