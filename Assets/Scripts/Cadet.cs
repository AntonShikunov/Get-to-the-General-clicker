//using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class Cadet : MonoBehaviour {

	public static int CadetRank = 1;
	public static int NeedExpCadet = 4000;
	public static int CountExpCadet = 0; // накапливает общее количество набранного опыта кадета
	public static int expCadet = 0;
	public static int processCader = 0; // обучаешься ли в кадетской школе в данный момент (0- нет, 1 - да)

	public int[] expForRankCadet = { 1000, 3000, 5500, 9000, 14000, 20000, 35000, 70000};
	public static string[] nameRankCadet = { "КАДЕТ", "КАДЕТ 1 РАНГА", "ВИЦЕ-ЕФРЕЙТОР", "МЛАДШИЙ ВИЦЕ-СЕРЖАНТ", "ВИЦЕ-СЕРЖАНТ", 
		"СТАРШИЙ ВИЦЕ-СЕРЖАНТ", "ВИЦЕ-СТАРШИНА", "СТАРШИНА КАДЕТСТВА"};

	public GameObject RangBttn, RangCadetBttn; // иконка погон, в зависимости от размера картинки (косм.силы - 512)

	public Image CadetImg;
	public Sprite Cadet_1, Cadet_2, Cadet_3, Cadet_4, Cadet_5, Cadet_6, Cadet_7, Cadet_8;

	public Slider CadetSchoolSlider;
	public Slider CadetExpSlider;
	/*public GameObject[] blockBttns = new GameObject[8];
	public GameObject[] waitBttns = new GameObject[8];
	public GameObject[] WatchAdBttn = new GameObject[5];*/
	public ClickObj[] clickTextPool = new ClickObj[15];

	public GameObject CadetSliderObj, ArmySliderObj;
	public GameObject StartCadetSchoolBttn, CancelCadetSchoolBttn, EndCadetObj;
	public GameObject CadetPan;
	public GameObject EndCadetPan;
	public GameObject PlusGoldPref;
	public GameObject clickParent;

	public Text BonusText;

	public static int ost = 0;


	public int clickNum = 0;

	void Update() {
		if (processCader == 1) {
			ArmySliderObj.SetActive (false);
			CadetSliderObj.SetActive (true);
			RangBttn.SetActive (false);
			RangCadetBttn.SetActive (true);
			StartCadetSchoolBttn.SetActive (false);
			CancelCadetSchoolBttn.SetActive (true);
			//RankCadetText.text = "" + nameRankCadet[CadetRank - 1];
			CadetExpSlider.value = expCadet;
			NeedExpCadet = expForRankCadet[CadetRank - 1];
			CadetExpSlider.maxValue = NeedExpCadet;
			checkRankCadet();
		}
		if (processCader == 0) {
			ArmySliderObj.SetActive (true);
			CadetSliderObj.SetActive (false);
			RangBttn.SetActive (true);
			/*RangImg.SetActive (true);
			RangImg512.SetActive (true);*/
			RangCadetBttn.SetActive (false);
			CancelCadetSchoolBttn.SetActive (false);
			//RankCadetText.text = "";
		}
		if (processCader == 0 && Passport.CadetSchool == 0) {
			CadetSchoolSlider.maxValue = 9;
			CadetSchoolSlider.value = 0;
			StartCadetSchoolBttn.SetActive (true);
			CancelCadetSchoolBttn.SetActive (false);
			ArmySliderObj.SetActive (true);
			CadetSliderObj.SetActive (false);
			RangBttn.SetActive (true);
			RangCadetBttn.SetActive (false);
			CadetRank = 1;
			CountExpCadet = 0;
			expCadet = 0;
		}
		if (processCader == 1 && Passport.CadetSchool == 0) {
			CadetSchoolSlider.maxValue = 9;
			CadetSchoolSlider.value = CadetRank;
		}
		if (processCader == 0 && Passport.CadetSchool == 1) {
			CadetSchoolSlider.maxValue = 9;
			CadetSchoolSlider.value = 9;
			StartCadetSchoolBttn.SetActive (false);
			EndCadetObj.SetActive (true);
		}
	}

	public void StartCadetSchool() {
		if (Passport.CadetSchool == 0 && Emblems.idEmblems > 0) {
			processCader = 1;
			RangBttn.SetActive (false);
			RangCadetBttn.SetActive (true);
			CadetPan.SetActive (false);
		}
	}

	public void ClickRankCadet()
	{
		clickNum += 1;
		if (Game.countBonus == 0)
		{
			Game.countBonus = 0;
			Game.bonusForClick = 1;
			BonusText.text = "";
		}
		if (Game.bonusForClick > 1)
			Game.countBonus -= 1;
		if (clickNum >= 14)
		{
			clickNum = 0;
		}
		Game.clickTextPool[clickNum].StartMotion((((Game.clickatonce + Game.bonusForRate) * Game.bonusForBuy) * Game.bonusForClick) + Game.BonusFromGold);
		//Destroy(clickTextPool[clickNum], 2f);
		clickNum = clickNum == Game.clickTextPool.Length - 1 ? 0 : clickNum + 1;
		expCadet += ((((Game.clickatonce + Game.bonusForRate) * Game.bonusForBuy) * Game.bonusForClick) + Game.BonusFromGold);
		CountExpCadet += ((((Game.clickatonce + Game.bonusForRate) * Game.bonusForBuy) * Game.bonusForClick) + Game.BonusFromGold);
		//CadetSchoolSlider.value += (((Game.clickatonce + Game.bonusForRate) * Game.bonusForBuy) * Game.bonusForClick);
		if (expCadet >= NeedExpCadet) {
			ost = expCadet - NeedExpCadet;
			if (CadetRank < 8)
				upRankCadet ();
			if (CadetRank >= 8 && expCadet >= 70000)
				endCadetSchool();
		}
		int randGold = 0;
		randGold = Random.Range(0, 10000);
		if (randGold <= (10 + Game.percentGoldForClick))
		{
			Game.gold += 1;
			GameObject gold_obj = Instantiate(PlusGoldPref, PlusGoldPref.transform.position, Quaternion.identity) as GameObject;
			gold_obj.transform.SetParent(clickParent.transform);
			gold_obj.transform.localScale = new Vector3(1f, 1f, 1f);
			gold_obj.transform.localPosition = new Vector3(-20f, 160f, 0f);
			Destroy(gold_obj, 3f);
		}

	}

	public void checkRankCadet() {
		if (CadetRank == 1) {
			CadetImg.sprite = Cadet_1;
		}
		if (CadetRank == 2) {
			CadetImg.sprite = Cadet_2;
		}
		if (CadetRank == 3) {
			CadetImg.sprite = Cadet_3;
		}
		if (CadetRank == 4) {
			CadetImg.sprite = Cadet_5;
		}
		if (CadetRank == 5) {
			CadetImg.sprite = Cadet_5;
		}
		if (CadetRank == 6) {
			CadetImg.sprite = Cadet_6;
		}
		if (CadetRank == 7) {
			CadetImg.sprite = Cadet_7;
		}
		if (CadetRank == 8) {
			CadetImg.sprite = Cadet_8;
		}
	}

	public void upRankCadet() {
		CadetRank += 1;
		NeedExpCadet = expForRankCadet[CadetRank - 1];
		CadetExpSlider.maxValue = NeedExpCadet;
		CadetExpSlider.value = 0;
		expCadet = ost;
	}

	public void endCadetSchool() {
		ArmySliderObj.SetActive (true);
		CadetSliderObj.SetActive (false);
		RangBttn.SetActive (true);
		RangCadetBttn.SetActive (false);
		Passport.CadetSchool = 1;
		processCader = 0;
		EndCadetPan.SetActive (true);
	}

	public void cancelCadetSchool() {
		processCader = 0;
		CadetPan.SetActive (false);
	}

	public void EndCadetPan_close() {
		EndCadetPan.SetActive (false);
	}


}
