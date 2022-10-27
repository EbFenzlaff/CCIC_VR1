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
        xMove = new Vector2(1.0f, 0.0f);
        player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xMove * Time.deltaTime);
       
    }

  


}
