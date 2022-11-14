using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject PlusePan;
    public GameObject AddButton;

    public int[] NamePred;
    

    public void OpenPluseMenuPan()
    {
        PlusePan.SetActive(!PlusePan.activeSelf);
    }  

    public void AddButtonButton()
    {
        PlusePan.SetActive(!PlusePan.activeSelf);
    }  
    
}
