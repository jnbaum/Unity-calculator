using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator1Model : MonoBehaviour


{
    private double currentValue = 0;
    private double storedValue = 0;
    private string currentOperator = "";
    private bool isNewEntry = true;
    private bool isDecimalMode = false; 
    private double decimalFactor = 1; 

   
    public void InputNumber(float num)
    {
        Debug.Log("InputNumber model called");
        if (isNewEntry)
        {
            currentValue = num; 
            isNewEntry = false; 
            isDecimalMode = false;
            decimalFactor = 1; 
        }
        else if (isDecimalMode)
        {
            decimalFactor *= 0.1; 
            currentValue += num * decimalFactor;
        }
        else
        {
            currentValue = double.Parse(currentValue.ToString() + num.ToString());
        }
    }

    public void InputOperator(string op)
    {
        Debug.Log("Inputoperator model called");
        if (!isNewEntry)
        {
            Calculate();
            storedValue = currentValue;
        }
        currentOperator = op;
        isNewEntry = true;
        isDecimalMode = false; 
        decimalFactor = 1; 
    }

    public void Calculate()
    {
        Debug.Log("calculate model called");
        switch (currentOperator)
        {
            case "+":
                currentValue = storedValue + currentValue;
                break;
            case "-":
                currentValue = storedValue - currentValue;
                break;
            case "*":
                currentValue = storedValue * currentValue;
                break;
            case "/":
                if (currentValue != 0)
                    currentValue = storedValue / currentValue;
                else
                    currentValue = double.NaN; 
                break;
            case "%":
                currentValue = storedValue % currentValue;
                break;
        }
        storedValue = currentValue;
        isNewEntry = true;
    }

    
    public void ClearEntry()
    {
        Debug.Log("clearentry model called");
        currentValue = 0;
    }
    public void ClearAll()
    {
        Debug.Log("clearall model called");
        currentValue = 0;
        storedValue = 0;
        currentOperator = "";
        isNewEntry = true;
        isDecimalMode = false; 
        decimalFactor = 1; 
    }
    public void AddDecimal()
    {
        Debug.Log("adddecimal model called");
        if (!isDecimalMode)
        {
           isDecimalMode = true;
        }
    }
    public double GetCurrentDisplayValue() => currentValue;
}


