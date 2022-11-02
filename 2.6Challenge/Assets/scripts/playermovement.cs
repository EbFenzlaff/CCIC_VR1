using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    
  
    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(0.0f, 0.0f);
        player = gameObject.transform;
        player.transform.position = new Vector2(-0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
     float arrowInput = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        xMove.x = arrowInput;
        xMove.y = y;
        player.Translate(xMove * Time.deltaTime);
        Vector2 flip = new Vector2(-1.0f, 1.0f);
        transform.localScale *=  flip;
    }

  


}
