using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.RemoteConfig;
using UnityEngine.UI;

public class StartSkript : MonoBehaviour
{
    public struct userAttributes { }
    public struct appAttributes { }

    public string kay1;

    public GameObject MenuPan;
    public GameObject IncorrectPan;
    public GameObject ShortPan;
    public GameObject OsnovaPan;
    public GameObject ProgramPan;
    public GameObject NotLogin;

    [SerializeField] int CompliteUser = 0;

    public InputField InputFieldPromocod;

    private void Start()
    {
        ConfigManager.FetchConfigs(new userAttributes(), new appAttributes());
        ConfigManager.FetchCompleted += Load;
        CompliteUser = PlayerPrefs.GetInt("CompliteUser");
        if(CompliteUser >= 1)
        {
            MenuPan.SetActive(!MenuPan.activeSelf);
            OsnovaPan.SetActive(!OsnovaPan.activeSelf);
            ProgramPan.SetActive(!ProgramPan.activeSelf);
        }
    }

    private void Load(ConfigResponse response)
    {
        kay1 = ConfigManager.appConfig.GetString("kay1");
    }

    public void InputPromocod()
    {
        if(InputFieldPromocod.text.Length == 4)
        {
            if(InputFieldPromocod.text == kay1)
            {
                MenuPan.SetActive(!MenuPan.activeSelf);
            }
            else if (InputFieldPromocod.text != kay1)
            {
                IncorrectPan.SetActive(!IncorrectPan.activeSelf);
            }
        }
        else
        {
            ShortPan.SetActive(!ShortPan.activeSelf);
        }
    }

     public void CloseIncorrectPan()
    {
        IncorrectPan.SetActive(!IncorrectPan.activeSelf);
    }

     public void CloseShortPan()
    {
        ShortPan.SetActive(!ShortPan.activeSelf);
    }

     public void ComplitePan()
    {
        MenuPan.SetActive(!MenuPan.activeSelf);
        OsnovaPan.SetActive(!OsnovaPan.activeSelf);
        ProgramPan.SetActive(!ProgramPan.activeSelf);
        CompliteUser++;
        PlayerPrefs.SetInt("CompliteUser", CompliteUser);
    }
}