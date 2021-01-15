using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class SaveSystem : MonoBehaviour
{

    public Save sv = new Save();

    void Start()
    {
       
    }

	public void Awake() {
		if (PlayerPrefs.HasKey("Save"))
		{
			sv = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("Save"));
            for (int i = 0; i < 8; i++)
            {
                Game.count[i] = sv.count[i];
            }
            for (int i = 0; i < 5; i++)
            {
                Game.medals[i] = sv.medals[i];
                Game.NumAdsForMedal[i] = sv.NumAdsForMedal[i];
            }
			Game.idLanguage = sv.idLanguage;
			Game.proVersion = sv.proVersion;
			Game.bonusForBuy = sv.bonusForBuy;
			Game.money = sv.money;
			Game.gold = sv.gold;
			Game.scroll = sv.scroll;
			Game.wage = sv.wage;
			Game.bonusMoney = sv.bonusMoney;
            Game.exp = sv.exp;
            Game.clickatonce = sv.clickatonce;
            Game.rank = sv.rank;
			Game.idForce = sv.idForce;
            Game.needExp = sv.needExp;
			Game.yesRate = sv.yesRate;
			Game.BonusFromGold = sv.BonusFromGold;
			Game.percentGoldForClick = sv.percentGoldForClick;
			Game.bonusForRate = sv.bonusForRate;
			Game.finishNavy = sv.finishNavy;
			Game.finishPolice = sv.finishPolice;
			Game.finishVDV = sv.finishVDV;
			Game.finishRHBZ = sv.finishRHBZ;
			Game.finishPolitic = sv.finishPolitic;
			Game.costSkill1 = sv.costSkill1;
			Game.costSkill2 = sv.costSkill2;
			Game.costSkill3 = sv.costSkill3;
			Game.costSkill4 = sv.costSkill4;
			Game.costSkill5 = sv.costSkill5;
			Game.costSkill6 = sv.costSkill6;
			Game.costSkill7 = sv.costSkill7;
			Game.lvlSkill1 = sv.lvlSkill1;
			Game.lvlSkill2 = sv.lvlSkill2;
			Game.lvlSkill3 = sv.lvlSkill3;
			Game.lvlSkill4 = sv.lvlSkill4;
			Game.lvlSkill5 = sv.lvlSkill5;
			Game.lvlSkill6 = sv.lvlSkill6;
			Game.lvlSkill7 = sv.lvlSkill7;
			Forces.changeForces = sv.changeForces;
			Outfit.idOutfit = sv.idOutfit;
			Outfit.yesOutfit1 = sv.yesOutfit1;
			Outfit.yesOutfit2 = sv.yesOutfit2;
			Outfit.yesOutfit3 = sv.yesOutfit3;
			Outfit.yesOutfit4 = sv.yesOutfit4;
			Outfit.yesOutfit5 = sv.yesOutfit5;
			Outfit.yesOutfit6 = sv.yesOutfit6;
			Outfit.yesOutfit7 = sv.yesOutfit7;
			Outfit.yesOutfit8 = sv.yesOutfit8;
			Outfit.yesOutfit9 = sv.yesOutfit9;
			Outfit.yesOutfit10 = sv.yesOutfit10;
			Outfit.yesOutfit11 = sv.yesOutfit11;
			Outfit.yesOutfit12 = sv.yesOutfit12;
			Outfit.yesOutfit13 = sv.yesOutfit13;
			Outfit.yesOutfit14 = sv.yesOutfit14;
			Outfit.yesOutfit15 = sv.yesOutfit15;
			Outfit.yesOutfit16 = sv.yesOutfit16;
			Outfit.yesOutfit17 = sv.yesOutfit17;
			Outfit.yesOutfit18 = sv.yesOutfit18;
			Outfit.yesOutfit19 = sv.yesOutfit19;
			Outfit.yesOutfit20 = sv.yesOutfit20;
			Outfit.yesOutfit21 = sv.yesOutfit21;
			Outfit.yesOutfit22 = sv.yesOutfit22;
			Outfit.yesOutfit23 = sv.yesOutfit23;
			Outfit.yesOutfit24 = sv.yesOutfit24;
			Outfit.yesOutfit25 = sv.yesOutfit25;
			Outfit.yesOutfit26 = sv.yesOutfit26;
			Outfit.yesOutfit27 = sv.yesOutfit27;
			Emblems.idEmblems = sv.idEmblems;
			Emblems.AuthorityForSec = sv.AuthorityForSec;
			Emblems.yesEmblem1 = sv.yesEmblem1; 
			Emblems.yesEmblem2 = sv.yesEmblem2; 
			Emblems.yesEmblem3 = sv.yesEmblem3;  
			Emblems.yesEmblem4 = sv.yesEmblem4;  
			Emblems.yesEmblem5 = sv.yesEmblem5;  
			Emblems.yesEmblem6 = sv.yesEmblem6;  
			Emblems.yesEmblem7 = sv.yesEmblem7;  
			Emblems.yesEmblem8 = sv.yesEmblem8; 
			Authority.authority = sv.authority;
			Authority.expAuthority = sv.expAuthority;
			Authority.needExpAuthority = sv.needExpAuthority;
			Authority.WageAuthority = sv.WageAuthority;
			Partner.lvlPartner = sv.lvlPartner;
			Partner.costUpdPartner = sv.costUpdPartner;
			Partner.totalProfitMoney = sv.totalProfitMoney;
			Partner.totalProfitExp = sv.totalProfitExp;
			Partner.lvlPartner2 = sv.lvlPartner2;
			Partner.costUpdPartner2 = sv.costUpdPartner2;
			Partner.lvlPartner3 = sv.lvlPartner3;
			Partner.costUpdPartner3 = sv.costUpdPartner3;
			BuyBonus.buyContent = sv.buyContent;
			BuyBonus.buyContent60 = sv.buyContent60;
			BuyBonus.buyContent99 = sv.buyContent99;
			BuyBonus.buyContent159 = sv.buyContent159;
			Passport.serve_year = sv.serve_year;
			Passport.serve_day = sv.serve_day;
			Passport.numServeForces = sv.numServeForces;
			Passport.militatyTicket = sv.militatyTicket;
			Passport.CadetSchool = sv.CadetSchool;
			Cadet.CadetRank = sv.CadetRank;
			Cadet.NeedExpCadet = sv.NeedExpCadet;
			Cadet.CountExpCadet = sv.CountExpCadet; 
			Cadet.expCadet = sv.expCadet;
			Cadet.processCader = sv.processCader;
			Bosses.countWinForAds = sv.countWinForAds;
			Bosses.idBoss = sv.idBoss; // id боссов (от 1 и выше)
			Bosses.strength = sv.strength; // сила
			Bosses.costUpStrength = sv.costUpStrength; // стоимость улучшения силы
			Bosses.HPBoss = sv.HPBoss; // хп босса
			Bosses.HPLeft = sv.HPLeft; // сколько хп осталось
			Bosses.PrizeBoss1 = sv.PrizeBoss1; 
			Bosses.PrizeBoss2 = sv.PrizeBoss2; 
			Bosses.PrizeBoss3 = sv.PrizeBoss3;
			Bosses.PrizeBoss4 = sv.PrizeBoss4; 
			Bosses.PrizeBoss5 = sv.PrizeBoss5;
			Bosses.Boss1Win = sv.Boss1Win; 
			Bosses.Boss2Win = sv.Boss2Win; 
			Bosses.Boss3Win = sv.Boss3Win; 
			Bosses.Boss4Win = sv.Boss4Win; 
			Bosses.Boss5Win = sv.Boss5Win;
			Bosses.Timer = sv.Timer; 
			Bosses.NumWinBosses = sv.NumWinBosses; 
			Court.yesCourt = sv.yesCourt; 
			Court.numInvestigation = sv.numInvestigation; 
			Court.chanceWinInvestigation = sv.chanceWinInvestigation; 
			Court.timeCourt = sv.timeCourt; 
			Court.maxTimeCourt = sv.maxTimeCourt;
			Court.winScroll = sv.winScroll;
			Court.winGold = sv.winGold;
			Court.xPrize = sv.xPrize; 
			Court.compensationScroll = sv.compensationScroll;
			Court.costUpdCourt1 = sv.costUpdCourt1;
			Court.costUpdCourt2 = sv.costUpdCourt2;
			Court.costUpdCourt3 = sv.costUpdCourt3;
			Court.randInvest = sv.randInvest;
			Court.WinCourt = sv.WinCourt;
			Court.autoCourt = sv.autoCourt;
			Court.countWinCourt = sv.countWinCourt;
			Status.StatusLvl = sv.StatusLvl; 
			Status.totalEarnedMoney = sv.totalEarnedMoney;
			Status.percentToWage = sv.percentToWage;
			Status.goldPer10sec = sv.goldPer10sec;
			OffMoney.lvlOffMoney = sv.lvlOffMoney;
}		
	}

#if UNITY_ANDROID && !UNITY_EDITOR
    public void OnApplicationPause(bool pause)
    {
        for (int i = 0; i < 8; i++)
        {
            sv.count[i] = Game.count[i];
        }
        for (int i = 0; i < 5; i++)
        {
            sv.medals[i] = Game.medals[i];
            sv.NumAdsForMedal[i] = Game.NumAdsForMedal[i];
        }
		sv.idLanguage = Game.idLanguage;
		sv.proVersion = Game.proVersion;
		sv.bonusForBuy = Game.bonusForBuy;
		sv.money = Game.money;
		sv.gold = Game.gold;
		sv.scroll = Game.scroll;
		sv.wage = Game.wage;
		sv.bonusMoney = Game.bonusMoney;
        sv.exp = Game.exp;
        sv.clickatonce = Game.clickatonce;
        sv.rank = Game.rank;
		sv.idForce = Game.idForce;
        sv.needExp = Game.needExp;
		sv.yesRate = Game.yesRate;
		sv.BonusFromGold = Game.BonusFromGold;
		sv.percentGoldForClick = Game.percentGoldForClick;
		sv.bonusForRate = Game.bonusForRate;
		sv.finishNavy = Game.finishNavy;
		sv.finishPolice = Game.finishPolice;
		sv.finishVDV = Game.finishVDV;
		sv.finishRHBZ = Game.finishRHBZ;
		sv.finishPolitic = Game.finishPolitic;
		sv.costSkill1 = Game.costSkill1;
		sv.costSkill2 = Game.costSkill2;
		sv.costSkill3 = Game.costSkill3;
		sv.costSkill4 = Game.costSkill4;
		sv.costSkill5 = Game.costSkill5;
		sv.costSkill6 = Game.costSkill6;
		sv.costSkill7 = Game.costSkill7;
		sv.lvlSkill1 = Game.lvlSkill1;
		sv.lvlSkill2 = Game.lvlSkill2;
		sv.lvlSkill3 = Game.lvlSkill3;
		sv.lvlSkill4 = Game.lvlSkill4;
		sv.lvlSkill5 = Game.lvlSkill5;
		sv.lvlSkill6 = Game.lvlSkill6;
		sv.lvlSkill7 = Game.lvlSkill7;
		sv.changeForces = Forces.changeForces;
		sv.idOutfit = Outfit.idOutfit;
		sv.yesOutfit1 = Outfit.yesOutfit1;
		sv.yesOutfit2 = Outfit.yesOutfit2;
		sv.yesOutfit3 = Outfit.yesOutfit3;
		sv.yesOutfit4 = Outfit.yesOutfit4;
		sv.yesOutfit5 = Outfit.yesOutfit5;
		sv.yesOutfit6 = Outfit.yesOutfit6;
		sv.yesOutfit7 = Outfit.yesOutfit7;
		sv.yesOutfit8 = Outfit.yesOutfit8;
		sv.yesOutfit9 = Outfit.yesOutfit9;
		sv.yesOutfit10 = Outfit.yesOutfit10;
		sv.yesOutfit11 = Outfit.yesOutfit11;
		sv.yesOutfit12 = Outfit.yesOutfit12;
		sv.yesOutfit13 = Outfit.yesOutfit13;
		sv.yesOutfit14 = Outfit.yesOutfit14;
		sv.yesOutfit15 = Outfit.yesOutfit15;
		sv.yesOutfit16 = Outfit.yesOutfit16;
		sv.yesOutfit17 = Outfit.yesOutfit17;
		sv.yesOutfit18 = Outfit.yesOutfit18;
		sv.yesOutfit19 = Outfit.yesOutfit19;
		sv.yesOutfit20 = Outfit.yesOutfit20;
		sv.yesOutfit21 = Outfit.yesOutfit21;
		sv.yesOutfit22 = Outfit.yesOutfit22;
		sv.yesOutfit23 = Outfit.yesOutfit23;
		sv.yesOutfit24 = Outfit.yesOutfit24;
		sv.yesOutfit25 = Outfit.yesOutfit25;
		sv.yesOutfit26 = Outfit.yesOutfit26;
		sv.yesOutfit27 = Outfit.yesOutfit27;
		sv.idEmblems = Emblems.idEmblems;
		sv.AuthorityForSec = Emblems.AuthorityForSec;
		sv.yesEmblem1 = Emblems.yesEmblem1; 
		sv.yesEmblem2 = Emblems.yesEmblem2; 
		sv.yesEmblem3 = Emblems.yesEmblem3;  
		sv.yesEmblem4 = Emblems.yesEmblem4;  
		sv.yesEmblem5 = Emblems.yesEmblem5;  
		sv.yesEmblem6 = Emblems.yesEmblem6;  
		sv.yesEmblem7 = Emblems.yesEmblem7;  
		sv.yesEmblem8 = Emblems.yesEmblem8; 
		sv.authority = Authority.authority;
		sv.expAuthority = Authority.expAuthority;
		sv.needExpAuthority = Authority.needExpAuthority;
		sv.WageAuthority = Authority.WageAuthority;
		sv.lvlPartner = Partner.lvlPartner;
		sv.costUpdPartner = Partner.costUpdPartner;
		sv.totalProfitMoney = Partner.totalProfitMoney;
		sv.totalProfitExp = Partner.totalProfitExp;
		sv.lvlPartner2 = Partner.lvlPartner2;
		sv.costUpdPartner2 = Partner.costUpdPartner2;
		sv.lvlPartner3 = Partner.lvlPartner3;
		sv.costUpdPartner3 = Partner.costUpdPartner3;
		sv.buyContent = BuyBonus.buyContent;
		sv.buyContent60 = BuyBonus.buyContent60;
		sv.buyContent99 = BuyBonus.buyContent99;
		sv.buyContent159 = BuyBonus.buyContent159;
		sv.serve_year = Passport.serve_year;
		sv.serve_day = Passport.serve_day;
		sv.numServeForces = Passport.numServeForces;
		sv.militatyTicket = Passport.militatyTicket;
		sv.CadetSchool = Passport.CadetSchool;
		sv.CadetRank = Cadet.CadetRank;
		sv.NeedExpCadet = Cadet.NeedExpCadet;
		sv.CountExpCadet = Cadet.CountExpCadet; 
		sv.expCadet = Cadet.expCadet;
		sv.processCader = Cadet.processCader;
		sv.countWinForAds = Bosses.countWinForAds;
		sv.idBoss = Bosses.idBoss; // id боссов (от 1 и выше)
		sv.strength = Bosses.strength; // сила
		sv.costUpStrength = Bosses.costUpStrength; // стоимость улучшения силы
		sv.HPBoss = Bosses.HPBoss; // хп босса
		sv.HPLeft = Bosses.HPLeft; // сколько хп осталось
		sv.PrizeBoss1 = Bosses.PrizeBoss1; 
		sv.PrizeBoss2 = Bosses.PrizeBoss2; 
		sv.PrizeBoss3 = Bosses.PrizeBoss3;
		sv.PrizeBoss4 = Bosses.PrizeBoss4; 
		sv.PrizeBoss5 = Bosses.PrizeBoss5;
		sv.Boss1Win = Bosses.Boss1Win; 
		sv.Boss2Win = Bosses.Boss2Win; 
		sv.Boss3Win = Bosses.Boss3Win; 
		sv.Boss4Win = Bosses.Boss4Win; 
		sv.Boss5Win = Bosses.Boss5Win;
		sv.Timer = Bosses.Timer; // таймер битвы с боссом (в битве даётся 60 секунд)
		sv.NumWinBosses = Bosses.NumWinBosses; // число побежденных боссов
		sv.yesCourt = Court.yesCourt;
		sv.numInvestigation = Court.numInvestigation; 
		sv.chanceWinInvestigation = Court.chanceWinInvestigation; 
		sv.timeCourt = Court.timeCourt; 
		sv.maxTimeCourt = Court.maxTimeCourt;
		sv.winScroll = Court.winScroll;
		sv.winGold = Court.winGold;
		sv.xPrize = Court.xPrize; 
		sv.compensationScroll = Court.compensationScroll;
		sv.costUpdCourt1 = Court.costUpdCourt1;
		sv.costUpdCourt2 = Court.costUpdCourt2;
		sv.costUpdCourt3 = Court.costUpdCourt3;
		sv.randInvest = Court.randInvest; 
		sv.WinCourt = Court.WinCourt;
		sv.autoCourt = Court.autoCourt; 
		sv.countWinCourt = Court.countWinCourt;
		sv.totalEarnedMoney = Status.totalEarnedMoney;
		sv.percentToWage = Status.percentToWage;
		sv.goldPer10sec = Status.goldPer10sec;
		sv.lvlOffMoney = OffMoney.lvlOffMoney;
        PlayerPrefs.SetString("Save", JsonUtility.ToJson(sv));
    }
#endif
	public void OnApplicationQuit()
    {
        for (int i = 0; i < 8; i++)
        {
            sv.count[i] = Game.count[i];
        }
        for (int i = 0; i < 5; i++)
        {
            sv.medals[i] = Game.medals[i];
            sv.NumAdsForMedal[i] = Game.NumAdsForMedal[i];
        }
		sv.idLanguage = Game.idLanguage;
		sv.proVersion = Game.proVersion;
		sv.bonusForBuy = Game.bonusForBuy;
		sv.money = Game.money;
		sv.gold = Game.gold;
		sv.scroll = Game.scroll;
		sv.wage = Game.wage;
		sv.bonusMoney = Game.bonusMoney;
        sv.exp = Game.exp;
        sv.clickatonce = Game.clickatonce;
        sv.rank = Game.rank;
		sv.idForce = Game.idForce;
        sv.needExp = Game.needExp;
		sv.yesRate = Game.yesRate;
		sv.BonusFromGold = Game.BonusFromGold;
		sv.percentGoldForClick = Game.percentGoldForClick;
		sv.bonusForRate = Game.bonusForRate;
		sv.finishNavy = Game.finishNavy;
		sv.finishPolice = Game.finishPolice;
		sv.finishVDV = Game.finishVDV;
		sv.finishRHBZ = Game.finishRHBZ;
		sv.finishPolitic = Game.finishPolitic;
		sv.costSkill1 = Game.costSkill1;
		sv.costSkill2 = Game.costSkill2;
		sv.costSkill3 = Game.costSkill3;
		sv.costSkill4 = Game.costSkill4;
		sv.costSkill5 = Game.costSkill5;
		sv.costSkill6 = Game.costSkill6;
		sv.costSkill7 = Game.costSkill7;
		sv.lvlSkill1 = Game.lvlSkill1;
		sv.lvlSkill2 = Game.lvlSkill2;
		sv.lvlSkill3 = Game.lvlSkill3;
		sv.lvlSkill4 = Game.lvlSkill4;
		sv.lvlSkill5 = Game.lvlSkill5;
		sv.lvlSkill6 = Game.lvlSkill6;
		sv.lvlSkill7 = Game.lvlSkill7;
		sv.changeForces = Forces.changeForces;
		sv.idOutfit = Outfit.idOutfit;
		sv.yesOutfit1 = Outfit.yesOutfit1;
		sv.yesOutfit2 = Outfit.yesOutfit2;
		sv.yesOutfit3 = Outfit.yesOutfit3;
		sv.yesOutfit4 = Outfit.yesOutfit4;
		sv.yesOutfit5 = Outfit.yesOutfit5;
		sv.yesOutfit6 = Outfit.yesOutfit6;
		sv.yesOutfit7 = Outfit.yesOutfit7;
		sv.yesOutfit8 = Outfit.yesOutfit8;
		sv.yesOutfit9 = Outfit.yesOutfit9;
		sv.yesOutfit10 = Outfit.yesOutfit10;
		sv.yesOutfit11 = Outfit.yesOutfit11;
		sv.yesOutfit12 = Outfit.yesOutfit12;
		sv.yesOutfit13 = Outfit.yesOutfit13;
		sv.yesOutfit14 = Outfit.yesOutfit14;
		sv.yesOutfit15 = Outfit.yesOutfit15;
		sv.yesOutfit16 = Outfit.yesOutfit16;
		sv.yesOutfit17 = Outfit.yesOutfit17;
		sv.yesOutfit18 = Outfit.yesOutfit18;
		sv.yesOutfit19 = Outfit.yesOutfit19;
		sv.yesOutfit20 = Outfit.yesOutfit20;
		sv.yesOutfit21 = Outfit.yesOutfit21;
		sv.yesOutfit22 = Outfit.yesOutfit22;
		sv.yesOutfit23 = Outfit.yesOutfit23;
		sv.yesOutfit24 = Outfit.yesOutfit24;
		sv.yesOutfit25 = Outfit.yesOutfit25;
		sv.yesOutfit26 = Outfit.yesOutfit26;
		sv.yesOutfit27 = Outfit.yesOutfit27;
		sv.idEmblems = Emblems.idEmblems;
		sv.AuthorityForSec = Emblems.AuthorityForSec;
		sv.yesEmblem1 = Emblems.yesEmblem1; 
		sv.yesEmblem2 = Emblems.yesEmblem2; 
		sv.yesEmblem3 = Emblems.yesEmblem3;  
		sv.yesEmblem4 = Emblems.yesEmblem4;  
		sv.yesEmblem5 = Emblems.yesEmblem5;  
		sv.yesEmblem6 = Emblems.yesEmblem6;  
		sv.yesEmblem7 = Emblems.yesEmblem7;  
		sv.yesEmblem8 = Emblems.yesEmblem8; 
		sv.authority = Authority.authority;
		sv.expAuthority = Authority.expAuthority;
		sv.needExpAuthority = Authority.needExpAuthority;
		sv.WageAuthority = Authority.WageAuthority;
		sv.lvlPartner = Partner.lvlPartner;
		sv.costUpdPartner = Partner.costUpdPartner;
		sv.totalProfitMoney = Partner.totalProfitMoney;
		sv.totalProfitExp = Partner.totalProfitExp;
		sv.lvlPartner2 = Partner.lvlPartner2;
		sv.costUpdPartner2 = Partner.costUpdPartner2;
		sv.lvlPartner3 = Partner.lvlPartner3;
		sv.costUpdPartner3 = Partner.costUpdPartner3;
		sv.buyContent = BuyBonus.buyContent;
		sv.buyContent60 = BuyBonus.buyContent60;
		sv.buyContent99 = BuyBonus.buyContent99;
		sv.buyContent159 = BuyBonus.buyContent159;
		sv.serve_year = Passport.serve_year;
		sv.serve_day = Passport.serve_day;
		sv.numServeForces = Passport.numServeForces;
		sv.militatyTicket = Passport.militatyTicket;
		sv.CadetSchool = Passport.CadetSchool;
		sv.CadetRank = Cadet.CadetRank;
		sv.NeedExpCadet = Cadet.NeedExpCadet;
		sv.CountExpCadet = Cadet.CountExpCadet; 
		sv.expCadet = Cadet.expCadet;
		sv.processCader = Cadet.processCader;
		sv.countWinForAds = Bosses.countWinForAds;
		sv.idBoss = Bosses.idBoss; // id боссов (от 1 и выше)
		sv.strength = Bosses.strength; // сила
		sv.costUpStrength = Bosses.costUpStrength; // стоимость улучшения силы
		sv.HPBoss = Bosses.HPBoss; // хп босса
		sv.HPLeft = Bosses.HPLeft; // сколько хп осталось
		sv.PrizeBoss1 = Bosses.PrizeBoss1; 
		sv.PrizeBoss2 = Bosses.PrizeBoss2; 
		sv.PrizeBoss3 = Bosses.PrizeBoss3;
		sv.PrizeBoss4 = Bosses.PrizeBoss4; 
		sv.PrizeBoss5 = Bosses.PrizeBoss5;
		sv.Boss1Win = Bosses.Boss1Win; 
		sv.Boss2Win = Bosses.Boss2Win; 
		sv.Boss3Win = Bosses.Boss3Win; 
		sv.Boss4Win = Bosses.Boss4Win; 
		sv.Boss5Win = Bosses.Boss5Win;
		sv.Timer = Bosses.Timer; // таймер битвы с боссом (в битве даётся 60 секунд)
		sv.NumWinBosses = Bosses.NumWinBosses; // число побежденных боссов
		sv.yesCourt = Court.yesCourt;
		sv.yesCourt = Court.yesCourt;
		sv.numInvestigation = Court.numInvestigation;
		sv.chanceWinInvestigation = Court.chanceWinInvestigation;
		sv.timeCourt = Court.timeCourt;
		sv.maxTimeCourt = Court.maxTimeCourt;
		sv.winScroll = Court.winScroll;
		sv.winGold = Court.winGold;
		sv.xPrize = Court.xPrize;
		sv.compensationScroll = Court.compensationScroll;
		sv.costUpdCourt1 = Court.costUpdCourt1;
		sv.costUpdCourt2 = Court.costUpdCourt2;
		sv.costUpdCourt3 = Court.costUpdCourt3;
		sv.randInvest = Court.randInvest;
		sv.WinCourt = Court.WinCourt;
		sv.autoCourt = Court.autoCourt;
		sv.countWinCourt = Court.countWinCourt;
		sv.StatusLvl = Status.StatusLvl;
		sv.totalEarnedMoney = Status.totalEarnedMoney;
		sv.percentToWage = Status.percentToWage;
		sv.goldPer10sec = Status.goldPer10sec;
		sv.lvlOffMoney = OffMoney.lvlOffMoney;
		PlayerPrefs.SetString("Save", JsonUtility.ToJson(sv));
    }
}

[Serializable]
public class Save
{
	//==================================== Game.cs ========================
	public int idLanguage = 1; // id языка для локализации (1 - русский, 2 - английский)
	public int proVersion = 0;
	public int bonusForBuy = 1;
    public int exp = 0;
    public int clickatonce = 1;
    public int rank = 1;
    public int needExp = 100;
	public int money = 0;
	public int gold = 0;
	public int scroll = 0; // свитки
	public int wage = 0;
	public int bonusMoney = 1;
	public int idForce = 1;
	public int yesRate = 0;
	public int bonusForRate = 0;
	public int BonusFromGold = 0; // бонусные клики (за золото)
	public int percentGoldForClick = 0; // процент вероятности получения золота за клик (1% - 100. 100% - 10000)
	public int finishNavy = 0; // закончил ли службу во флоте (0 - нет, 1 - да)
	public int finishPolice = 0; // закончил ли службу в полиции
	public int finishVDV = 0, finishRHBZ = 0; // закончил ли службу в ВДВ, в РХБЗ (0 - нет, 1 - да)
	public int finishPolitic = 0;
	public int costSkill1 = 20, costSkill2 = 150, costSkill3 = 900, costSkill4 = 2000, costSkill5 = 5000,
		costSkill6 = 30, costSkill7 = 40;
	public int lvlSkill1 = 0, lvlSkill2 = 0, lvlSkill3 = 0, lvlSkill4 = 0, lvlSkill5 = 0, lvlSkill6 = 0, lvlSkill7 = 0;
	public int[] count = { 0, 0, 0, 0, 0, 0, 0, 0 }; // счётчик отсчёта от 60 до 0
    public int[] medals = { 0, 0, 0, 0, 0 }; // медали (0 - не открыт, 1 - открыт)
    public int[] NumAdsForMedal = { 5, 10, 15, 20, 30 }; // количество рекламы для открытия медали
	//=========================== Foces.cs ================================
	public int changeForces = 0;
	//=========================== Outfit.cs ==============================
	public int idOutfit = 1;
	public int yesOutfit1 = 0, yesOutfit2 = 0, yesOutfit3 = 0, yesOutfit4 = 0, yesOutfit5 = 0, 
	yesOutfit6 = 0, yesOutfit7 = 0, yesOutfit8 = 0, yesOutfit9 = 0, yesOutfit10 = 0,
	yesOutfit11 = 0, yesOutfit12 = 0, yesOutfit13 = 0, yesOutfit14 = 0, yesOutfit15 = 0, yesOutfit16 = 0, 
	yesOutfit17 = 0, yesOutfit18 = 0, yesOutfit19 = 0, yesOutfit20 = 0, yesOutfit21 = 0,
	yesOutfit22 = 0, yesOutfit23 = 0, yesOutfit24 = 0, yesOutfit25 = 0, yesOutfit26 = 0, yesOutfit27 = 0;
	//============================ Emblems.cs ============================
	public int idEmblems = 0; // id эмблемы. 0 - нет.
	public int AuthorityForSec = 0;
	public int yesEmblem1 = 0, yesEmblem2 = 0, yesEmblem3 = 0, yesEmblem4 = 0, yesEmblem5 = 0, 
	yesEmblem6 = 0, yesEmblem7 = 0, yesEmblem8 = 0;
	//============================ Authority ====================
	public int authority = 0;
	public int expAuthority = 0;
	public int needExpAuthority = 100;
	public int WageAuthority = 0;
	//========================== Partner.cs =====================
	public int totalProfitMoney = 0;
	public int totalProfitExp = 0;
	public int lvlPartner = 0;
	public int costUpdPartner = 750;
	public int lvlPartner2 = 0;
	public int costUpdPartner2 = 3000;
	public int lvlPartner3 = 0;
	public int costUpdPartner3 = 8500;
	//========================= BuyBonus ==================
	public int buyContent = 0;
	public int buyContent60 = 0; // куплен ли контент за 60 (0 - нет, 1 - да).
	public int buyContent99 = 0; // куплен ли контент за 99 (0 - нет, 1 - да).
	public int buyContent159 = 0; // куплен ли контент за 159 (0 - нет, 1 - да).
	//======================== Passport =====================
	public int serve_year = 0; // сколько лет отслужил (ВЫСЛУГА ЛЕТ)
	public int serve_day = 0; // сколько дней отслужил (как доходит до 365 - serve_year += 1, serve_day = 0;)
	public int numServeForces = 0; // сколько раз отслужил в войсках
	public int militatyTicket = 0; // военный билет (даётся только при достижении генерала армии)
	public int CadetSchool = 0;
	//======================= Cadet.cs ======================
	public int CadetRank = 1;
	public int NeedExpCadet = 4000;
	public int CountExpCadet = 0; // накапливает общее количество набранного опыта кадета
	public int expCadet = 0;
	public int processCader = 0; // обучаешься ли в кадетской школе в данный момент (0- нет, 2 - да)
	//======================= Bosses.cs ========================
	public int idBoss = 1; // id боссов (от 1 и выше)
	public int strength = 0; // сила
	public int costUpStrength = 1000; // стоимость улучшения силы
	public int HPBoss = 400; // хп босса
	public int HPLeft = 0; // сколько хп осталось
	public int PrizeBoss1 = 1000; 
	public int PrizeBoss2 = 4500; 
	public int PrizeBoss3 = 21000;
	public int PrizeBoss4 = 42500; 
	public int PrizeBoss5 = 155000;
	public int Boss1Win = 0; 
	public int Boss2Win = 0; 
	public int Boss3Win = 0; 
	public int Boss4Win = 0; 
	public int Boss5Win = 0;
	public int Timer = 0; // таймер битвы с боссом (в битве даётся 60 секунд)
	public int NumWinBosses = 0; // число побежденных боссов
	public int countWinForAds = 0; // счётчик, который считает кол-во побеждённых боссов. Доходит до 4 и включается реклама
	//=========================== Court.cs ========================
	public int yesCourt = 0; // открыт ли суд (1 - да, 0 - нет)
	public int numInvestigation = 1; // номер дела
	public int chanceWinInvestigation = 10; // шанс выиграть дело (изначально 10 процентов)
	public int timeCourt = -1; // время суда (суд будет идти 2 минуты)
	public int maxTimeCourt = 120;
	public int winScroll = 0;
	public int winGold = 0;
	public int xPrize = 1; // множитель призов
	public int compensationScroll = 0;
	public int costUpdCourt1 = 10;
	public int costUpdCourt2 = 20;
	public int costUpdCourt3 = 100;
	public int randInvest = 0; // номер дела для описания (рандом)
	public int WinCourt = 0; // выигран ли суд (0 - выключено, 1 - нет, 2 - да)
	public int autoCourt = 0; // автоматически забирает приз суда и начинает новый (0 - нет, 1 - нет)
	public int countWinCourt = 0; // счётчик, сколько судебных дел выиграно
	//=================================== Status.cs =========================
	public int StatusLvl = 0; // уровень статуса
	public int totalEarnedMoney = 0; // общее количество заработанных денег
	public int percentToWage = 0; // процент от заработка
	public int goldPer10sec = 0; // золота за 10 сек
								 //=================================== OfflineMoney.cs =======================
	public int lvlOffMoney = 0; // от 0 до 5. / 1 - (60м, 10%), 2 - (60м, 20%), 3 - (3ч, 20%), 4 - (12ч, 25%), 5 - (24ч, 50%)
}
