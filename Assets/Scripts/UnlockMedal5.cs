﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class UnlockMedal5 : MonoBehaviour
{

    public GameObject WatchAdBttn5;

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
                Game.NumAdsForMedal[4] -= 1;
                if (Game.NumAdsForMedal[4] == 0)
                {
                    WatchAdBttn5.SetActive(false);
                    Game.medals[4] = 1;
                    if (Game.clickatonce < 10)
                        Game.clickatonce = 10;
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
