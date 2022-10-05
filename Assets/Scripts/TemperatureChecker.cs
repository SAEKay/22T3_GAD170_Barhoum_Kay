using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureChecker : MonoBehaviour
{
    [SerializeField] private float currentPorridgeTemperature = 85.0f;

    private float hotLimitTemperature = 70.0f;
    private float coldLimitTemperature = 40.0f;    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();

        }

    currentPorridgeTemperature -= Time.deltaTime * 5f;

        
    }

    void TemperatureTest()
    {
        if (currentPorridgeTemperature > hotLimitTemperature)
        {
            Debug.Log("The porridge is too hot." + (int)currentPorridgeTemperature);


        }
        else if (currentPorridgeTemperature == 55f)
        {
            Debug.Log("The porridge is perfect");

        }
        else if (currentPorridgeTemperature < coldLimitTemperature)
        {
            Debug.Log("The porridge is too cold");
        }
        else
        {
            Debug.Log("The porridge is just right!");
        }

    }
}

    
