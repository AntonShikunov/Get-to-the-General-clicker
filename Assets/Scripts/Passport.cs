using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Passport : MonoBehaviour {

	public static int serve_year = 0; // сколько лет отслужил (ВЫСЛУГА ЛЕТ)
	public static int serve_day = 0; // сколько дней отслужил (как доходит до 365 - serve_year += 1, serve_day = 0;)
	public static int numServeForces = 0; // сколько раз отслужил в войсках
	public static int militatyTicket = 0; // военный билет (даётся только при достижении генерала армии)
	public static int CadetSchool = 0; // пройдена ли кадетская школа (0 - нет, 1 - да)

	public Text NumWinBossesText; // сколько боссов побеждено (ТЕКСТ)
	public Text NumWinCourtsText; // сколько судебных дел побеждено
	public Text NumRankText, RankText;
	public Text ServeYearsText; // текст выслуги лет
	public Text NumServeForcesеText; // текст сколько раз отслужил в войсках
	public Text MilitatyTicketText; // текст есть ли военный билет
	public Text CadetSchoolText; // текст пройдена ли кадетская школа
	public Text TotalWageText; // текст общая зарплата
	public GameObject canvas, PlusServeYearPref;

	public int oklad = 0; // оклад зп, зависит от ранга. Проверяется в этом скрипте и нужен только тут

	public string ticket = "";
	public string cadet = "";

	void Start() {
		StartCoroutine(goServe());
	}

	void Update() {
		CheckWage ();
		if (Game.idLanguage == 1) {
			if (militatyTicket == 0)
				ticket = "НЕТ";
			if (militatyTicket == 1)
				ticket = "ДА";

			if (CadetSchool == 0)
				cadet = "НЕТ";
			if (CadetSchool == 1)
				cadet = "ДА";
		}
		if (Game.idLanguage == 2) {
			if (militatyTicket == 0)
				ticket = "NO";
			if (militatyTicket == 1)
				ticket = "YES";

			if (CadetSchool == 0)
				cadet = "NO";
			if (CadetSchool == 1)
				cadet = "YES";
		}
		TotalWageText.text = "" + ((((oklad + Game.bonusMoney) + Authority.WageAuthority) * Game.WageForCadet) + Partner.totalProfitMoney).ToString("N0");
		NumRankText.text = "" + Game.rank.ToString("N0");
		if (Game.idLanguage == 1)
			ServeYearsText.text = serve_year + " ЛЕТ " + serve_day + " ДНЕЙ";
		if (Game.idLanguage == 2)
			ServeYearsText.text = serve_year + " YEARS " + serve_day + " DAYS";
		NumServeForcesеText.text = "" + numServeForces;
		MilitatyTicketText.text = "" + ticket;
		CadetSchoolText.text = "" + cadet;
		NumWinCourtsText.text = "" + Court.countWinCourt;
		NumWinBossesText.text = "" + Bosses.NumWinBosses.ToString("N0");
		if (Game.idForce == 1) {
			if (Game.idLanguage == 1)
				RankText.text = Game.nameRank[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
			if (Game.idLanguage == 2)
				RankText.text = Localization.nameRank_EN[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
		}
		if (Game.idForce == 2) {
			if (Game.idLanguage == 1)
				RankText.text = Game.nameRankNavy[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
			if (Game.idLanguage == 2)
				RankText.text = Localization.nameRankNavy_EN[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
		}
		if (Game.idForce == 3) {
			if (Game.idLanguage == 1)
				RankText.text = Game.nameRankPolice[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
			if (Game.idLanguage == 2)
				RankText.text = Localization.nameRankPolice_EN[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
		}
		if (Game.idForce == 4) {
			if (Game.idLanguage == 1)
				RankText.text = Game.nameRankFBI[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
			if (Game.idLanguage == 2)
				RankText.text = Localization.nameRankFBI_EN[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
		}
		if (Game.idForce == 5) {
			if (Game.idLanguage == 1)
				RankText.text = Game.nameRankSPY[Game.rank - 1]; 		// ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
			if (Game.idLanguage == 2)
				RankText.text = Localization.nameRankSPY_EN[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
		}
		if (Game.idForce == 6) {
			if (Game.idLanguage == 1)
				RankText.text = Game.nameRankSpace[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS 
			if (Game.idLanguage == 2)
				RankText.text = Localization.nameRankSpace_EN[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
		}
		if (Game.idForce == 7) {
			if (Game.idLanguage == 1)
				RankText.text = Game.nameRankVDV[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
			if (Game.idLanguage == 2)
				RankText.text = Localization.nameRankVDV_EN[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
		}
		if (Game.idForce == 8) {
			if (Game.idLanguage == 1)
				RankText.text = Game.nameRankRHBZ[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
			if (Game.idLanguage == 2)
				RankText.text = Localization.nameRankRHBZ_EN[Game.rank - 1]; // ЭТО ЖЕ ДОБАВИТЬ В PASSPORT.CS
		}
	}

			public void CheckWage() {
				if (Game.rank == 1)
					oklad = 0;
				if (Game.rank == 2)
					oklad = 1;
				if (Game.rank == 3)
					oklad = 2;
				if (Game.rank == 4)
					oklad = 3;
				if (Game.rank == 5)
					oklad = 4;
				if (Game.rank == 6)
					oklad = 5;
				if (Game.rank == 7)
					oklad = 6;
				if (Game.rank == 8)
					oklad = 7;
				if (Game.rank == 9)
					oklad = 8;
				if (Game.rank == 10)
					oklad = 9;
				if (Game.rank == 11)
					oklad = 10;
				if (Game.rank == 12)
					oklad = 12;
				if (Game.rank == 12)
					oklad = 15;
				if (Game.rank == 13)
					oklad = 18;
				if (Game.rank == 14)
					oklad = 20;
				if (Game.rank == 15)
					oklad = 24;
				if (Game.rank == 16)
					oklad = 30;
				if (Game.rank == 17)
					oklad = 40;
				if (Game.rank == 18)
					oklad = 50;
				if (Game.rank == 19)
					oklad = 100;
			}
		

	public IEnumerator goServe() { // служба
		while (true) {
			serve_day += 1;
			if (serve_day >= 365) {
				serve_year += 1;
				serve_day = 0;
				GameObject money_obj = Instantiate(PlusServeYearPref, PlusServeYearPref.transform.position, Quaternion.identity) as GameObject;
				money_obj.transform.SetParent(canvas.transform);
				money_obj.transform.localScale = new Vector3 (1f, 1f, 1f);
				money_obj.transform.localPosition = new Vector3 (18f, 160f, 0f);
				Destroy(money_obj, 3f);

			}
			yield return new WaitForSeconds (2f);
		}
	}

}
