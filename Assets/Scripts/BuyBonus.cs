using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class BuyBonus : MonoBehaviour {

	public static int buyContent = 0; // куплен ли контент за 30(0 - нет, 1 - да).
	public static int buyContent60 = 0; // куплен ли контент за 60 (0 - нет, 1 - да).
	public static int buyContent99 = 0; // куплен ли контент за 99 (0 - нет, 1 - да).
	public static int buyContent159 = 0; // куплен ли контент за 159 (0 - нет, 1 - да).
	public static int buyContent590 = 0; // куплен ли контент за 590 (0 - нет, 1 - да).

	public void Start() {

	}
	/*public void buyBonus() {
		IAPManager.Instantiate.Buy_Bonus ();
	}*/
	/*public void Awake() {
		PurchaseManager.OnPurchaseNonConsumable += PurchaseManager_OnPurchaseNonConsumable;
		PurchaseManager.OnPurchaseConsumable +=	PurchaseManager_OnPurchaseConsumable;
	}

	public void LateUpdate() {
		if (PurchaseManager.CheckBuyState ("buy_bonus")) {
			Game.proVersion = 1;
			Game.bonusForBuy = 3;
			buyContent = 1;
			Outfit.yesOutfit8 = 1;
		}
	}*/

	/*public void PurchaseManager_OnPurchaseNonConsumable(PurchaseEventArgs args) {
		
	}
	public void PurchaseManager_OnPurchaseConsumable(PurchaseEventArgs args) {
		Game.money += 15000;
		Game.proVersion = 1;
		Game.bonusForBuy = 3;
		Outfit.yesOutfit8 = 1;
		Outfit.idOutfit = 9;
		buyContent = 1;
	}*/

}
