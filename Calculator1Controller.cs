using UnityEngine;

public class Calculator1Controller : MonoBehaviour
{

    public Calculator1Model model; // Hooks to the model
    public Calculator1View view;   // Hooks to the view

    private void Start()
    {
        view.ClearAll();
        Debug.Log("Calculator1Controller called");

    }
    public void OnNumberButtonPressed(string number)
    {
        Debug.Log("OnNumberButtonPressed controller called");
        float num = float.Parse(number);
        model.InputNumber(num); 
        view.UpdateDisplay(model.GetCurrentDisplayValue());
    }

    public void OnOperatorButtonPressed(string operatorSymbol)
    {
        Debug.Log("OnOperatorButtonPressed controller called");
        model.InputOperator(operatorSymbol);
        view.UpdateDisplay(model.GetCurrentDisplayValue()); 
    }

    public void OnEqualsButtonPressed()
    {
        Debug.Log("OnEqualButtonPressed controller called");
        model.Calculate();
        view.UpdateDisplay(model.GetCurrentDisplayValue());
    }


    public void OnClearButtonPressed()
    {
        Debug.Log("OnClearButtonPressed controller called");
        model.ClearAll();
        view.ClearEntry(); 
    }

    
    public void OnClearEntryButtonPressed()
    {
        Debug.Log("OnClearEntryButtonPressed controller called");
        model.ClearEntry();
        view.UpdateDisplay(model.GetCurrentDisplayValue()); 
    }

    
    public void OnDecimalButtonPressed()
    {
        Debug.Log("OnDecimalButtonPressed controller called");
        model.AddDecimal();
        view.UpdateDisplay(model.GetCurrentDisplayValue());
    }
}
