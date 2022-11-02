using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossumMovement : MonoBehaviour
{
    Vector2 xmove;
    Transform Possum;
    // Start is called before the first frame update
    void Start()
    {
        xmove = new Vector2(-1.0f, 0.0f);
        Possum = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Possum.Translate(xmove*Time.deltaTime);

    }
}
