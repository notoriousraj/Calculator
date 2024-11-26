using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class Calculator : MonoBehaviour
{
    public InputField displayText;
    public string currentInput = "";
    public void OnButtonClick(string buttonValue)
    {
        currentInput += buttonValue;
        displayText.text = currentInput;
    }

    public void OnClearClick()
    {
        currentInput = "";
        displayText.text = "0";
    }

    public void OnEqualsClick()
    {
        try
        {
            var result = new DataTable().Compute(currentInput, null);  
            currentInput = result.ToString(); 
            displayText.text = currentInput;
        }
        catch
        {
            displayText.text = "Error";
            currentInput = "";
        }
    }
}
