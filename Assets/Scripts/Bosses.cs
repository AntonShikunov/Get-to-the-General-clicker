using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Bosses : MonoBehaviour {

	public static int use30sec = 0; // использован ли бонус "30 сек" (0 - нет, 1 - да)
	public static int idBoss = 1; // id боссов (от 1 и выше)
	public static int strength = 0; // сила
	public static int costUpStrength = 1500; // стоимость улучшения силы
	public static int HPBoss = 400; // хп босса
	public static int HPLeft = 0; // сколько хп осталось
	public static int PrizeBoss1 = 1000, PrizeBoss2 = 4500, PrizeBoss3 = 21000, PrizeBoss4 = 42500, PrizeBoss5 = 155000;
	public static int Boss1Win = 0, Boss2Win = 0, Boss3Win = 0, Boss4Win = 0, Boss5Win = 0;
	public static int Timer = 60; // таймер битвы с боссом (в битве даётся 60 секунд)
	public static int NumWinBosses = 0; // число побежденных боссов
	public static int countWinForAds = 0; // счётчик, который считает кол-во побеждённых боссов. Доходит до 4 и включается реклама

	public Slider HPSlider;

	public GameObject FightPan, EndFightPan;
	public GameObject BlockBoss; // блокировка боссов, если нет 3 года выслуги лет

	public Image BossImage;
	public Sprite BossSprite1, BossSprite2, BossSprite3, BossSprite4, BossSprite5;
	public Image ImagePrizeOutfit;
	public GameObject PrizeOutfitObj; // объект, который скрывается, если не выбил одежду

	public GameObject Use30secBttn;
	public GameObject clickParent;
	public GameObject DamageTextPref;
	public GameObject OkBttn; // кнопка "Отлично", чтоб закрыть панель выигрыша
	public Button Boss2, Boss3, Boss4, Boss5;

	//public Text TimerText;
	public Text MoneyText;
	public Text StrengthText;
	public Text HowHPText;
	public Text CostUpStrengthText;
	public Text PrizeMoneyText;
	public Text PrizeMoneyText1, PrizeMoneyText2, PrizeMoneyText3, PrizeMoneyText4, PrizeMoneyText5; // текста призов за боссы, которые уменьшаются

	void Update () {
		if (Timer <= 35 && use30sec == 0) {
			Use30secBttn.SetActive (true);
		}
		if (use30sec == 1)
			Use30secBttn.SetActive (false);
		if (Passport.serve_year < 5)
			BlockBoss.SetActive (true);
		if (Passport.serve_year >= 5)
			BlockBoss.SetActive (false);
		if (Boss1Win == 0)
			Boss2.interactable = false;
		else
			Boss2.interactable = true;
		if (Boss2Win == 0)
			Boss3.interactable = false;
		else
			Boss3.interactable = true;
		if (Boss3Win == 0)
			Boss4.interactable = false;
		else 
			Boss4.interactable = true;
		if (Boss4Win == 0)
			Boss5.interactable = false;
		else
			Boss5.interactable = true;
		HPSlider.maxValue = HPBoss;
		HPSlider.value = HPLeft;
		HowHPText.text = HPLeft.ToString("N0") + " / " + HPBoss.ToString("N0");
		StrengthText.text = "" + strength.ToString("N0");
		CostUpStrengthText.text = "" + costUpStrength.ToString("N0");
		MoneyText.text = "" + Game.money.ToString("N0");
		DamageTextPref.GetComponent<Text>().text = "-" + strength.ToString("N0");
		if (Game.idLanguage == 1) {
			PrizeMoneyText1.text = "ПРИЗ: " + PrizeBoss1.ToString ("N0");
			PrizeMoneyText2.text = "ПРИЗ: " + PrizeBoss2.ToString ("N0");
			PrizeMoneyText3.text = "ПРИЗ: " + PrizeBoss3.ToString ("N0");
			PrizeMoneyText4.text = "ПРИЗ: " + PrizeBoss4.ToString ("N0");
			PrizeMoneyText5.text = "ПРИЗ: " + PrizeBoss5.ToString ("N0");
		}
		if (Game.idLanguage == 2) {
			PrizeMoneyText1.text = "PRIZE: " + PrizeBoss1.ToString ("N0");
			PrizeMoneyText2.text = "PRIZE: " + PrizeBoss2.ToString ("N0");
			PrizeMoneyText3.text = "PRIZE:: " + PrizeBoss3.ToString ("N0");
			PrizeMoneyText4.text = "PRIZE: " + PrizeBoss4.ToString ("N0");
			PrizeMoneyText5.text = "PRIZE: " + PrizeBoss5.ToString ("N0");
		}
		if (idBoss == 1)
			BossImage.sprite = BossSprite1;
		if (idBoss == 2)
			BossImage.sprite = BossSprite2;
		if (idBoss == 3)
			BossImage.sprite = BossSprite3;
		if (idBoss == 4)
			BossImage.sprite = BossSprite4;
		if (idBoss == 5)
			BossImage.sprite = BossSprite5;
	}

	public void UpStrength() {
		if (Game.money >= costUpStrength) {
			strength += 1;
			Game.money -= costUpStrength;
			int proc = ((costUpStrength * 10) / 100);
			costUpStrength += proc;
		}
	}

	public void clickToBoss() {
		HPLeft -= strength;
		GameObject money_obj = Instantiate(DamageTextPref, DamageTextPref.transform.position, Quaternion.identity) as GameObject;
		money_obj.transform.SetParent(clickParent.transform);
		money_obj.transform.localScale = new Vector3 (1f, 1f, 1f);
		money_obj.transform.localPosition = new Vector3 (Random.Range(-180,181), 160f, 0f);
		Destroy(money_obj, 2f);
		if (HPLeft <= 0) {
			FinishFight();
		}
	}

	public void goBoss1() { // запуск 1 босса
		FightPan.SetActive (true);
		HPBoss = 400;
		HPLeft = 400;
		idBoss = 1;
		Timer = 60;
	}

	public void goBoss2() { // запуск 2 босса
		FightPan.SetActive (true);
		HPBoss = 1800;
		HPLeft = 1800;
		idBoss = 2;
		Timer = 60;
	}

	public void goBoss3() { // запуск 3 босса
		FightPan.SetActive (true);
		HPBoss = 8800;
		HPLeft = 8800;
		idBoss = 3;
		Timer = 60;
	}

	public void goBoss4() { // запуск 4 босса
		FightPan.SetActive (true);
		HPBoss = 19750;
		HPLeft = 19750;
		idBoss = 4;
		Timer = 60;
	}

	public void goBoss5() { // запуск 5 босса
		FightPan.SetActive (true);
		HPBoss = 61000;
		HPLeft = 61000;
		idBoss = 5;
		Timer = 60;
	}

	public void FinishFight() { // метод вызывается, если победил босса
		countWinForAds += 1;
		if (idBoss == 1) { // если победил босса 1
			Boss1Win = 1;
			PrizeMoneyText.text = "" + PrizeBoss1;
			Game.money += PrizeBoss1;
			Status.totalEarnedMoney += PrizeBoss1;
			Timer = 0;
			if (PrizeBoss1 > 100) {
				int proc = ((PrizeBoss1 * 20) / 100);
				PrizeBoss1 -= proc;
			}
			int random = Random.Range (1, 101);
			if (random >= 92) {
				Outfit.yesOutfit22 = 1;
				PrizeOutfitObj.SetActive (true);
				ImagePrizeOutfit.sprite = BossSprite1;
			}
			else PrizeOutfitObj.SetActive (false);
		}
		if (idBoss == 2) { // если победил босса 2
			Boss2Win = 1;
			PrizeMoneyText.text = "" + PrizeBoss2;
			Game.money += PrizeBoss2;
			Status.totalEarnedMoney += PrizeBoss2;
			Timer = 0;
			if (PrizeBoss2 > 500) {
				int proc = ((PrizeBoss2 * 20) / 100);
				PrizeBoss2 -= proc;
			}
			int random = Random.Range (1, 101);
			if (random >= 92) {
				Outfit.yesOutfit23 = 1;
				PrizeOutfitObj.SetActive (true);
				ImagePrizeOutfit.sprite = BossSprite2;
			}
			else PrizeOutfitObj.SetActive (false);
		}
		if (idBoss == 3) { // если победил босса 3
			Boss3Win = 1;
			PrizeMoneyText.text = "" + PrizeBoss3;
			Game.money += PrizeBoss3;
			Status.totalEarnedMoney += PrizeBoss3;
			Timer = 0;
			if (PrizeBoss3 > 1000) {
				int proc = ((PrizeBoss3 * 20) / 100);
				PrizeBoss3 -= proc;
			}
			int random = Random.Range (1, 101);
			if (random >= 92) {
				PrizeOutfitObj.SetActive (true);
				ImagePrizeOutfit.sprite = BossSprite3;
				Outfit.yesOutfit24 = 1;
			}
			else PrizeOutfitObj.SetActive (false);
		}
		if (idBoss == 4) { // если победил босса 4
			Boss4Win = 1;
			PrizeMoneyText.text = "" + PrizeBoss4;
			Game.money += PrizeBoss4;
			Status.totalEarnedMoney += PrizeBoss4;
			Timer = 0;
			if (PrizeBoss4 > 1000) {
				int proc = ((PrizeBoss4 * 20) / 100);
				PrizeBoss4 -= proc;
			}
			int random = Random.Range (1, 101);
			if (random >= 92) {
				Outfit.yesOutfit25 = 1;
				PrizeOutfitObj.SetActive (true);
				ImagePrizeOutfit.sprite = BossSprite4;
			}
			else PrizeOutfitObj.SetActive (false);
		}
		if (idBoss == 5) { // если победил босса 5
			Boss5Win = 1;
			PrizeMoneyText.text = "" + PrizeBoss5;
			Game.money += PrizeBoss5;
			Status.totalEarnedMoney += PrizeBoss5;
			Timer = 0;
			if (PrizeBoss5 > 1000) {
				int proc = ((PrizeBoss5 * 20) / 100);
				PrizeBoss5 -= proc;
			}
			int random = Random.Range (1, 101);
			if (random >= 92) {
				PrizeOutfitObj.SetActive (true);
				ImagePrizeOutfit.sprite = BossSprite5;
				Outfit.yesOutfit26 = 1;
			}
			else PrizeOutfitObj.SetActive (false);
		}
		if (countWinForAds >= 4)
		{
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			countWinForAds = 0;
		}
		FightPan.SetActive (false);
		Invoke("OkBttnVisible", 2f);
		EndFightPan.SetActive(true);
		NumWinBosses += 1;
		use30sec = 0;
		Timer = 60;
	}

	public void EndFightPan_Close() {
		EndFightPan.SetActive (false);
		OkBttn.SetActive (false);
		use30sec = 0;
	}

	public void CancelFight() {
		Timer = 0;
		FightPan.SetActive (false);
	}

	public void Plus30Sec() {
		if (Advertisement.IsReady())
		{
			ShowOptions option = new ShowOptions();
			option.resultCallback = HandleShowResult;
			Advertisement.Show("rewardedVideo", option);
		}
	}

	public void OkBttnVisible() {
		OkBttn.SetActive (true);
	}

	public static IEnumerator TimerFight() {
		while (true) {
			if (Timer > 0) {
				Timer -= 1;
			}
			yield return new WaitForSeconds (1f);
		}
	}

	public void HandleShowResult(ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			Debug.Log ("The ad was successfully shown.");
			Timer += 30;
			use30sec = 1;
			Use30secBttn.SetActive (false);
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
