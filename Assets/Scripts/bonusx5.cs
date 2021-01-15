using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class bonusx5 : MonoBehaviour
{
    public GameObject adsx5;


    void Update()
    {

    }

    public void goAd()
    {
        if (Advertisement.IsReady())
        {
            ShowOptions option = new ShowOptions();
            option.resultCallback = HandleShowResult;
            Advertisement.Show("rewardedVideo", option);
        }
    }

    public void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                Game.bonusForClick = 5;
				if (BuyBonus.buyContent99 == 0) {
					Game.countBonus = 500;
				}
				if (BuyBonus.buyContent99 == 1) {
					Game.countBonus = 1000;
				}
				if (BuyBonus.buyContent159 == 1) {
					Game.countBonus = 2000;
				}
                if (BuyBonus.buyContent590 == 1)
                {
                    Game.countBonus = 4000;
                }
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }
}
