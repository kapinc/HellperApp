using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Text;

public class form1 : MonoBehaviour
{
    public form1()
    {
        InitializeComponent();
    }

    private void btnClick_Click()
    {
        string f = txtfirst.Text;
        
        IbiOutput.Text = f;
    }

}