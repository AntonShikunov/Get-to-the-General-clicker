using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class UnlockMedal3 : MonoBehaviour
{

    public GameObject WatchAdBttn3;

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
                Game.NumAdsForMedal[2] -= 1;
                if (Game.NumAdsForMedal[2] == 0)
                {
                    WatchAdBttn3.SetActive(false);
                    Game.medals[2] = 1;
                    if (Game.clickatonce < 4)
                        Game.clickatonce = 4;
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
