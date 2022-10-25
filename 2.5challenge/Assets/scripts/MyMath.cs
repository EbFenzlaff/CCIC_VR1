using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    int num = 1200;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        product();
        Debug.Log(num);

    }

    void product()

    {
        num = num * 2;
   
    }
}
