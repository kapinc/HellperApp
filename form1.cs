using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class form1 : MonoBehaviour 
{
    [SerializeField] InputField field;
    public string input_text;
    public Text gg;

    public void SaveName()
    {
    input_text = field.text;
    gg.text = field.text; 
    }
}