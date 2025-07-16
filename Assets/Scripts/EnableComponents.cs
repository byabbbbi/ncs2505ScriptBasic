using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour
{
    private Light myLight;


    void Start()
    {
        //연결하기 전이여서 에러 발생!!!
        // myLight.enabled = true;
        myLight = GetComponent<Light>();
        myLight.enabled = true;
        
    }
    
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}