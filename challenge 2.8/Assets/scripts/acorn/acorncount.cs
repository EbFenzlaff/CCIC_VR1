using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acorncount : MonoBehaviour
{

    private int acorn = 0; 
    public Text acorntext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        acorntext.text = "acorns " + playermovement.acorn;
       
        
    }
}
