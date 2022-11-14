using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class form1 : MonoBehaviour
{
    public form1()
    {
        InitializeComponent();
    }

    public void btnClick_Click()
    {
        string f = txtfirst.Text;
        
        IbiOutput.Text = f;
    }

}