using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Partner : MonoBehaviour {

	public static int lvlPartner = 0;
	public static int costUpdPartner = 750;
	public static int lvlPartner2 = 0;
	public static int costUpdPartner2 = 3000;
	public static int lvlPartner3 = 0;
	public static int costUpdPartner3 = 8500;

	public static int totalProfitMoney = 0;
	public static int totalProfitExp = 0;
	public GameObject rankText, PartnerImg;

	public Text LvlPartner1Text;
	public Text CostUpdPartner1;
	public Text LvlPartner2Text;
	public Text CostUpdPartner2;
	public Text LvlPartner3Text;
	public Text CostUpdPartner3;
	public Text ProfitMoneyPartnerText;
	public Text ProfitExpPartnerText;

	void Update () {
		LvlPartner1Text.text = "LVL: " + lvlPartner;
		CostUpdPartner1.text = "" + costUpdPartner.ToString("N0");
		LvlPartner2Text.text = "LVL: " + lvlPartner2;
		CostUpdPartner2.text = "" + costUpdPartner2.ToString("N0");
		LvlPartner3Text.text = "LVL: " + lvlPartner3;
		CostUpdPartner3.text = "" + costUpdPartner3.ToString("N0");
		ProfitMoneyPartnerText.text = totalProfitMoney.ToString("N0") + " / 3 сек";
		ProfitExpPartnerText.text = totalProfitExp.ToString("N0") + " exp / 3 сек";
		if (Game.rank < 8 && Game.idForce == 1) {
			rankText.SetActive (true);
			PartnerImg.SetActive (false);
		}
		if (Game.idForce == 1 && Game.rank >= 8) {
			rankText.SetActive (false);
			PartnerImg.SetActive (true);
		}
		if (Game.idForce > 1) {
			rankText.SetActive (false);
			PartnerImg.SetActive (true);
		}
	}

	public void upPartner() {
		if (Game.money >= costUpdPartner) {
			Game.money -= costUpdPartner;
			lvlPartner += 1;
			totalProfitMoney += 5;
			totalProfitExp += 10;
			int proc = ((costUpdPartner * 30) / 100);
			costUpdPartner += proc;
		}
	}

	public void upPartner2() {
		if (Game.money >= costUpdPartner2) {
			Game.money -= costUpdPartner2;
			lvlPartner2 += 1;
			totalProfitMoney += 7;
			totalProfitExp += 13;
			int proc = ((costUpdPartner2 * 30) / 100);
			costUpdPartner2 += proc;
		}
	}

	public void upPartner3() {
		if (Game.money >= costUpdPartner3) {
			Game.money -= costUpdPartner3;
			lvlPartner3 += 1;
			totalProfitMoney += 10;
			totalProfitExp += 15;
			int proc = ((costUpdPartner3 * 30) / 100);
			costUpdPartner3 += proc;
		}
	}
}
