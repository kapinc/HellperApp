using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject PlusePan;
    

    public void OpenPluseMenuPan()
    {
        PlusePan.SetActive(!PlusePan.activeSelf);
    }  

    
}
