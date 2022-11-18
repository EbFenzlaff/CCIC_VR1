using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovment : MonoBehaviour
{
    Vector2 moveUP;
    Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        moveUP = new Vector2(0.0f, 1.0f);
        camera = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        camera.Translate(moveUP * Time.deltaTime);
    }
}
