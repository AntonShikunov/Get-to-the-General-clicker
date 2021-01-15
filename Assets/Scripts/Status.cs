using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Status : MonoBehaviour
{
    public static int StatusLvl = 0; // уровень статуса
    public static int totalEarnedMoney = 0; // общее количество заработанных денег
    public static int percentToWage = 0; // процент от заработка
    public static int goldPer10sec = 0; // золота за 10 сек

    public static string[] nameStatus = {"BEGINNER", "STUDENT", "SMASHING", "PRO", "PRO+", "HIGH-PROFESSIONAL", "HIGH-PROFESSIONAL",
    "HIGH-PROFESSIONAL", "HIGH-PROFESSIONAL", "VIP+", "VIP+", "VIP+", "VIP+"}; // 13

    public Image[] StatusImg = new Image[13];

    public Text StatusText;
    public Text HowMuchEarnedText;
    public Text PlusGoldPer10secText;

    public GameObject HPstar1Img, HPstar2Img, HPstar3Img, Vipstar1Img, Vipstar2Img, Vipstar3Img;
    public GameObject GoldPer10SecPref, clickParent;

     void Start()
    {
        StartCoroutine(GoGoldPer10sec());
    }
    void Update()
    {
        StatusText.text = "" + nameStatus[StatusLvl];
        //PlusGoldPer10secText.text = "" + goldPer10sec;
        if (Game.idLanguage == 1)
            HowMuchEarnedText.text = "ЗАРАБОТАНО      : " + totalEarnedMoney.ToString("N0");
        if (Game.idLanguage == 2)
            HowMuchEarnedText.text = "YOU EARNED      : " + totalEarnedMoney.ToString("N0");
        if (totalEarnedMoney <= 1000)
        {
            StatusLvl = 0;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            StatusText.color = new Color(251 / 255.0f, 255 / 255.0f, 177 / 255.0f);
            HPstar1Img.SetActive(false);
            HPstar2Img.SetActive(false);
            HPstar3Img.SetActive(false);
            Vipstar1Img.SetActive(false);
            Vipstar2Img.SetActive(false);
            Vipstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 1000 && totalEarnedMoney <= 10000)
        {
            StatusLvl = 1;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 1;
            StatusText.color = new Color(203 / 255.0f, 212 / 255.0f, 29 / 255.0f);
            HPstar1Img.SetActive(false);
            HPstar2Img.SetActive(false);
            HPstar3Img.SetActive(false);
            Vipstar1Img.SetActive(false);
            Vipstar2Img.SetActive(false);
            Vipstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 10000 && totalEarnedMoney <= 50000)
        {
            StatusLvl = 2;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 3;
            StatusText.color = new Color(236 / 255.0f, 144 / 255.0f, 81 / 255.0f);
            HPstar1Img.SetActive(false);
            HPstar2Img.SetActive(false);
            HPstar3Img.SetActive(false);
            Vipstar1Img.SetActive(false);
            Vipstar2Img.SetActive(false);
            Vipstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 50000 && totalEarnedMoney <= 100000)
        {
            StatusLvl = 3;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 5;
            StatusText.color = new Color(241 / 255.0f, 17 / 255.0f, 55 / 255.0f);
            HPstar1Img.SetActive(false);
            HPstar2Img.SetActive(false);
            HPstar3Img.SetActive(false);
            Vipstar1Img.SetActive(false);
            Vipstar2Img.SetActive(false);
            Vipstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 100000 && totalEarnedMoney <= 250000)
        {
            StatusLvl = 4;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 10;
            StatusText.color = new Color(241 / 255.0f, 17 / 255.0f, 55 / 255.0f);
            HPstar1Img.SetActive(false);
            HPstar2Img.SetActive(false);
            HPstar3Img.SetActive(false);
            Vipstar1Img.SetActive(false);
            Vipstar2Img.SetActive(false);
            Vipstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 250000 && totalEarnedMoney <= 500000)
        {
            StatusLvl = 5;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 15;
            StatusText.color = new Color(87 / 255.0f, 175 / 255.0f, 250 / 255.0f);
            HPstar1Img.SetActive(false);
            HPstar2Img.SetActive(false);
            HPstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 500000 && totalEarnedMoney <= 1000000)
        {
            StatusLvl = 6;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 20;
            goldPer10sec = 1;
            StatusText.color = new Color(87 / 255.0f, 175 / 255.0f, 250 / 255.0f);
            HPstar1Img.SetActive(true);
            HPstar2Img.SetActive(false);
            HPstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 1000000 && totalEarnedMoney <= 3000000)
        {
            StatusLvl = 7;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 30;
            goldPer10sec = 2;
            StatusText.color = new Color(87 / 255.0f, 175 / 255.0f, 250 / 255.0f);
            HPstar1Img.SetActive(true);
            HPstar2Img.SetActive(true);
            HPstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 3000000 && totalEarnedMoney <= 10000000)
        {
            StatusLvl = 8;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 40;
            goldPer10sec = 3;
            StatusText.color = new Color(87 / 255.0f, 175 / 255.0f, 250 / 255.0f);
            HPstar1Img.SetActive(true);
            HPstar2Img.SetActive(true);
            HPstar3Img.SetActive(true);
        }
        if (totalEarnedMoney > 10000000 && totalEarnedMoney <= 20000000)
        {
            StatusLvl = 9;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 60;
            goldPer10sec = 5;
            StatusText.color = new Color(185 / 255.0f, 70 / 255.0f, 255 / 255.0f);
            HPstar1Img.SetActive(false);
            HPstar2Img.SetActive(false);
            HPstar3Img.SetActive(false);
            Vipstar1Img.SetActive(false);
            Vipstar2Img.SetActive(false);
            Vipstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 20000000 && totalEarnedMoney <= 30000000)
        {
            StatusLvl = 10;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 80;
            goldPer10sec = 10;
            StatusText.color = new Color(185 / 255.0f, 70 / 255.0f, 255 / 255.0f);
            Vipstar1Img.SetActive(true);
            Vipstar2Img.SetActive(false);
            Vipstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 30000000 && totalEarnedMoney <= 50000000)
        {
            StatusLvl = 11;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 100;
            goldPer10sec = 20;
            StatusText.color = new Color(185 / 255.0f, 70 / 255.0f, 255 / 255.0f);
            Vipstar1Img.SetActive(true);
            Vipstar2Img.SetActive(true);
            Vipstar3Img.SetActive(false);
        }
        if (totalEarnedMoney > 50000000 && totalEarnedMoney <= 100000000)
        {
            StatusLvl = 12;
            for (int i = 0; i < 13; i++)
            {
                if (StatusLvl == i)
                    StatusImg[i].color = new Color(40 / 255.0f, 0 / 255.0f, 40 / 255.0f);
                else
                    StatusImg[i].color = new Color(1 / 255.0f, 23 / 255.0f, 41 / 255.0f);
            }
            percentToWage = 150;
            goldPer10sec = 40;
            StatusText.color = new Color(185 / 255.0f, 70 / 255.0f, 255 / 255.0f);
            Vipstar1Img.SetActive(true);
            Vipstar2Img.SetActive(true);
            Vipstar3Img.SetActive(true);
        }

    }

    public IEnumerator GoGoldPer10sec()
    {
        while (true)
        {
            yield return new WaitForSeconds(9f);
            if (goldPer10sec > 0)
            {
                Game.gold += goldPer10sec;
                GameObject gold_obj = Instantiate(GoldPer10SecPref, GoldPer10SecPref.transform.position, Quaternion.identity) as GameObject;
                gold_obj.GetComponent<Text>().text = "+" + goldPer10sec;
                gold_obj.transform.SetParent(clickParent.transform);
                gold_obj.transform.localScale = new Vector3(1f, 1f, 1f);
                gold_obj.transform.localPosition = new Vector3(-20f, 160f, 0f);
                Destroy(gold_obj, 3f);
            }
            //yield return new WaitForSeconds(3f);
        }
    }
}
