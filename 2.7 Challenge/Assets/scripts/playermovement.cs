using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    public Animator animator;
     Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

  
    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(0.0f, 0.0f);
        player = gameObject.transform;
        player.transform.position = new Vector2(-0.0f, 0.0f);
        m_Rigidbody = GetComponent<Rigidbody>();
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
      
        if (Input.GetAxis ("Horizontal")>0)
        {
            player.localScale = new Vector3(5, 5, 1);
        } 
        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector3(-5, 5, 1);

            if (Input.GetButton("Jump"))
            {
              
                animator.SetBool("ItsJumping", true);
                m_Rigidbody.AddForce(transform.up * m_Thrust);
            }
        }

    }

  


}
