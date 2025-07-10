using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 일반 변수 정의 및 선언 
        int number1;
        number1 = 1;
        int number2 = 2; // 초기화 
        float number3 = 3f, number4 = 4f; // 같은 데이터 형식의 여러 변수 선언 
        bool isBool = true;
        bool isNotTure = true;
        bool isOver = false;

        if (isNotTure)
        {
            
        }
        else
        {
            
        }

        Debug.Log(number1.ToString()); // 출력 : 1 
        Debug.Log(number2.ToString()); // 출력 : 2 
        Debug.Log(number3.ToString()); // 출력 : 3 
        Debug.Log(number4.ToString()); // 출력 : 4 
        Debug.Log(isBool.ToString()); // 출력 : True 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
