/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OfflineMoney : MonoBehaviour
{
    public Text TimeOfflineText;
    public static int EarnMoneyOff;
    public static int lvlOffMoney = 0; // от 0 до 5. / 1 - (60м, 10%), 2 - (60м, 20%), 3 - (3ч, 20%), 4 - (12ч, 25%), 5 - (24ч, 50%)
    public GameObject OfflineMoneyPan;
    private void Awake()
    {
        CheckOffline();
    }

    public void OfflineMoneyPan_close()
    {
        OfflineMoneyPan.SetActive(false);
    }

    private void CheckOffline()
    {
        TimeSpan ts;
        if (PlayerPrefs.HasKey("LastSession"))
        {
            ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            if (lvlOffMoney > 0)
                OfflineMoneyPan.SetActive(true);

            if (lvlOffMoney == 1) // 1 lvl
            {
                if (ts.Hours >= 1)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 10) / 100);
                    EarnMoneyOff = (fromFiveSec * 720);
                    Game.money += EarnMoneyOff;
                    Status.totalEarnedMoney += EarnMoneyOff;
                    TimeOfflineText.text = string.Format("Вы отсутствовали в игре максимальное время: 1 час. \nВаш заработок: {0} денег", EarnMoneyOff);
                }
                if (ts.Hours < 1 && ts.Minutes < 60)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 10) / 100);
                    int countFiveSec = (ts.Minutes * 12) + (ts.Seconds / 5);
                    EarnMoneyOff = (fromFiveSec * countFiveSec);
                    Game.money += EarnMoneyOff;
                    Status.totalEarnedMoney += EarnMoneyOff;
                    TimeOfflineText.text = string.Format("Вы отсутствовали {0}m, {1}s. \nВаш заработок: {2} денег", ts.Minutes, ts.Seconds, EarnMoneyOff);
                }
            }
            if (lvlOffMoney == 2) // 2 lvl
            {
                if (ts.Hours >= 1)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 20) / 100);
                    EarnMoneyOff = (fromFiveSec * 720);
                    Game.money += EarnMoneyOff;
                    Status.totalEarnedMoney += EarnMoneyOff;
                    TimeOfflineText.text = string.Format("Вы отсутствовали в игре максимальное время: 1 час. \nВаш заработок: {0} денег", EarnMoneyOff);
                }
                if (ts.Hours < 1 && ts.Minutes < 60)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 20) / 100);
                    int countFiveSec = (ts.Minutes * 12) + (ts.Seconds / 5);
                    EarnMoneyOff = (fromFiveSec * countFiveSec);
                    Game.money += EarnMoneyOff;
                    Status.totalEarnedMoney += EarnMoneyOff;
                    TimeOfflineText.text = string.Format("Вы отсутствовали {0}m, {1}s. \nВаш заработок: {2} денег", ts.Minutes, ts.Seconds, EarnMoneyOff);
                }

            }
            if (lvlOffMoney == 3) // 3 lvl
            {
                if (ts.Hours >= 3 || ts.Days > 0)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 20) / 100);
                    EarnMoneyOff = (fromFiveSec * 2160);
                    Game.money += EarnMoneyOff;
                    Status.totalEarnedMoney += EarnMoneyOff;
                    TimeOfflineText.text = string.Format("Вы отсутствовали в игре максимальное время: 3 часа. \nВаш заработок: {0} денег", EarnMoneyOff);
                }
                if (ts.Hours >= 1 && ts.Hours <= 2)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 20) / 100);
                    EarnMoneyOff = ((ts.Hours * 720) + (ts.Minutes * 12) + (ts.Seconds / 5) * fromFiveSec);
                    Game.money += EarnMoneyOff;
                    Status.totalEarnedMoney += EarnMoneyOff;
                    TimeOfflineText.text = string.Format("Вы отсутствовали {0}h, {1}m, {2}s. \nВаш заработок: {3} денег", ts.Hours, ts.Minutes, ts.Seconds, EarnMoneyOff);
                }
                if (ts.Hours < 1 && ts.Minutes < 60)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 20) / 100);
                    int countFiveSec = (ts.Minutes * 12) + (ts.Seconds / 5);
                    EarnMoneyOff = (fromFiveSec * countFiveSec);
                    Game.money += (fromFiveSec * countFiveSec);
                    Status.totalEarnedMoney += (fromFiveSec * countFiveSec);
                    TimeOfflineText.text = string.Format("Вы отсутствовали {0}m, {1}s. \nВаш заработок: {2} денег", ts.Minutes, ts.Seconds, (fromFiveSec * countFiveSec));
                }

                if (lvlOffMoney == 4) // 4 lvl
                {
                    if (ts.Hours >= 12)
                    {
                        int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 25) / 100);
                        EarnMoneyOff = (fromFiveSec * 8640);
                        Game.money += EarnMoneyOff;
                        Status.totalEarnedMoney += EarnMoneyOff;
                        TimeOfflineText.text = string.Format("Вы отсутствовали в игре максимальное время: 12 часов. \nВаш заработок: {0} денег", EarnMoneyOff);
                    }
                    if (ts.Hours >= 1 && ts.Hours <= 11)
                    {
                        int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 25) / 100);
                        EarnMoneyOff = ((ts.Hours * 720) + (ts.Minutes * 12) + (ts.Seconds / 5) * fromFiveSec);
                        Game.money += EarnMoneyOff;
                        Status.totalEarnedMoney += EarnMoneyOff;
                        TimeOfflineText.text = string.Format("Вы отсутствовали {0}h, {1}m, {2}s. \nВаш заработок: {3} денег", ts.Hours, ts.Minutes, ts.Seconds, EarnMoneyOff);
                    }
                    if (ts.Hours < 1 && ts.Minutes < 60)
                    {
                        int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 25) / 100);
                        int countFiveSec = (ts.Minutes * 12) + (ts.Seconds / 5);
                        EarnMoneyOff = (fromFiveSec * countFiveSec);
                        Game.money += EarnMoneyOff;
                        Status.totalEarnedMoney += EarnMoneyOff;
                        TimeOfflineText.text = string.Format("Вы отсутствовали {0}m, {1}s. \nВаш заработок: {2} денег", ts.Minutes, ts.Seconds, EarnMoneyOff);
                    }

                }
                if (lvlOffMoney == 5) // 5 lvl
                {
                    if (ts.Hours >= 24 || ts.Days >= 1)
                    {
                        int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 50) / 100);
                        EarnMoneyOff = (fromFiveSec * 17280);
                        Game.money += EarnMoneyOff;
                        Status.totalEarnedMoney += EarnMoneyOff;
                        TimeOfflineText.text = string.Format("Вы отсутствовали в игре максимальное время: 24 часа. \nВаш заработок: {0} денег", EarnMoneyOff);
                    }
                }
                if (ts.Hours >= 1 && ts.Hours <= 23)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 50) / 100);
                    EarnMoneyOff = ((ts.Hours * 720) + (ts.Minutes * 12) + (ts.Seconds / 5) * fromFiveSec);
                    Game.money += EarnMoneyOff;
                    Status.totalEarnedMoney += EarnMoneyOff;
                    TimeOfflineText.text = string.Format("Вы отсутствовали {0}h, {1}m, {2}s. \nВаш заработок: {3} денег", ts.Hours, ts.Minutes, ts.Seconds, EarnMoneyOff);
                }
                if (ts.Hours < 1 && ts.Minutes < 60)
                {
                    int fromFiveSec = (((((Game.wage + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) * 50) / 100);
                    int countFiveSec = (ts.Minutes * 12) + (ts.Seconds / 5);
                    EarnMoneyOff = (fromFiveSec * countFiveSec);
                    Game.money += EarnMoneyOff;
                    Status.totalEarnedMoney += EarnMoneyOff;
                    TimeOfflineText.text = string.Format("Вы отсутствовали {0}m, {1}s. \nВаш заработок: {2} денег", ts.Minutes, ts.Seconds, EarnMoneyOff);
                }
            }

        }
    }
#if UNITY_ANDROID || UNITY_EDITOR
        private void OnApplicationPause(bool pause)
        {
            PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        }

        private void OnApplicationQuit()
        {
            PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        }
#endif
}*/
