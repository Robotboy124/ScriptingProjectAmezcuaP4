using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;
    void Start()
        // Debu.Log similar to Print
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }
    // Multiply By 2 function
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
