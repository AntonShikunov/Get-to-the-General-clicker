using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Forces : MonoBehaviour {

	public GameObject ForcePan;
	public static int changeForces = 0;

	public GameObject ProVersionBttn;

	public GameObject BlockPolitic;
	public GameObject BlockRHBZ;
	public GameObject BlockVDV;
	public Button PoliticBttnObj, RHBZBttnObj, VDVBttnObj;

	void Update () {
		if (Game.proVersion == 0)
			ProVersionBttn.SetActive(true);
		else
			ProVersionBttn.SetActive(false);
		if (Game.scroll < 100)
		{
			BlockVDV.SetActive(true);
			VDVBttnObj.GetComponent<Button>().interactable = false;
		}
		if (Game.scroll >= 100)
		{
			BlockVDV.SetActive(false);
			VDVBttnObj.GetComponent<Button>().interactable = true;
		}

		if (Game.scroll < 500)
		{
			BlockRHBZ.SetActive(true);
			RHBZBttnObj.GetComponent<Button>().interactable = false;
		}
		if (Game.scroll >= 500)
		{
			BlockRHBZ.SetActive(false);
			RHBZBttnObj.GetComponent<Button>().interactable = true;
		}

		if (Game.scroll < 3000)
		{
			BlockPolitic.SetActive(true);
			PoliticBttnObj.GetComponent<Button>().interactable = false;
		}
		if (Game.scroll >= 3000)
		{
			BlockPolitic.SetActive(false);
			PoliticBttnObj.GetComponent<Button>().interactable = true;
		}
	}

	public void NavyBttn() {
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6) { // ЕСЛИ РАНГОВ 19, ТО СЮДА ДОБАВЛЯТЬ НЕ НАДО!!!
			Game.idForce = 2;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive (false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 2;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}
	public void PoliceBttn() {
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6) {  // ЕСЛИ РАНГОВ 19, ТО СЮДА ДОБАВЛЯТЬ НЕ НАДО!!!
			Game.idForce = 3;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive (false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 3;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}
	public void FBIBttn() {
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6) {
			Game.idForce = 4;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive (false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 4;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}
	public void SPYBttn() { // шпионаж
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6) {
			Game.idForce = 5;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive (false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 5;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}

	public void SpaceBttn() { 
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6) {
			Game.idForce = 6;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive (false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 6;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}

	public void ArmyBttn() { 
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6) {
			Game.idForce = 1;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive (false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 1;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}

	public void VDVBttn() { 
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6) {  // ЕСЛИ РАНГОВ 19, ТО СЮДА ДОБАВЛЯТЬ НЕ НАДО!!!
			Game.idForce = 7;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive (false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 7;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}

	public void RHBZBttn() { 
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6) {  // ЕСЛИ РАНГОВ 19, ТО СЮДА ДОБАВЛЯТЬ НЕ НАДО!!!
			Game.idForce = 8;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive (false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 8;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}

	public void PoliticBttn()
	{
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6)
		{  // ЕСЛИ РАНГОВ 19, ТО СЮДА ДОБАВЛЯТЬ НЕ НАДО!!!
			Game.idForce = 9;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 9;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}

	public void EngineerBttn()
	{
		if (Game.rank == 19 || Game.rank == 18 && Game.idForce == 3 || Game.rank == 16 && Game.idForce == 4 || Game.rank == 18 && Game.idForce == 5 || Game.rank == 18 && Game.idForce == 6)
		{  // ЕСЛИ РАНГОВ 19, ТО СЮДА ДОБАВЛЯТЬ НЕ НАДО!!!
			Game.idForce = 10;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else if (changeForces > 0)
		{
			changeForces -= 1;
			Game.idForce = 10;
			Game.exp = 0;
			Game.rank = 1;
			Game.needExp = 100;
			Game.wage = Game.bonusMoney;
			Passport.numServeForces += 1;
			if (Advertisement.IsReady())
			{
				ShowOptions option = new ShowOptions();
				Advertisement.Show("rewardedVideo", option);
			}
			ForcePan.SetActive(false);
		}
		else { }
	}

}
