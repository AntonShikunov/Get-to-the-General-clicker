using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Emblems : MonoBehaviour {

	public static int idEmblems = 0; // id эмблемы. 0 - нет.
	public static int AuthorityForSec = 0;

	public Text rankText;
	public GameObject EmblemObj;
	public Image EmblemImg;
	public Sprite Emblem1, Emblem2, Emblem3, Emblem4, Emblem5, Emblem6, Emblem7, Emblem8;

	public static int costEmblem1 = 400, costEmblem2 = 900, costEmblem3 = 2000, costEmblem4 = 4200, costEmblem5 = 9000, 
	costEmblem6 = 21000, costEmblem7 = 48000, costEmblem8 = 122000;

	public static int yesEmblem1 = 0, yesEmblem2 = 0, yesEmblem3 = 0, yesEmblem4 = 0, yesEmblem5 = 0, 
	yesEmblem6 = 0, yesEmblem7 = 0, yesEmblem8 = 0;

	public GameObject costEmblemObj1, costEmblemObj2, costEmblemObj3, costEmblemObj4, costEmblemObj5,
	costEmblemObj6, costEmblemObj7, costEmblemObj8;

	public GameObject NeedEmblemText;


	void Update () {
		if (idEmblems == 0) {
			EmblemObj.SetActive (false);
			NeedEmblemText.SetActive (true);
		}
		if (idEmblems > 0) {
			EmblemObj.SetActive (true);
			NeedEmblemText.SetActive (false);
		}
		if (Game.rank < 12 && Game.idForce == 1) {
			if (Game.idLanguage == 1)
				rankText.text = "ДОСТУПНО С 12 РАНГА";
			if (Game.idLanguage == 2)
				rankText.text = "AVAILABLE FROM 12 RANK";
			AuthorityForSec = 0;
			NeedEmblemText.SetActive (true);
		}
		if (Game.rank >= 12 && Game.idForce >= 1 && idEmblems == 0) {
			if (Game.idLanguage == 1)
				rankText.text = "ВЫБЕРИТЕ ВАШУ ЭМБЛЕМУ";
			if (Game.idLanguage == 2)
				rankText.text = "CHOOSE YOUR EMBLEM";
			AuthorityForSec = 0;
			NeedEmblemText.SetActive (true);
		}
		if (idEmblems >= 1) {
			rankText.text = "";
		}
		if (idEmblems == 1) {
			EmblemImg.sprite = Emblem1;
			AuthorityForSec = 1;
		}
		if (idEmblems == 2) {
			EmblemImg.sprite = Emblem2;
			AuthorityForSec = 2;
		}
		if (idEmblems == 3) {
			EmblemImg.sprite = Emblem3;
			AuthorityForSec = 5;
		}
		if (idEmblems == 4) {
			EmblemImg.sprite = Emblem4;
			AuthorityForSec = 10;
		}
		if (idEmblems == 5) {
			EmblemImg.sprite = Emblem5;
			AuthorityForSec = 20;
		}
		if (idEmblems == 6) {
			EmblemImg.sprite = Emblem6;
			AuthorityForSec = 45;
		}
		if (idEmblems == 7) {
			EmblemImg.sprite = Emblem7;
			AuthorityForSec = 100;
		}
		if (idEmblems == 8) {
			EmblemImg.sprite = Emblem8;
			AuthorityForSec = 250;
		}

		if (yesEmblem1 == 1) {
			costEmblemObj1.SetActive (false);
		}
		if (yesEmblem2 == 1) {
			costEmblemObj2.SetActive (false);
		}
		if (yesEmblem3 == 1) {
			costEmblemObj3.SetActive (false);
		}
		if (yesEmblem4 == 1) {
			costEmblemObj4.SetActive (false);
		}
		if (yesEmblem5 == 1) {
			costEmblemObj5.SetActive (false);
		}
		if (yesEmblem6 == 1) {
			costEmblemObj6.SetActive (false);
		}
		if (yesEmblem7 == 1) {
			costEmblemObj7.SetActive (false);
		}
		if (yesEmblem8 == 1) {
			costEmblemObj8.SetActive (false);
		}
			
	}

	public void goEmblem1() {
		if (yesEmblem1 == 0 && Game.money >= costEmblem1) {
			Game.money -= costEmblem1;
			yesEmblem1 = 1;
			idEmblems = 1;
		}
		if (yesEmblem1 == 1)
			idEmblems = 1;
	}

	public void goEmblem2() {
		if (yesEmblem2 == 0 && Game.money >= costEmblem2) {
			Game.money -= costEmblem2;
			yesEmblem2 = 1;
			idEmblems = 2;
		}
		if (yesEmblem2 == 1)
			idEmblems = 2;
	}

	public void goEmblem3() {
		if (yesEmblem3 == 0 && Game.money >= costEmblem3) {
			Game.money -= costEmblem3;
			yesEmblem3 = 1;
			idEmblems = 3;
		}
		if (yesEmblem3 == 1)
			idEmblems = 3;
	}

	public void goEmblem4() {
		if (yesEmblem4 == 0 && Game.money >= costEmblem4) {
			Game.money -= costEmblem4;
			yesEmblem4 = 1;
			idEmblems = 4;
		}
		if (yesEmblem4 == 1)
			idEmblems = 4;
	}

	public void goEmblem5() {
		if (yesEmblem5 == 0 && Game.money >= costEmblem5) {
			Game.money -= costEmblem5;
			yesEmblem5 = 1;
			idEmblems = 5;
		}
		if (yesEmblem5 == 1)
			idEmblems = 5;
	}

	public void goEmblem6() {
		if (yesEmblem6 == 0 && Game.money >= costEmblem6) {
			Game.money -= costEmblem6;
			yesEmblem6 = 1;
			idEmblems = 6;
		}
		if (yesEmblem6 == 1)
			idEmblems = 6;
	}

	public void goEmblem7() {
		if (yesEmblem7 == 0 && Game.money >= costEmblem7) {
			Game.money -= costEmblem7;
			yesEmblem7 = 1;
			idEmblems = 7;
		}
		if (yesEmblem7 == 1)
			idEmblems = 7;
	}

	public void goEmblem8() {
		if (yesEmblem8 == 0 && Game.money >= costEmblem8) {
			Game.money -= costEmblem8;
			yesEmblem8 = 1;
			idEmblems = 8;
		}
		if (yesEmblem8 == 1)
			idEmblems = 8;
	}

	public static IEnumerator goAuthority() {
		while (true) {
			Authority.expAuthority += AuthorityForSec;
			yield return new WaitForSeconds (1f);
		}
	}

}
