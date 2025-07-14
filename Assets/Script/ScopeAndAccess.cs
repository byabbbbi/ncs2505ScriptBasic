using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour
{
    public int alphaAndOmega = 5;


    private int beta = 0;
    private int gamma = 5;


    private AnotherClass myOtherClass;


    void Start()
    {
        alphaAndOmega = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alphaAndOmega, myOtherClass.apples);
    }


    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alphaAndOmega;
        Debug.Log(answer);
    }


    void Update()
    {
        Debug.Log("Alpha is set to: " + alphaAndOmega);
    }
}
