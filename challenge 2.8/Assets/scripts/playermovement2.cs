using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement2 : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    public Animator animator;
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 10f;
    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(0.0f, 0.0f);
        player = gameObject.transform;
        player.transform.position = new Vector2(-0.0f, 0.0f);
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float arrowInput = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(arrowInput));
        float y = Input.GetAxis("Vertical");
        xMove.x = arrowInput;
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
            m_Rigidbody.AddForce(transform.up * m_Thrust);
            animator.SetBool("IsJumping", true);


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

        }

        /*void OnBecameInvisisble()
            {
                Destroy(gameObject);
                Debug.Log("dead");
            }*/
        void OnBecameInvisible()
        {
            Destroy(gameObject);
            Debug.Log("Dead");
        }
    }
}
