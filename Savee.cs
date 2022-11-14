using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Savee : MonoBehaviour
{
    private Save sv = new Save(); // добавили сейв короче

    private void Awake() // запускаем САМЫМ первым а вообще это сохранение
    {
        if (PlayerPrefs.HasKey("SV"))
        {
            sv = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("SV")); // говорит что переменная sv будет нашим сейвом который был создан после выхода
            money = sv.money; // приравнивает деньги к сейву денег
            clickMoney = sv.clickMoney; // приравнивает

            for(int i = 0; i < 1; i++) // тк тут есть индекс надо выгрузить его
        {
            CostBonus[i] = sv.CostBonus[i]; // выгрузка индекса
        }

        for(int i = 0; i < 2; i++) // тк тут есть индекс надо выгрузить его
        {
            CostPrice[i] = sv.CostPrice[i]; // выгрузка индекса
            CostText[i].text = sv.CostPrice[i] + "₽"; // выгрузка текста с ценой
        }

        }
    }

    private void OnApplicationQuit() // создаем переменную которая будет сохранять данные
    {
        sv.money = money; // сохранение кол-ва денег
        sv.clickMoney = clickMoney; // сохранение и тд
        sv.CostBonus = new int[1]; // в индексе кол-во кост бонусов
        sv.CostPrice = new int[2]; // в индесе кол-во цен

        for(int i = 0; i < 1; i++) // тк у нас есть индекс мы должны сохранить его (если изменилось количество то нужно пеменять его)
        {
            sv.CostBonus[i] = CostBonus[i]; // сохранение индекса
        }

        for(int i = 0; i < 2; i++) // тк у нас есть индекс мы должны сохранить его (если изменилось количество то нужно пеменять его)
        {
            sv.CostPrice[i] = CostPrice[i]; // сохранение индекса
        }

        PlayerPrefs.SetString("SV", JsonUtility.ToJson(sv)); // сохраняет данные под названием VS с расширенеем далее
    }
}

public class Save // переменная в которой лежат переменные которые нужно сохранять
{
    public int money;
    public int clickMoney;
    public int[] CostPrice;
    public int[] CostBonus;

}