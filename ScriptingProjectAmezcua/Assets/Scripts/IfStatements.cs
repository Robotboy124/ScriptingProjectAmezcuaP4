using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        //If coffee is greater than hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            //Do this
            print("Coffee is too hot to drink.");
        }
        //If it isn't, but the temperature is lower than coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //Do this
            print("Coffee is too cold to drink.");
        }
            //If it is neither too hot nor too cold...
            else
        {
            //do this
            print("Coffee is at just the right temperature.");
        }
    }
}
