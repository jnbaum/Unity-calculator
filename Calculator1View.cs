using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class Calculator1View : MonoBehaviour
{

    private double currentValue = 0;
    private double storedValue = 0;
    private string currentOperator = "";
    private bool isNewEntry = true;
    public Text displayText;

    public void ClearEntry()
    {
        Debug.Log("ClearEntry view called");
        storedValue = 0;
    }     
    public void ClearAll()
    {
        Debug.Log("ClearAll view called");
        currentValue = 0;
        storedValue = 0;
        currentOperator = "";
        isNewEntry = true;
    }
    public void UpdateDisplay(double value) 
    {
        Debug.Log("UpdateDisplay view called");
         Debug.Log($"Updating display with value: {value}");
        if (double.IsNaN(value))
        {
            displayText.text = "Error"; 
        }
        else
        {
            displayText.text = value.ToString(); 
        }
    }
}


