using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Outfit : MonoBehaviour {

	public GameObject Page1Pan, Page2Pan, Page3Pan;

	public static int idOutfit = 1; // id снаряжения (переключается)
	public static int costOutfit1 = 25, costOutfit2 = 200, costOutfit3 = 950, costOutfit4 = 1300, costOutfit5 = 5000,
	costOutfit6 = 5500, costOutfit7 = 9000, costOutfit8 = 13500, costOutfit9 = 27000, costOutfit10 = 3800,
	costOutfit11 = 18500, costOutfit12 = 7350, costOutfit13 = 0, costOutfit14 = 0, costOutfit15 = 41000, 
	costOutfit16 = 0, costOutfit17 = 73500, costOutfit18 = 54000, costOutfit19 = 0, costOutfit20 = 91000, 
	costOutfit21 = 133000, costOutfit22 = 0, costOutfit23 = 0, costOutfit24 = 0, costOutfit25 = 0, costOutfit26 = 0,
	costOutfit27 = 155000; 
	public static int yesOutfit1 = 0, yesOutfit2 = 0, yesOutfit3 = 0, yesOutfit4 = 0, yesOutfit5 = 0, 
	yesOutfit6 = 0, yesOutfit7 = 0, yesOutfit8 = 0, yesOutfit9 = 0, yesOutfit10 = 0,
	yesOutfit11 = 0, yesOutfit12 = 0, yesOutfit13 = 0, yesOutfit14 = 0, yesOutfit15 = 0, yesOutfit16 = 0, 
	yesOutfit17 = 0, yesOutfit18 = 0, yesOutfit19 = 0, yesOutfit20 = 0, yesOutfit21 = 0,
	yesOutfit22 = 0, yesOutfit23 = 0, yesOutfit24 = 0, yesOutfit25 = 0, yesOutfit26 = 0, yesOutfit27 = 0; // проверка куплено ли снаряжение (1 - да, 0 - нет)

	public GameObject costOutfit1Obj, costOutfit2Obj, costOutfit3Obj, costOutfit4Obj, costOutfit5Obj, 
	costOutfit6Obj, costOutfit7Obj, costOutfit8Obj, costOutfit9Obj, costOutfit10Obj, costOutfit11Obj,
	costOutfit12Obj, costOutfit13Obj, costOutfit14Obj, costOutfit15Obj, costOutfit16Obj, costOutfit17Obj, 
	costOutfit18Obj, costOutfit19Obj, costOutfit20Obj, costOutfit21Obj,
	costOutfit22Obj, costOutfit23Obj, costOutfit24Obj, costOutfit25Obj, costOutfit26Obj, costOutfit27Obj; // объект ценника снаряжения (чтоб выключать при покупке)

	void Update () {
		if (yesOutfit1 == 1)
			costOutfit1Obj.SetActive (false);
		if (yesOutfit2 == 1)
			costOutfit2Obj.SetActive (false);
		if (yesOutfit3 == 1)
			costOutfit3Obj.SetActive (false);
		if (yesOutfit4 == 1)
			costOutfit4Obj.SetActive (false);
		if (yesOutfit5 == 1)
			costOutfit5Obj.SetActive (false);
		if (yesOutfit6 == 1)
			costOutfit6Obj.SetActive (false);
		if (yesOutfit7 == 1)
			costOutfit7Obj.SetActive (false);
		if (yesOutfit8 == 1)
			costOutfit8Obj.SetActive (false);
		if (yesOutfit9 == 1)
			costOutfit9Obj.SetActive (false);
		if (yesOutfit10 == 1)
			costOutfit10Obj.SetActive (false);
		if (yesOutfit11 == 1)
			costOutfit11Obj.SetActive (false);
		if (yesOutfit12 == 1)
			costOutfit12Obj.SetActive (false);
		if (yesOutfit13 == 1)
			costOutfit13Obj.SetActive (false);
		if (yesOutfit14 == 1)
			costOutfit14Obj.SetActive (false);
		if (yesOutfit15 == 1)
			costOutfit15Obj.SetActive (false);
		if (yesOutfit16 == 1)
			costOutfit16Obj.SetActive (false);
		if (yesOutfit17 == 1)
			costOutfit17Obj.SetActive (false);
		if (yesOutfit18 == 1)
			costOutfit18Obj.SetActive (false);
		if (yesOutfit19 == 1)
			costOutfit19Obj.SetActive (false);
		if (yesOutfit20 == 1)
			costOutfit20Obj.SetActive (false);
		if (yesOutfit21 == 1)
			costOutfit21Obj.SetActive (false);
		if (yesOutfit22 == 1)
			costOutfit22Obj.SetActive (false);
		if (yesOutfit23 == 1)
			costOutfit23Obj.SetActive (false);
		if (yesOutfit24 == 1)
			costOutfit24Obj.SetActive (false);
		if (yesOutfit25 == 1)
			costOutfit25Obj.SetActive (false);
		if (yesOutfit26 == 1)
			costOutfit26Obj.SetActive (false);
		if (yesOutfit27 == 1)
			costOutfit27Obj.SetActive (false);
	}

	public void buyOutfit1() {
		if (yesOutfit1 == 0 && Game.money >= costOutfit1) {
			Game.money -= costOutfit1;
			yesOutfit1 = 1;
			idOutfit = 2;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit1 == 1)
			idOutfit = 2;
	}

	public void buyOutfit2() {
		if (yesOutfit2 == 0 && Game.money >= costOutfit2) {
			Game.money -= costOutfit2;
			yesOutfit2 = 1;
			idOutfit = 3;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit2 == 1)
			idOutfit = 3;
	}

	public void buyOutfit3() {
		if (yesOutfit3 == 0 && Game.money >= costOutfit3) {
			Game.money -= costOutfit3;
			yesOutfit3 = 1;
			idOutfit = 4;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit3 == 1)
			idOutfit = 4;
	}

	public void buyOutfit4() {
		if (yesOutfit4 == 0 && Game.money >= costOutfit4) {
			Game.money -= costOutfit4;
			yesOutfit4 = 1;
			idOutfit = 5;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit4 == 1)
			idOutfit = 5;
	}

	public void buyOutfit5() {
		if (yesOutfit5 == 0 && Game.money >= costOutfit5) {
			Game.money -= costOutfit5;
			yesOutfit5 = 1;
			idOutfit = 6;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit5 == 1)
			idOutfit = 6;
	}

	public void buyOutfit6() {
		if (yesOutfit6 == 0 && Game.money >= costOutfit6) {
			Game.money -= costOutfit6;
			yesOutfit6 = 1;
			idOutfit = 7;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit6 == 1)
			idOutfit = 7;
	}

	public void buyOutfit7() {
		if (yesOutfit7 == 0 && Game.money >= costOutfit7) {
			Game.money -= costOutfit7;
			yesOutfit7 = 1;
			idOutfit = 8;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit7 == 1)
			idOutfit = 8;
	}

	public void buyOutfit8() {
		if (yesOutfit8 == 0 && Game.money >= costOutfit8) {
			Game.money -= costOutfit8;
			yesOutfit8 = 1;
			idOutfit = 9;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit8 == 1)
			idOutfit = 9;
	}

	public void buyOutfit9() {
		if (yesOutfit9 == 0 && Game.money >= costOutfit9) {
			Game.money -= costOutfit9;
			yesOutfit9 = 1;
			idOutfit = 10;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit9 == 1)
			idOutfit = 10;
	}

	public void buyOutfit10() {
		if (yesOutfit10 == 0 && Game.money >= costOutfit10) {
			Game.money -= costOutfit10;
			yesOutfit10 = 1;
			idOutfit = 11;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit10 == 1)
			idOutfit = 11;
	}

	public void buyOutfit11() {
		if (yesOutfit11 == 0 && Game.money >= costOutfit11) {
			Game.money -= costOutfit11;
			yesOutfit11 = 1;
			idOutfit = 12;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit11 == 1)
			idOutfit = 12;
	}

	public void buyOutfit12() {
		if (yesOutfit12 == 0 && Game.money >= costOutfit12) {
			Game.money -= costOutfit12;
			yesOutfit12 = 1;
			idOutfit = 13;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit12 == 1)
			idOutfit = 13;
	}

	public void buyOutfit13() {
		if (yesOutfit13 == 0 && Game.money >= costOutfit13 && Game.finishNavy == 1) {
			Game.money -= costOutfit13;
			yesOutfit13 = 1;
			idOutfit = 14;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit13 == 1)
			idOutfit = 14;
	}

	public void buyOutfit14() {
		if (yesOutfit14 == 0 && Game.money >= costOutfit14 && Game.finishPolice == 1) {
			Game.money -= costOutfit14;
			yesOutfit14 = 1;
			idOutfit = 15;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit14 == 1)
			idOutfit = 15;
	}

	public void buyOutfit15() {
		if (yesOutfit15 == 0 && Game.money >= costOutfit15) {
			Game.money -= costOutfit15;
			yesOutfit15 = 1;
			idOutfit = 16;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit15 == 1)
			idOutfit = 16;
	}

	public void buyOutfit16() {
		if (yesOutfit16 == 0 && Game.money >= costOutfit14 && Game.finishVDV == 1) {
			Game.money -= costOutfit16;
			yesOutfit16 = 1;
			idOutfit = 17;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit16 == 1)
			idOutfit = 17;
	}

	public void buyOutfit17() {
		if (yesOutfit17 == 0 && Game.money >= costOutfit17) {
			Game.money -= costOutfit17;
			yesOutfit17 = 1;
			idOutfit = 18;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit17 == 1)
			idOutfit = 18;
	}

	public void buyOutfit18() {
		if (yesOutfit18 == 0 && Game.money >= costOutfit18) {
			Game.money -= costOutfit18;
			yesOutfit18 = 1;
			idOutfit = 19;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit18 == 1)
			idOutfit = 19;
	}

	public void buyOutfit19() {
		if (yesOutfit19 == 0 && Game.money >= costOutfit19 && Game.finishRHBZ == 1) {
			Game.money -= costOutfit19;
			yesOutfit19 = 1;
			idOutfit = 20;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit19 == 1)
			idOutfit = 20;
	}

	public void buyOutfit20() {
		if (yesOutfit20 == 0 && Game.money >= costOutfit20) {
			Game.money -= costOutfit20;
			yesOutfit20= 1;
			idOutfit = 21;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit20 == 1)
			idOutfit = 21;
	}

	public void buyOutfit21() {
		if (yesOutfit21 == 0 && Game.money >= costOutfit21) {
			Game.money -= costOutfit21;
			yesOutfit21= 1;
			idOutfit = 22;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit21 == 1)
			idOutfit = 22;
	}
	public void buyOutfit22() {
		if (yesOutfit22 == 1)
			idOutfit = 23;
	}
	public void buyOutfit23() {
		if (yesOutfit23 == 1)
			idOutfit = 24;
	}
	public void buyOutfit24() {
		if (yesOutfit24 == 1)
			idOutfit = 25;
	}
	public void buyOutfit25() {
		if (yesOutfit25 == 1)
			idOutfit = 26;
	}
	public void buyOutfit26() {
		if (yesOutfit26 == 1)
			idOutfit = 27;
	}
	public void buyOutfit27() {
		if (yesOutfit27 == 0 && Game.money >= costOutfit27) {
			Game.money -= costOutfit27;
			yesOutfit27= 1;
			idOutfit = 28;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
		}
		if (yesOutfit27 == 1)
			idOutfit = 28;
	}

	public void Page1Pan_Open() {
		Page1Pan.SetActive (true);
		Page3Pan.SetActive (false);
		Page2Pan.SetActive (false);
	}

	public void Page2Pan_Open() {
		Page1Pan.SetActive (false);
		Page3Pan.SetActive (false);
		Page2Pan.SetActive (true);
	}

	public void Page3Pan_Open() {
		Page1Pan.SetActive (false);
		Page2Pan.SetActive (false);
		Page3Pan.SetActive (true);
	}
		
}
