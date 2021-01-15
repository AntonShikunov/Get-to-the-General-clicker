using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

// Deriving the Purchaser class from IStoreListener enables it to receive messages from Unity Purchasing.
public class IAPManager : MonoBehaviour, IStoreListener
{
	public static IAPManager Instance{set;get;}

	private static IStoreController m_StoreController;          // The Unity Purchasing system.
	private static IExtensionProvider m_StoreExtensionProvider; // The store-specific Purchasing subsystems.

	public static string BUY_BONUS = "buy_bonus"; // ����� �� 30 ������
	public static string BUY_BONUS60 = "buy_bonus60"; // ����� �� 60 ������
	public static string BUY_BONUS99 = "buy_bonus99"; // ����� �� 99 ������
	public static string BUY_BONUS159 = "buy_bonus159"; // ����� �� 159 ������
	public static string BUY_BONUS590 = "buy_bonus590"; // ����� �� 590 ������

	public static string BUY_OFFMONEY30 = "buy_offmoney30"; // ������� ������ �� 30 ������
	public static string BUY_OFFMONEY45 = "buy_offmoney45"; // ������� ������ �� 45 ������
	public static string BUY_OFFMONEY70 = "buy_offmoney70"; // ������� ������ �� 70 ������
	public static string BUY_OFFMONEY129= "buy_offmoney129"; // ������� ������ �� 129 ������
	public static string BUY_OFFMONEY200 = "buy_offmoney200"; // ������� ������ �� 200 ������

	public static string BUY_60GOLD = "buy_60gold"; // ������ 60 ������
	public static string BUY_150GOLD = "buy_150gold"; // ������ 150 ������
	public static string BUY_400GOLD = "buy_400gold"; // ������ 400 ������
	public static string BUY_1000GOLD = "buy_1000gold"; // ������ 1000 ������
	public static string BUY_2500GOLD = "buy_2500gold"; // ������ 2500 ������
	public static string BUY_10000GOLD = "buy_10000gold"; // ������ 10000 ������

	public static string BUY_PROVERSION = "buy_proversion"; // ������ pro ������ (�� 99 ���. �����)

	public static string AUTO_COURT = "auto_court"; // ������ �������������� ����� ���� (������ ��� �� 30)

	private void Awake() {
		Instance = this;
	}
	private void Start()
	{
		// If we haven't set up the Unity Purchasing reference
		if (m_StoreController == null)
		{
			// Begin to configure our connection to Purchasing
			InitializePurchasing();
		}
	}

	public void InitializePurchasing() 
	{
		// If we have already connected to Purchasing ...
		if (IsInitialized())
		{
			// ... we are done here.
			return;
		}

		// Create a builder, first passing in a suite of Unity provided stores.
		var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

		builder.AddProduct(BUY_BONUS, ProductType.NonConsumable);
		builder.AddProduct(BUY_BONUS60, ProductType.NonConsumable);
		builder.AddProduct(BUY_BONUS99, ProductType.NonConsumable);
		builder.AddProduct(BUY_BONUS159, ProductType.NonConsumable);
		builder.AddProduct(BUY_BONUS590, ProductType.NonConsumable);

		builder.AddProduct(BUY_OFFMONEY30, ProductType.NonConsumable);
		builder.AddProduct(BUY_OFFMONEY45, ProductType.NonConsumable);
		builder.AddProduct(BUY_OFFMONEY70, ProductType.NonConsumable);
		builder.AddProduct(BUY_OFFMONEY129, ProductType.NonConsumable);
		builder.AddProduct(BUY_OFFMONEY200, ProductType.NonConsumable);

		builder.AddProduct(BUY_60GOLD, ProductType.Consumable);
		builder.AddProduct(BUY_150GOLD, ProductType.Consumable);
		builder.AddProduct(BUY_400GOLD, ProductType.Consumable);
		builder.AddProduct(BUY_1000GOLD, ProductType.Consumable);
		builder.AddProduct(BUY_2500GOLD, ProductType.Consumable);
		builder.AddProduct(BUY_10000GOLD, ProductType.Consumable);
		builder.AddProduct(AUTO_COURT, ProductType.NonConsumable);
		builder.AddProduct(BUY_PROVERSION, ProductType.NonConsumable);
		UnityPurchasing.Initialize(this, builder);
	}


	private bool IsInitialized()
	{
		// Only say we are initialized if both the Purchasing references are set.
		return m_StoreController != null && m_StoreExtensionProvider != null;
	}


	public void Buy_Bonus()
	{
		BuyProductID(BUY_BONUS);
	}

	public void Buy_Bonus60()
	{
		BuyProductID(BUY_BONUS60);
	}

	public void Buy_Bonus99()
	{
		BuyProductID(BUY_BONUS99);
	}

	public void Buy_Bonus159()
	{
		BuyProductID(BUY_BONUS159);
	}

	public void Buy_Bonus590()
	{
		BuyProductID(BUY_BONUS590);
	}

	public void Buy_OffMoney30()
	{
		BuyProductID(BUY_OFFMONEY30);
	}

	public void Buy_OffMoney45()
	{
		BuyProductID(BUY_OFFMONEY45);
	}

	public void Buy_OffMoney70()
	{
		BuyProductID(BUY_OFFMONEY70);
	}

	public void Buy_OffMoney129()
	{
		BuyProductID(BUY_OFFMONEY129);
	}

	public void Buy_OffMoney200()
	{
		BuyProductID(BUY_OFFMONEY200);
	}

	public void Buy_60gold()
	{
		BuyProductID(BUY_60GOLD);
	}

	public void Buy_150gold()
	{
		BuyProductID(BUY_150GOLD);
	}

	public void Buy_400gold()
	{
		BuyProductID(BUY_400GOLD);
	}

	public void Buy_1000gold()
	{
		BuyProductID(BUY_1000GOLD);
	}

	public void Buy_2500gold()
	{
		BuyProductID(BUY_2500GOLD);
	}

	public void Buy_10000gold()
	{
		BuyProductID(BUY_10000GOLD);
	}

	public void Buy_autoCourt()
	{
		BuyProductID(AUTO_COURT);
	}

	public void Buy_ProVersion()
	{
		BuyProductID(BUY_PROVERSION);
	}


	private void BuyProductID(string productId)
	{
		// If Purchasing has been initialized ...
		if (IsInitialized())
		{
			// ... look up the Product reference with the general product identifier and the Purchasing 
			// system's products collection.
			Product product = m_StoreController.products.WithID(productId);

			// If the look up found a product for this device's store and that product is ready to be sold ... 
			if (product != null && product.availableToPurchase)
			{
				Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
				// ... buy the product. Expect a response either through ProcessPurchase or OnPurchaseFailed 
				// asynchronously.
				m_StoreController.InitiatePurchase(product);
			}
			// Otherwise ...
			else
			{
				// ... report the product look-up failure situation  
				Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
			}
		}
		// Otherwise ...
		else
		{
			// ... report the fact Purchasing has not succeeded initializing yet. Consider waiting longer or 
			// retrying initiailization.
			Debug.Log("BuyProductID FAIL. Not initialized.");
		}
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
		// Purchasing has succeeded initializing. Collect our Purchasing references.
		Debug.Log("OnInitialized: PASS");

		// Overall Purchasing system, configured with products for this application.
		m_StoreController = controller;
		// Store specific subsystem, for accessing device-specific store features.
		m_StoreExtensionProvider = extensions;
	}


	public void OnInitializeFailed(InitializationFailureReason error)
	{
		// Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
		Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
	}


	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args) 
	{
		// A consumable product has been purchased by this user.
		if (String.Equals(args.purchasedProduct.definition.id, BUY_BONUS, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ����� �� 30 ������!");
			Game.money += 30000;
			Status.totalEarnedMoney += 30000;
			//Game.proVersion = 1;
			//Forces.changeForces += 1;
			if (Game.bonusForBuy <= 5) {
				Game.bonusForBuy = 5;
			}
			Outfit.yesOutfit8 = 1;
			Outfit.idOutfit = 9;
			BuyBonus.buyContent = 1;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_BONUS60, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ����� �� 60 ������!");
			Game.money += 70000;
			Status.totalEarnedMoney += 70000;
			Game.proVersion = 1;
			Forces.changeForces += 1000000;
			if (Game.bonusForBuy <= 8) {
				Game.bonusForBuy = 8;
			}
			Outfit.yesOutfit15 = 1;
			Outfit.idOutfit = 16;
			BuyBonus.buyContent60 = 1;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_BONUS99, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ����� �� 99 ������!");
			Game.money += 200000;
			Status.totalEarnedMoney += 200000;
			Game.gold += 300;
			Game.proVersion = 1;
			Forces.changeForces += 1000000;
			if (Game.bonusForBuy <= 10) {
				Game.bonusForBuy = 10;
			}
			Outfit.yesOutfit17 = 1;
			Outfit.idOutfit = 18;
			Emblems.yesEmblem7 = 1;
			Emblems.idEmblems = 7;
			BuyBonus.buyContent99 = 1;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_BONUS159, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ����� �� 159 ������!");
			Game.money += 450000;
			Status.totalEarnedMoney += 450000;
			Game.gold += 800;
			Game.proVersion = 1;
			Forces.changeForces += 1000000;
			if (Game.bonusForBuy <= 15) {
				Game.bonusForBuy = 15;
			}
			Outfit.yesOutfit21 = 1;
			Outfit.idOutfit = 22;
			Emblems.yesEmblem8 = 1;
			Emblems.idEmblems = 8;
			BuyBonus.buyContent159 = 1;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_BONUS590, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ����� �� 590 ������!");
			Game.money += 1500000;
			Status.totalEarnedMoney += 1500000;
			Game.gold += 2000;
			Game.scroll += 500;
			Game.proVersion = 1;
			Forces.changeForces += 1000000;
			if (Game.bonusForBuy <= 30)
			{
				Game.bonusForBuy = 30;
			}
			Outfit.yesOutfit21 = 1;
			Outfit.yesOutfit26 = 1;
			Outfit.yesOutfit19 = 1;
			Outfit.idOutfit = 22;
			Emblems.yesEmblem8 = 1;
			Emblems.idEmblems = 8;
			BuyBonus.buyContent590 = 1;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_60GOLD, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� 100 ������!");
			Game.gold += 100;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_150GOLD, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� 300 ������!");
			Game.gold += 300;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_400GOLD, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� 800 ������!");
			Game.gold += 800;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_1000GOLD, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� 2000 ������!");
			Game.gold += 2000;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_2500GOLD, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� 5000 ������!");
			Game.gold += 5000;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_10000GOLD, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� 25000 ������!");
			Game.gold += 25000;
		}

		if (String.Equals(args.purchasedProduct.definition.id, AUTO_COURT, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� �������������� ����� ����");
			Court.autoCourt = 1;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_OFFMONEY30, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ���.��������� �� 30 ������");
			
				OffMoney.lvlOffMoney = 1;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_OFFMONEY45, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ���.��������� �� 45 ������");

				OffMoney.lvlOffMoney = 2;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_OFFMONEY70, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ���.��������� �� 70 ������");

			OffMoney.lvlOffMoney = 3;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_OFFMONEY129, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ���.��������� �� 129 ������");

			OffMoney.lvlOffMoney = 4;
		}

		if (String.Equals(args.purchasedProduct.definition.id, BUY_OFFMONEY200, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� ���.��������� �� 200 ������");

			OffMoney.lvlOffMoney = 5;
		}
		if (String.Equals(args.purchasedProduct.definition.id, BUY_PROVERSION, StringComparison.Ordinal))
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			Debug.Log("�� ����� PRO ������ ����!");
			Game.proVersion = 1;
			Forces.changeForces += 1000000;
			Game.money += 10000;
			Status.totalEarnedMoney += 10000;
			Game.gold += 100;
			if (Game.bonusForBuy <= 3)
			{
				Game.bonusForBuy = 3;
			}
		}
		// Or ... a non-consumable product has been purchased by this user.
		// Or ... an unknown product has been purchased by this user. Fill in additional products here....
		else 
		{
			Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
		}

		// Return a flag indicating whether this product has completely been received, or if the application needs 
		// to be reminded of this purchase at next app launch. Use PurchaseProcessingResult.Pending when still 
		// saving purchased products to the cloud, and when that save is delayed. 
		return PurchaseProcessingResult.Complete;
	}


	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
		// A product purchase attempt did not succeed. Check failureReason for more detail. Consider sharing 
		// this reason with the user to guide their troubleshooting actions.
		Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
	}
}
