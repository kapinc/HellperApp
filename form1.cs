using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class form1 : MonoBehaviour
{
    public GameObject ShowText;


    public InputField Food;

    public Text ShowFood;
    public Text Foodtext;

    public void AddText()
    {

    }
    
    public void Edit()
    {
        Foodtext.text = ShowFood.text;
        
    }
}