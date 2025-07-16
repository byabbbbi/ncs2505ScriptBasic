using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    Color myColor;
    void Start()
    {
        myColor = GetComponent<Renderer>().material.color;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            myColor = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            myColor = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            myColor = Color.blue;
        }
        else if (Input.anyKeyDown)
        {
            if (!Input.GetKeyDown(KeyCode.R) &&
                !Input.GetKeyDown(KeyCode.G) &&
                !Input.GetKeyDown(KeyCode.B))
            {
                myColor = Color.cyan;
            }
        }
        GetComponent<Renderer>().material.color = myColor;
    }
}
