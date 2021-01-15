//using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Game : MonoBehaviour {
	
	public static int idLanguage = 1; // id ЪГШЙЮ ДКЪ КНЙЮКХГЮЖХХ (1 - ПСЯЯЙХИ, 2 - ЮМЦКХИЯЙХИ)
	public static int proVersion = 0; // ОПНБЕПЙЮ, ЕЯРЭ КХ pro БЕПЯХЪ (0 - МЕР, 1 - ДЮ)
	public static int bonusForBuy = 1; // АНМСЯ ОПХ ОНЙСОЙЕ (ЕЯКХ ЙСОХКХ, ДН АСДЕР 3)
	public static int BonusFromGold = 0; // АНМСЯМШЕ ЙКХЙХ (ГЮ ГНКНРН)
	public static int percentGoldForClick = 0; // ОПНЖЕМР БЕПНЪРМНЯРХ ОНКСВЕМХЪ ГНКНРЮ ГЮ ЙКХЙ (1% - 100. 100% - 10000)
	public static int exp = 0;
    public static int clickatonce = 1;
    public static int rank = 1;
    public static int needExp = 100;
    public static int clickNum = 0;
    public static int idAds = 0;
	public static int money = 0;
	public static int gold = 0;
	public static int scroll = 0; // ЯБХРЙХ
	public static int wage = 0;
	public static int yesRate = 0; // ОНЯРЮБХКХ КХ ПЕИРХМЦ (0 МЕР, 1 ДЮ)
	public static int costSkill1 = 20, costSkill2 = 150, costSkill3 = 900, costSkill4 = 2000, costSkill5 = 5000, 
					  costSkill6 = 30, costSkill7 = 40;
	public static int lvlSkill1 = 0, lvlSkill2 = 0, lvlSkill3 = 0, lvlSkill4 = 0, lvlSkill5 = 0, lvlSkill6 = 0, lvlSkill7 = 0;
	public static int bonusMoney = 0;
	public static int bonusForRate = 0;
	public static int idForce = 1; // ХД БНИЯЙ (1 - ЮПЛХЪ, 2 - ЛНПЯЙНИ ТКНР, 3 - ОНКХЖХЪ)
    public static int bonusForClick = 1; // ЛМНФХРЕКЭ АНМСЯЮ, ЙНРНПШИ СБЕКХВХБЮЕРЯЪ ГЮ ПЕЙКЮЛС
    public static int countBonus = 0;
	public static int WageForCadet = 1;
	public static int finishNavy = 0; // ГЮЙНМВХК КХ ЯКСФАС БН ТКНРЕ (0 - МЕР, 1 - ДЮ)
	public static int finishPolice = 0; // ГЮЙНМВХК КХ ЯКСФАС Б ОНКХЖХХ
	public static int finishVDV = 0, finishRHBZ = 0; // ГЮЙНМВХК КХ ЯКСФАС Б бдб, Б пуаг (0 - МЕР, 1 - ДЮ)
	public static int finishPolitic = 0; // ГЮЙНМВХК КХ ЯКСФАС Б ОПЮБХРЕКЭЯРБЕ (ОНКСВХК КХ РШ ЕАЮРЭ ОПЕГХДЕМРЮ?!)
	public static int finishEngineer = 0;
	public static int[] count = { 0, 0, 0, 0, 0, 0, 0, 0}; // ЯВ╦РВХЙ НРЯВ╦РЮ НР 60 ДН 0
    public static int[] medals = { 0, 0, 0, 0, 0 }; // ЛЕДЮКХ (0 - МЕ НРЙПШР, 1 - НРЙПШР)
    public static int[] NumAdsForMedal = { 5, 10, 15, 20, 30 }; // ЙНКХВЕЯРБН ПЕЙКЮЛШ ДКЪ НРЙПШРХЪ ЛЕДЮКХ
    public int[] expForRank = { 100, 300, 800, 1900, 3000, 6300, 9500, 12500,
                                     15500, 22000, 28500, 39000, 50000, 63000, 75000, 85000, 108000, 130000, 170000};
    public static string[] nameRank = { "пъднбни", "етпеирнп", "лкюдьхи яепфюмр", "яепфюмр", "ярюпьхи яепфюмр", "ярюпьхмю",
                                      "опюонпыхй", "ярюпьхи опюонпыхй", "лкюдьхи кеиремюмр", "кеиремюмр",
                                      "ярюпьхи кеиремюмр", "йюохрюм", "люинп", "ондонкйнбмхй", "онкйнбмхй",
                                      "цемепюк-люинп", "цемепюк-кеиремюмр", "цемепюк-онкйнбмхй", "цемепюк юплхх"};

	public static string[] nameRankNavy = { "люрпня", "ярюпьхи люрпня", "ярюпьхмю 2 ярюрэх", "ярюпьхмю 1 ярюрэх", "цкюбмши ярюпьхмю",
		"цкюбмши йнпюа.ярюпьхмю", "лхвлюм", "ярюпьхи лхвлюм", "лкюдьхи кеиремюмр", "кеиремюмр",
		"ярюпьхи кеиремюмр", "йюохрюм-кеиремюмр", "йюохрюм 3 пюмцю", "йюохрюм 2 пюмцю", "йюохрюм 1 пюмцю",
		"йнмрп-юдлхпюк", "бхже-юдлхпюк", "юдлхпюк", "юдлхпюк ткнрю"};

	public static string[] nameRankPolice = { "пъднбни онкхжхх", "лкюдьхи яепфюмр", "яепфюмр", "ярюпьхи яепфюмр", "ярюпьхмю онкхжхх",
		"опюонпыхй онкхжхх", "ярюпьхи опюонпыхй", "лкюдьхи кеиремюмр", "кеиремюмр", "ярюпьхи кеиремюмр",
		"йюохрюм онкхжхх", "люинп онкхжхх", "ондонкйнбмхй", "онкйнбмхй онкхжхх", "цемепюк-люинп онкхжхх",
		"цемепюк-кеиремюмр онкхжхх", "цемепюк-онкйнбмхй онкхжхх", "цемепюк онкхжхх"};

	public static string[] nameRankFBI = { "ярюф╗п", "лкюдьхи юцемр тап", "юцемр тап", "ярюпьхи юцемр тап", "яоежхюкэмши юцемр",
		"юцемр мюж.аегноюямнярх", "сопюбкъчыхи юцемрспни", "цкюбю юйюделхх тап", "юцемр DEP", "гюл. цкюбш сопюбкемхъ DEP",
		"цкюбю сопюбкемхъ DEP", "гюл. цкюбш сопюбкемхъ CID", "цкюбю сопюбкемхъ CID", "мювюкэмхй NATIONAL SECURITY", "цкюбмши хмяоейрнп тап",
	"дхпейрнп тап"};

	public static string[] nameRankSPY = { "ярюф╗п", "рпсдъцю", "лкюдьхи юцемр SPY-S", "юцемр SPY-S", "ярюпьхи юцемр SPY-S",
		"йндхпнбыхй", "ремэ 3 пюмцю", "ремэ 2 пюмцю", "ремэ 1 пюмцю", "кеиремюмр",
		"ярюпьхи кеиремюмр", "люинп ьохнмюфю", "гнпйхи йюхм", "онкйнбмхй 2 ярюрэх", "онкйнбмхй 1 ярюрэх",
		"мехярпеахлши юцемр", "йнмрп-хмяоейрнп", "дхпейрнп ьохнмюфю"};

	public static string[] nameRankSpace = { "пъднбни", "лкюдьхи к╗рвхй", "онлнымхй йнлюмдш", "юцемр к╗рвхйнб", "мюярюбмхй цпсоош", "мювюкэмхй цпсоош",
		"цкюбю юйюделхх бнгдсую", "сопюбкъчыхи цпсоони", "юцемр X-SPACE цпсоош", "ярюпьхи юцемр X-SPACE",
		"свюярмхй ондпюгдекемхъ NATIONAL A.F", "мюярюбмхй ондпюгдекемхъ NATIONAL A.F", "йнлюмдсчыхи ондпюгдекемхълх", 
		"ондонкйнбмхй йнялхвеяйху яхк", "онкйнбмхй йнялхвеяйху яхк", "цемепюк-люинп 1 йкюяяю", "цемепюк-люинп 2 йкюяяю", "цемепюк йнялхвеяйху яхк"};

	public static string[] nameRankVDV = { "пъднбни", "етпеирнп", "лкюдьхи яепфюмр", "яепфюмр", "ярюпьхи яепфюмр", "ярюпьхмю",
		"деяюмрмхй 1 пюмцю", "деяюмрмхй 2 пюмцю", "ярюпьхи деяюмрмхй", "кеиремюмр",
		"ярюпьхи кеиремюмр", "йюохрюм", "люинп", "ондонкйнбмхй", "онкйнбмхй",
		"цемепюк-люинп", "цемепюк-кеиремюмр", "цемепюк-онкйнбмхй", "цемепюк бдб"};

	public static string[] nameRankRHBZ = { "пъднбни", "етпеирнп", "лкюдьхи яепфюмр", "яепфюмр", "ярюпьхи яепфюмр", "ярюпьхмю",
		"анеж пуа гюыхрш", "опюонпыхй", "цкюбю пуа гюыхрш", "кеиремюмр",
		"ярюпьхи кеиремюмр", "йюохрюм", "люинп", "ондонкйнбмхй", "онкйнбмхй",
		"цемепюк-люинп", "цемепюк-кеиремюмр", "цемепюк-онкйнбмхй", "цемепюк пуаг"};

	public static string[] nameRankPolitic = { "пъднбни", "етпеирнп", "лкюдьхи яепфюмр", "яепфюмр", "ярюпьхи яепфюмр", "яр.яепфюмр 5 ярюрэх",
									  "яр.яепфюмр 4 ярюрэх", "яр.яепфюмр 3 ярюрэх", "яр.яепфюмр 2 ярюрэх", "яр.яепфюмр 1 ярюрэх",
									  "кеиремюмр опегхдемряйнцн онкйю", "яр. кеиремюмр опегхдемряйнцн онкйю", "йюохрюм опегхдемряйнцн онкйю",
									  "ондонкйнбмхй опегхдемряйнцн онкйю", "онкйнбмхй опегхдемряйнцн онкйю",
									  "бепунбмши онкйнбмхй", "цемепюк опегхдемряйнцн онкйю", "опюбюъ псйю опегхдемрю", "опегхдемр"};

	public static string[] nameRankEngineer = { "пъднбни", "етпеирнп", "лкюдьхи яепфюмр", "яепфюмр", "ярюпьхи яепфюмр", "ярюпьхмю",
									  "опюонпыхй", "ярюпьхи опюонпыхй", "лкюдьхи кеиремюмр", "кеиремюмр",
									  "ярюпьхи кеиремюмр", "йюохрюм", "люинп", "ондонкйнбмхй", "онкйнбмхй",
									  "цемепюк-люинп", "цемепюк-кеиремюмр", "цемепюк-онкйнбмхй", "цемепюк"};


	public GameObject ClickPan;
    public GameObject InfoPan;
    public GameObject MedalsPan;
	public GameObject RankUpPan;
	public GameObject SkillsPan;
	public GameObject OutfitPan;
	public GameObject ForcesPan;
	public GameObject EmblemsPan;
	public GameObject PartnerPan;
	public GameObject CadetPan;
	public GameObject DonatPan;
	public GameObject PassportPan;
	public GameObject StatusPan;
	public GameObject BuyTimeOfflinePan;
	public GameObject PanelForScroll, PanelBuyGold;
	public GameObject BuyPan; // МЮГНИКХБЮЪ ОЮМЕКЭ, ЙНРНПЮЪ ЮБРНЛЮРХВЕЯЙХ НРЙПШБЮЕРЯЪ Х ОПЕДКЮЦЮЕР ОЕПЕИРХ Б ПЮГДЕК ОНЙСОНЙ
	public GameObject BuyContent60Pan, BuyContent99Pan, BuyContent159Pan, iconBuy;
	public GameObject BossesPan; // ОЮМЕКЭ АНЯЯНБ
	public GameObject CourtPan;
	public GameObject NotesPan;
    public GameObject[] blockBttns = new GameObject[8];
    public GameObject[] waitBttns = new GameObject[8];
    public GameObject[] WatchAdBttn = new GameObject[5];
    public GameObject adsx2;
    public GameObject adsx3;
    public GameObject adsx4;
    public GameObject adsx5;
	public GameObject PlusWagePref;
	public GameObject PlusGoldPref;
	public Text PlusWageText;

	public GameObject RangImg, RangImg512; // ХЙНМЙЮ ОНЦНМ, Б ГЮБХЯХЛНЯРХ НР ПЮГЛЕПЮ ЙЮПРХМЙХ (ЙНЯЛ.ЯХКШ - 512)

    public GameObject CloseInfoPanBttn;
    public GameObject CloseMedalsPanBttn;
	public GameObject RateBttn;

	public Text OfficerText;

    public Image RankImg;
    public Sprite Rank_1, Rank_2, Rank_3, Rank_4, Rank_5, Rank_6, Rank_7, Rank_8,
    Rank_9, Rank_10, Rank_11, Rank_12, Rank_13, Rank_14, Rank_15, Rank_16, Rank_17, Rank_18, Rank_19;

	public Image RankNavyImg;
	public Sprite RankNavy_1, RankNavy_2, RankNavy_3, RankNavy_4, RankNavy_5, RankNavy_6, RankNavy_7, RankNavy_8,
	RankNavy_9, RankNavy_10, RankNavy_11, RankNavy_12, RankNavy_13, RankNavy_14, RankNavy_15, RankNavy_16, 
	RankNavy_17, RankNavy_18, RankNavy_19;

	public Image RankPoliceImg;
	public Sprite RankPolice_1, RankPolice_2, RankPolice_3, RankPolice_4, RankPolice_5, RankPolice_6, RankPolice_7, RankPolice_8,
	RankPolice_9, RankPolice_10, RankPolice_11, RankPolice_12, RankPolice_13, RankPolice_14, RankPolice_15, RankPolice_16, 
	RankPolice_17, RankPolice_18, RankPolice_19;

	public Image RankFBIImg;
	public Sprite RankFBI_1, RankFBI_2, RankFBI_3, RankFBI_4, RankFBI_5, RankFBI_6, RankFBI_7, RankFBI_8,
	RankFBI_9, RankFBI_10, RankFBI_11, RankFBI_12, RankFBI_13, RankFBI_14, RankFBI_15, RankFBI_16;

	public Image RankSPYImg;
	public Sprite RankSPY_1, RankSPY_2, RankSPY_3, RankSPY_4, RankSPY_5, RankSPY_6, RankSPY_7, RankSPY_8,
	RankSPY_9, RankSPY_10, RankSPY_11, RankSPY_12, RankSPY_13, RankSPY_14, RankSPY_15, RankSPY_16, RankSPY_17, RankSPY_18;

	public Image RankSpaceImg;
	public Sprite RankSpace_1, RankSpace_2, RankSpace_3, RankSpace_4, RankSpace_5, RankSpace_6, RankSpace_7, RankSpace_8,
	RankSpace_9, RankSpace_10, RankSpace_11, RankSpace_12, RankSpace_13, RankSpace_14, RankSpace_15, RankSpace_16, RankSpace_17, RankSpace_18;

	public Image RankUpImg;
	public Sprite upRank2, upRank3, upRank4, upRank5, upRank6, upRank7, upRank8, upRank9, upRank10, 
	upRank11, upRank12, upRank13, upRank14, upRank15, upRank16, upRank17, upRank18, upRank19;

	public Image RankVDVImg;
	public Sprite RankVDV_1, RankVDV_2, RankVDV_3, RankVDV_4, RankVDV_5, RankVDV_6, RankVDV_7, RankVDV_8,
	RankVDV_9, RankVDV_10, RankVDV_11, RankVDV_12, RankVDV_13, RankVDV_14, RankVDV_15, RankVDV_16, RankVDV_17, 
	RankVDV_18, RankVDV_19;

	public Image RankRHBZImg;
	public Sprite RankRHBZ_1, RankRHBZ_2, RankRHBZ_3, RankRHBZ_4, RankRHBZ_5, RankRHBZ_6, RankRHBZ_7, RankRHBZ_8,
	RankRHBZ_9, RankRHBZ_10, RankRHBZ_11, RankRHBZ_12, RankRHBZ_13, RankRHBZ_14, RankRHBZ_15, RankRHBZ_16, 
	RankRHBZ_17, RankRHBZ_18, RankRHBZ_19;

	public Image RankPoliticImg;
	public Sprite RankPolitic_1, RankPolitic_2, RankPolitic_3, RankPolitic_4, RankPolitic_5, RankPolitic_6, RankPolitic_7,
		RankPolitic_8, RankPolitic_9, RankPolitic_10, RankPolitic_11, RankPolitic_12, RankPolitic_13, RankPolitic_14,
		RankPolitic_15, RankPolitic_16, RankPolitic_17, RankPolitic_18, RankPolitic_19;

	public Image RankEngineerImg;
	public Sprite RankEngineer_1, RankEngineer_2, RankEngineer_3, RankEngineer_4, RankEngineer_5, RankEngineer_6, RankEngineer_7,
		RankEngineer_8, RankEngineer_9, RankEngineer_10, RankEngineer_11, RankEngineer_12, RankEngineer_13, RankEngineer_14,
		RankEngineer_15, RankEngineer_16, RankEngineer_17, RankEngineer_18, RankEngineer_19;


	public Image OutfitImg;
	public Sprite Outfit1, Outfit2, Outfit3, Outfit4, Outfit5, Outfit6, Outfit7, Outfit8, Outfit9, Outfit10,
	Outfit11, Outfit12, Outfit13, Outfit14, Outfit15, Outfit16, Outfit17, Outfit18, Outfit19, Outfit20, 
	Outfit21, Outfit22, Outfit23, Outfit24, Outfit25, Outfit26, Outfit27;

    public Text rankText;
    public Text numRankText;
    public Text BonusText;
	public Text MoneyText;
	public Text WageText;
	public Text GoldText;
	public Text ScrollText;
	public Text CostSkill1Text, CostSkill2Text, CostSkill3Text, CostSkill4Text, CostSkill5Text, CostSkill6Text, CostSkill7Text;
	public Text LvlSkill1Text, LvlSkill2Text, LvlSkill3Text, LvlSkill4Text, LvlSkill5Text, LvlSkill6Text, LvlSkill7Text;
    public Text[] NumAdsForMedalText = new Text[5]; 

    public Slider expSlider;

    public GameObject plusExpText, clickParent;
    public static ClickObj[] clickTextPool = new ClickObj[15];
    //public GameObject[] clickTextPool = new GameObject[20];
    //public Vector2 randomVector;

	void Start () {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("2622178");
        }
        for (int i = 0; i < clickTextPool.Length; i++)
           clickTextPool[i] = Instantiate(plusExpText, clickParent.transform).GetComponent<ClickObj>();
        //clickTextPool[0].StartMotion(clickatonce);
        //StartCoroutine(delPrefs());

        if (medals[0] == 1)
            WatchAdBttn[0].SetActive(false);
        if (medals[1] == 1)
            WatchAdBttn[1].SetActive(false);
        if (medals[2] == 1)
            WatchAdBttn[2].SetActive(false);
        if (medals[3] == 1)
            WatchAdBttn[3].SetActive(false);
        if (medals[4] == 1)
            WatchAdBttn[4].SetActive(false);
        expSlider.maxValue = needExp;
        expSlider.value = exp;
        checkRank();
		checkOutfit();
        StartCoroutine(randAds());
		StartCoroutine(GetMoney());
		StartCoroutine(Emblems.goAuthority());
		StartCoroutine(goPartner());
		StartCoroutine(goBuyPan());
		StartCoroutine(Bosses.TimerFight());
		//StartCoroutine(Passport.goServe());

	}
	
	
	void Update () {
		int percent = 0;
		int percentForPref = 0;
		if (Passport.CadetSchool == 0)
			WageForCadet = 1;
		if (Passport.CadetSchool == 1)
			WageForCadet = 2;
		int ostatok = ((0 + wage + Authority.WageAuthority) * WageForCadet) / 100;
		percentForPref = (ostatok * Status.percentToWage);
		if (idLanguage == 1)
			PlusWageText.text = "бшокюрю: +" + (((0 + wage + Authority.WageAuthority) * WageForCadet) + percentForPref).ToString("N0");
		if (idLanguage == 2)
			PlusWageText.text = "PAYOUT: +" + (((0 + wage + Authority.WageAuthority) * WageForCadet) + percentForPref).ToString("N0");
		expSlider.value = exp;
		expSlider.maxValue = needExp;
		CostSkill1Text.text = "" + costSkill1.ToString("N0");
		CostSkill2Text.text = "" + costSkill2.ToString("N0");
		CostSkill3Text.text = "" + costSkill3.ToString("N0");
		CostSkill4Text.text = "" + costSkill4.ToString("N0");
		CostSkill5Text.text = "" + costSkill5.ToString("N0");
		CostSkill6Text.text = "" + costSkill6.ToString("N0");
		CostSkill7Text.text = "" + costSkill7.ToString("N0");
		LvlSkill1Text.text = "lvl: " + lvlSkill1.ToString("N0");
		LvlSkill2Text.text = "lvl: " + lvlSkill2.ToString("N0");
		LvlSkill3Text.text = "lvl: " + lvlSkill3.ToString("N0");
		LvlSkill4Text.text = "lvl: " + lvlSkill4.ToString("N0");
		LvlSkill5Text.text = "lvl: " + lvlSkill5.ToString("N0");
		LvlSkill6Text.text = "lvl: " + lvlSkill6.ToString("N0");
		LvlSkill7Text.text = "lvl: " + lvlSkill7.ToString("N0");
		ScrollText.text = "" + scroll.ToString("N0");
		numRankText.text = "" + rank.ToString ("N0");
		MoneyText.text = "" + money.ToString("N0");
		GoldText.text = "" + gold.ToString("N0");
		int ost = (wage * WageForCadet) / 100;
		percent = (ost * Status.percentToWage);
		if (Passport.CadetSchool == 0)
			WageForCadet = 1;
		if (Passport.CadetSchool == 1)
			WageForCadet = 2;
		if (idLanguage == 1)
			WageText.text = "гюпокюрю: " + ((wage * WageForCadet) + percent).ToString("N0");
		if (idLanguage == 2)
			WageText.text = "WAGE: " + ((wage * WageForCadet) + percent).ToString("N0");
		if (idForce == 1) {
			if (idLanguage == 1)
				rankText.text = nameRank[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
			if (idLanguage == 2)
				rankText.text = Localization.nameRank_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 2) {
			if (idLanguage == 1)
				rankText.text = nameRankNavy[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
			if (idLanguage == 2)
				rankText.text = Localization.nameRankNavy_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 3) {
			if (idLanguage == 1)
				rankText.text = nameRankPolice[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
			if (idLanguage == 2)
				rankText.text = Localization.nameRankPolice_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 4) {
			if (idLanguage == 1)
				rankText.text = nameRankFBI[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
			if (idLanguage == 2)
				rankText.text = Localization.nameRankFBI_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 5) {
			if (idLanguage == 1)
				rankText.text = nameRankSPY[rank - 1]; 		// щрн фе днаюбхрэ б PASSPORT.CS
			if (idLanguage == 2)
				rankText.text = Localization.nameRankSPY_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 6) {
			if (idLanguage == 1)
				rankText.text = nameRankSpace[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS 
			if (idLanguage == 2)
				rankText.text = Localization.nameRankSpace_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 7) {
			if (idLanguage == 1)
				rankText.text = nameRankVDV[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
			if (idLanguage == 2)
				rankText.text = Localization.nameRankVDV_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 8)
		{
			if (idLanguage == 1)
				rankText.text = nameRankRHBZ[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
			if (idLanguage == 2)
				rankText.text = Localization.nameRankRHBZ_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 9)
		{
			if (idLanguage == 1)
				rankText.text = nameRankPolitic[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
			//if (idLanguage == 2)
			//rankText.text = Localization.nameRankRHBZ_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		if (idForce == 10)
		{
			if (idLanguage == 1)
				rankText.text = nameRankEngineer[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
														   //if (idLanguage == 2)
														   //rankText.text = Localization.nameRankRHBZ_EN[rank - 1]; // щрн фе днаюбхрэ б PASSPORT.CS
		}
		checkRank();
		CheckWage();
		checkOutfit();
		if (bonusForClick > 1) {
			if (idLanguage == 1)
				BonusText.text = "x" + bonusForClick + ": " + countBonus + " ЙКХЙНБ";
			if (idLanguage == 2)
				BonusText.text = "x" + bonusForClick + ": " + countBonus + " clicks";
		}
        for (int i = 0; i < NumAdsForMedalText.Length; i++)
        {
            NumAdsForMedalText[i].text = "" + NumAdsForMedal[i];
        }

            //clickTextPool.transform.Translate(randomVector * Time.deltaTime);
		/*if (BuyBonus.buyContent == 1) {
			BuyContentPan.SetActive (false);
			//iconBuy.SetActive (false);
		} 
		if (BuyBonus.buyContent == 0) {
			BuyContentPan.SetActive (true);
			//iconBuy.SetActive (true);
		}
		if (BuyBonus.buyContent60 == 1) {
			BuyContent60Pan.SetActive (false);
			//iconBuy.SetActive (false);
		} 
		if (BuyBonus.buyContent60 == 0) {
			BuyContent60Pan.SetActive (true);
			//iconBuy.SetActive (true);
		}
		if (BuyBonus.buyContent99 == 1) {
			BuyContent99Pan.SetActive (false);
			//iconBuy.SetActive (false);
		} 
		if (BuyBonus.buyContent99 == 0) {
			BuyContent99Pan.SetActive (true);
			//iconBuy.SetActive (true);
		}
		if (BuyBonus.buyContent159 == 1) {
			BuyContent159Pan.SetActive (false);
			//iconBuy.SetActive (true);
		}
		if (BuyBonus.buyContent159 == 0) {
			BuyContent159Pan.SetActive (true);
			//iconBuy.SetActive (true);
		}*/

		if (rank >= 9 && idForce == 1) {
			if (idLanguage == 1)
				OfficerText.text = "нтхжеп";
			if (idLanguage == 2)
				OfficerText.text = "OFFICER";
		} else if (rank >= 13 && idForce == 2) {
			if (idLanguage == 1)
				OfficerText.text = "ярюпьхи нтхжеп";
			if (idLanguage == 2)
				OfficerText.text = "SENIOR OFFICER";
		} else if (rank >= 15 && idForce == 3) {
			if (idLanguage == 1)
				OfficerText.text = "бшяьхи мювюкэярбсчыхи янярюб";
			if (idLanguage == 2)
				OfficerText.text = "HIGHER PRIMARY COMPOSITION";
		} else if (rank >= 9 && idForce == 4) {
			if (idLanguage == 1)
				OfficerText.text = "хмяоейжхъ";
			if (idLanguage == 2)
				OfficerText.text = "INSPECTION";
		} else if (rank >= 10 && idForce == 5) {
			if (idLanguage == 1)
				OfficerText.text = "опнтеяяхнмюк";
			if (idLanguage == 2)
				OfficerText.text = "PROFESSIONAL";
		} else if (rank >= 10 && idForce == 6) {
			if (idLanguage == 1)
				OfficerText.text = "нтхжеп";
			if (idLanguage == 2)
				OfficerText.text = "OFFICER";
		} else if (rank >= 10 && idForce == 7) {
			if (idLanguage == 1)
				OfficerText.text = "нтхжеп";
			if (idLanguage == 2)
				OfficerText.text = "OFFICER";
		} else if (rank >= 10 && idForce == 8) {
			if (idLanguage == 1)
				OfficerText.text = "нтхжеп";
			if (idLanguage == 2)
				OfficerText.text = "OFFICER";
		}
		else if (rank >= 10 && idForce == 9) {
			if (idLanguage == 1)
				OfficerText.text = "опюбкемхе";
			if (idLanguage == 2)
				OfficerText.text = "GOVERNMENT";
		}
		else if (rank >= 9 && idForce == 10)
		{
			if (idLanguage == 1)
				OfficerText.text = "нтхжеп";
			if (idLanguage == 2)
				OfficerText.text = "OFFICER";
		}
		else
			OfficerText.text = " ";

		if (yesRate == 1)
			RateBttn.SetActive (false);
		
		//if (Cadet.processCader == 0) {
			if (count [0] <= 300 && rank >= 2)
				waitBttns [0].SetActive (true);
			if (count [1] <= 550 && rank >= 4)
				waitBttns [1].SetActive (true);
			if (count [2] <= 1000 && rank >= 6)
				waitBttns [2].SetActive (true);
			if (count [3] <= 2000 && rank >= 8)
				waitBttns [3].SetActive (true);
			if (count [4] <= 3000 && rank >= 10)
				waitBttns [4].SetActive (true);
			if (count [5] <= 5000 && rank >= 12)
				waitBttns [5].SetActive (true);
			if (count [6] <= 9000 && rank >= 14)
				waitBttns [6].SetActive (true);
			if (count [7] <= 15000 && rank >= 16)
				waitBttns [7].SetActive (true);

			if (idForce == 1 && rank == 19) {
				rank = 19;
				exp = 170000;
				Passport.militatyTicket = 1;
			}
			if (idForce == 2 && rank == 19) {
				rank = 19;
				exp = 170000;
			}
			if (idForce == 3 && rank == 18) {
				rank = 18;
				exp = 130000;
			}
			if (idForce == 4 && rank == 16) {
				rank = 16;
				exp = 85000;
			}
			if (idForce == 5 && rank == 18) {
				rank = 18;
				exp = 130000;
			}
			if (idForce == 6 && rank == 18) {
				rank = 18;
				exp = 130000;
			}
			if (idForce == 7 && rank == 19) {
				rank = 19;
				exp = 170000;
			}
			if (idForce == 8 && rank == 19) {
				rank = 19;
				exp = 170000;
			}
			if (idForce == 9 && rank == 19)
			{
				rank = 19;
				exp = 170000;
			}
			if (idForce == 10 && rank == 19)
			{
				rank = 19;
				exp = 170000;
			}

		if (Game.idForce == 6) {
				RangImg.SetActive (false);
				RangImg512.SetActive (true);
			} else {
				RangImg.SetActive (true);
				RangImg512.SetActive (false);
			}
		//}

		if (Cadet.processCader == 1) {
			OfficerText.text = "";
			rankText.text = "" + Cadet.nameRankCadet[Cadet.CadetRank - 1];
			numRankText.text = "" + Cadet.CadetRank;
		}
			
	}

    public void ClickRank()
    {
		//if (Cadet.processCader == 0) {
			clickNum += 1;
			count [0] += (((clickatonce * bonusForClick) + bonusForRate) + BonusFromGold);
			count [1] += (((clickatonce * bonusForClick) + bonusForRate) + BonusFromGold);
			count [2] += (((clickatonce * bonusForClick) + bonusForRate) + BonusFromGold);
			count [3] += (((clickatonce * bonusForClick) + bonusForRate) + BonusFromGold);
			count [4] += (((clickatonce * bonusForClick) + bonusForRate) + BonusFromGold);
			count [5] += (((clickatonce * bonusForClick) + bonusForRate) + BonusFromGold);
			count [6] += (((clickatonce * bonusForClick) + bonusForRate) + BonusFromGold);
			count [7] += (((clickatonce * bonusForClick) + bonusForRate) + BonusFromGold);
			if (bonusForClick > 1)
				countBonus -= 1;
			if (count [0] >= 300)
				waitBttns [0].SetActive (false);
			if (count [1] >= 550)
				waitBttns [1].SetActive (false);
			if (count [2] >= 1000)
				waitBttns [2].SetActive (false);
			if (count [3] >= 2000)
				waitBttns [3].SetActive (false);
			if (count [4] >= 3000)
				waitBttns [4].SetActive (false);
			if (count [5] >= 5000)
				waitBttns [5].SetActive (false);
			if (count [6] >= 9000)
				waitBttns [6].SetActive (false);
			if (count [7] >= 15000)
				waitBttns [7].SetActive (false);
			if (countBonus == 0) {
				countBonus = 0;
				bonusForClick = 1;
				BonusText.text = "";
			}
			if (clickNum >= 14) {
				clickNum = 0;
			}
			clickTextPool [clickNum].StartMotion ((((clickatonce + bonusForRate) * bonusForBuy) * bonusForClick) + BonusFromGold);
			//Destroy(clickTextPool[clickNum], 2f);
			clickNum = clickNum == clickTextPool.Length - 1 ? 0 : clickNum + 1;
			if (rank == 19 && idForce != 3 && idForce != 4  && idForce != 5  && idForce != 6) {
				exp += 0;
				expSlider.value += needExp;
			} else if (rank == 18 && idForce == 3) {
				exp += 0;
				expSlider.value += needExp;
			} else if (rank == 16 && idForce == 4) {
				exp += 0;
				expSlider.value += needExp;
			} else if (rank == 18 && idForce == 5) {
				exp += 0;
				expSlider.value += needExp;
			} else if (rank == 18 && idForce == 6) {
				exp += 0;
				expSlider.value += needExp;
			} else {
				exp += ((((clickatonce + bonusForRate) * bonusForBuy) * bonusForClick) + BonusFromGold);
				expSlider.value += ((((clickatonce + bonusForRate) * bonusForBuy) * bonusForClick) + BonusFromGold);
				if (exp >= needExp) {
					upRank ();
				}
			}
		int randGold = 0;
		randGold = Random.Range(0, 10000);
		if (randGold <= (10 + percentGoldForClick))
		{
			Game.gold += 1;
			GameObject gold_obj = Instantiate(PlusGoldPref, PlusGoldPref.transform.position, Quaternion.identity) as GameObject;
			gold_obj.transform.SetParent(clickParent.transform);
			gold_obj.transform.localScale = new Vector3(1f, 1f, 1f);
			gold_obj.transform.localPosition = new Vector3(-20f, 160f, 0f);
			Destroy(gold_obj, 3f);
		}
		//}

    }

    public void upRank()
    {
		
        //else
        //{
            rank += 1;
            needExp = expForRank[rank - 1];
            expSlider.maxValue = needExp;
            rankText.text = nameRank[rank - 1];
            expSlider.value = 0;
            exp = 0;
			if (idForce == 1) {
				if (rank == 2)
					RankUpImg.sprite = upRank2;
				if (rank == 3)
					RankUpImg.sprite = upRank3;
				if (rank == 4)
					RankUpImg.sprite = upRank4;
				if (rank == 5)
					RankUpImg.sprite = upRank5;
				if (rank == 6)
					RankUpImg.sprite = upRank6;
				if (rank == 7)
					RankUpImg.sprite = upRank7;
				if (rank == 8)
					RankUpImg.sprite = upRank8;
				if (rank == 9)
					RankUpImg.sprite = upRank9;
				if (rank == 10)
					RankUpImg.sprite = upRank10;
				if (rank == 11)
					RankUpImg.sprite = upRank11;
				if (rank == 12)
					RankUpImg.sprite = upRank12;
				if (rank == 13)
					RankUpImg.sprite = upRank13;
				if (rank == 14)
					RankUpImg.sprite = upRank14;
				if (rank == 15)
					RankUpImg.sprite = upRank15;
				if (rank == 16)
					RankUpImg.sprite = upRank16;
				if (rank == 17)
					RankUpImg.sprite = upRank17;
				if (rank == 18)
					RankUpImg.sprite = upRank18;
				if (rank == 19)
					RankUpImg.sprite = upRank19;
				RankUpPan.SetActive (true);
			//}
        }
    }

    public void checkRank()
    {
		if (idForce == 1) {
			if (rank == 1)
				RankImg.sprite = Rank_1;
			if (rank == 2)
				RankImg.sprite = Rank_2;
			if (rank == 3)
				RankImg.sprite = Rank_3;
			if (rank == 4)
				RankImg.sprite = Rank_4;
			if (rank == 5)
				RankImg.sprite = Rank_5;
			if (rank == 6)
				RankImg.sprite = Rank_6;
			if (rank == 7)
				RankImg.sprite = Rank_7;
			if (rank == 8)
				RankImg.sprite = Rank_8;
			if (rank == 9)
				RankImg.sprite = Rank_9;
			if (rank == 10)
				RankImg.sprite = Rank_10;
			if (rank == 11)
				RankImg.sprite = Rank_11;
			if (rank == 12)
				RankImg.sprite = Rank_12;
			if (rank == 13)
				RankImg.sprite = Rank_13;
			if (rank == 14)
				RankImg.sprite = Rank_14;
			if (rank == 15)
				RankImg.sprite = Rank_15;
			if (rank == 16)
				RankImg.sprite = Rank_16;
			if (rank == 17)
				RankImg.sprite = Rank_17;
			if (rank == 18)
				RankImg.sprite = Rank_18;
			if (rank == 19)
				RankImg.sprite = Rank_19;
		}
		if (idForce == 2) {
			if (rank == 1)
				RankNavyImg.sprite = RankNavy_1;
			if (rank == 2)
				RankNavyImg.sprite = RankNavy_2;
			if (rank == 3)
				RankNavyImg.sprite = RankNavy_3;
			if (rank == 4)
				RankNavyImg.sprite = RankNavy_4;
			if (rank == 5)
				RankNavyImg.sprite = RankNavy_5;
			if (rank == 6)
				RankNavyImg.sprite = RankNavy_6;
			if (rank == 7)
				RankNavyImg.sprite = RankNavy_7;
			if (rank == 8)
				RankNavyImg.sprite = RankNavy_8;
			if (rank == 9)
				RankNavyImg.sprite = RankNavy_9;
			if (rank == 10)
				RankNavyImg.sprite = RankNavy_10;
			if (rank == 11)
				RankNavyImg.sprite = RankNavy_11;
			if (rank == 12)
				RankNavyImg.sprite = RankNavy_12;
			if (rank == 13)
				RankNavyImg.sprite = RankNavy_13;
			if (rank == 14)
				RankNavyImg.sprite = RankNavy_14;
			if (rank == 15)
				RankNavyImg.sprite = RankNavy_15;
			if (rank == 16)
				RankNavyImg.sprite = RankNavy_16;
			if (rank == 17)
				RankNavyImg.sprite = RankNavy_17;
			if (rank == 18)
				RankNavyImg.sprite = RankNavy_18;
			if (rank == 19) {
				RankNavyImg.sprite = RankNavy_19;
				finishNavy = 1;
			}
		}

			if (idForce == 3) {
				if (rank == 1)
					RankPoliceImg.sprite = RankPolice_1;
				if (rank == 2)
				RankPoliceImg.sprite = RankPolice_2;
				if (rank == 3)
				RankPoliceImg.sprite = RankPolice_3;
				if (rank == 4)
				RankPoliceImg.sprite = RankPolice_4;
				if (rank == 5)
				RankPoliceImg.sprite = RankPolice_5;
				if (rank == 6)
				RankPoliceImg.sprite = RankPolice_6;
				if (rank == 7)
				RankPoliceImg.sprite = RankPolice_7;
				if (rank == 8)
				RankPoliceImg.sprite = RankPolice_8;
				if (rank == 9)
				RankPoliceImg.sprite = RankPolice_9;
				if (rank == 10)
				RankPoliceImg.sprite = RankPolice_10;
				if (rank == 11)
				RankPoliceImg.sprite = RankPolice_11;
				if (rank == 12)
				RankPoliceImg.sprite = RankPolice_12;
				if (rank == 13)
				RankPoliceImg.sprite = RankPolice_13;
				if (rank == 14)
				RankPoliceImg.sprite = RankPolice_14;
				if (rank == 15)
				RankPoliceImg.sprite = RankPolice_15;
				if (rank == 16)
				RankPoliceImg.sprite = RankPolice_16;
				if (rank == 17)
				RankPoliceImg.sprite = RankPolice_17;
				if (rank == 18) {
				RankPoliceImg.sprite = RankPolice_18;
				finishPolice = 1;
				}
			}

		if (idForce == 4) {
			if (rank == 1)
				RankFBIImg.sprite = RankFBI_1;
			if (rank == 2)
				RankFBIImg.sprite = RankFBI_2;
			if (rank == 3)
				RankFBIImg.sprite = RankFBI_3;
			if (rank == 4)
				RankFBIImg.sprite = RankFBI_4;
			if (rank == 5)
				RankFBIImg.sprite = RankFBI_5;
			if (rank == 6)
				RankFBIImg.sprite = RankFBI_6;
			if (rank == 7)
				RankFBIImg.sprite = RankFBI_7;
			if (rank == 8)
				RankFBIImg.sprite = RankFBI_8;
			if (rank == 9)
				RankFBIImg.sprite = RankFBI_9;
			if (rank == 10)
				RankFBIImg.sprite = RankFBI_10;
			if (rank == 11)
				RankFBIImg.sprite = RankFBI_11;
			if (rank == 12)
				RankFBIImg.sprite = RankFBI_12;
			if (rank == 13)
				RankFBIImg.sprite = RankFBI_13;
			if (rank == 14)
				RankFBIImg.sprite = RankFBI_14;
			if (rank == 15)
				RankFBIImg.sprite = RankFBI_15;
			if (rank == 16)
				RankFBIImg.sprite = RankFBI_16;
		}

		if (idForce == 5) {
			if (rank == 1)
				RankSPYImg.sprite = RankSPY_1;
			if (rank == 2)
				RankSPYImg.sprite = RankSPY_2;
			if (rank == 3)
				RankSPYImg.sprite = RankSPY_3;
			if (rank == 4)
				RankSPYImg.sprite = RankSPY_4;
			if (rank == 5)
				RankSPYImg.sprite = RankSPY_5;
			if (rank == 6)
				RankSPYImg.sprite = RankSPY_6;
			if (rank == 7)
				RankSPYImg.sprite = RankSPY_7;
			if (rank == 8)
				RankSPYImg.sprite = RankSPY_8;
			if (rank == 9)
				RankSPYImg.sprite = RankSPY_9;
			if (rank == 10)
				RankSPYImg.sprite = RankSPY_10;
			if (rank == 11)
				RankSPYImg.sprite = RankSPY_11;
			if (rank == 12)
				RankSPYImg.sprite = RankSPY_12;
			if (rank == 13)
				RankSPYImg.sprite = RankSPY_13;
			if (rank == 14)
				RankSPYImg.sprite = RankSPY_14;
			if (rank == 15)
				RankSPYImg.sprite = RankSPY_15;
			if (rank == 16)
				RankSPYImg.sprite = RankSPY_16;
			if (rank == 17)
				RankSPYImg.sprite = RankSPY_17;
			if (rank == 18)
				RankSPYImg.sprite = RankSPY_18;
		}

		if (idForce == 6) {
			if (rank == 1)
				RankSpaceImg.sprite = RankSpace_1;
			if (rank == 2)
				RankSpaceImg.sprite = RankSpace_2;
			if (rank == 3)
				RankSpaceImg.sprite = RankSpace_3;
			if (rank == 4)
				RankSpaceImg.sprite = RankSpace_4;
			if (rank == 5)
				RankSpaceImg.sprite = RankSpace_5;
			if (rank == 6)
				RankSpaceImg.sprite = RankSpace_6;
			if (rank == 7)
				RankSpaceImg.sprite = RankSpace_7;
			if (rank == 8)
				RankSpaceImg.sprite = RankSpace_8;
			if (rank == 9)
				RankSpaceImg.sprite = RankSpace_9;
			if (rank == 10)
				RankSpaceImg.sprite = RankSpace_10;
			if (rank == 11)
				RankSpaceImg.sprite = RankSpace_11;
			if (rank == 12)
				RankSpaceImg.sprite = RankSpace_12;
			if (rank == 13)
				RankSpaceImg.sprite = RankSpace_13;
			if (rank == 14)
				RankSpaceImg.sprite = RankSpace_14;
			if (rank == 15)
				RankSpaceImg.sprite = RankSpace_15;
			if (rank == 16)
				RankSpaceImg.sprite = RankSpace_16;
			if (rank == 17)
				RankSpaceImg.sprite = RankSpace_17;
			if (rank == 18)
				RankSpaceImg.sprite = RankSpace_18;
		}
		if (idForce == 7) {
			if (rank == 1)
				RankVDVImg.sprite = RankVDV_1;
			if (rank == 2)
				RankVDVImg.sprite = RankVDV_2;
			if (rank == 3)
				RankVDVImg.sprite = RankVDV_3;
			if (rank == 4)
				RankVDVImg.sprite = RankVDV_4;
			if (rank == 5)
				RankVDVImg.sprite = RankVDV_5;
			if (rank == 6)
				RankVDVImg.sprite = RankVDV_6;
			if (rank == 7)
				RankVDVImg.sprite = RankVDV_7;
			if (rank == 8)
				RankVDVImg.sprite = RankVDV_8;
			if (rank == 9)
				RankVDVImg.sprite = RankVDV_9;
			if (rank == 10)
				RankVDVImg.sprite = RankVDV_10;
			if (rank == 11)
				RankVDVImg.sprite = RankVDV_11;
			if (rank == 12)
				RankVDVImg.sprite = RankVDV_12;
			if (rank == 13)
				RankVDVImg.sprite = RankVDV_13;
			if (rank == 14)
				RankVDVImg.sprite = RankVDV_14;
			if (rank == 15)
				RankVDVImg.sprite = RankVDV_15;
			if (rank == 16)
				RankVDVImg.sprite = RankVDV_16;
			if (rank == 17)
				RankVDVImg.sprite = RankVDV_17;
			if (rank == 18)
				RankVDVImg.sprite = RankVDV_18;
			if (rank == 19) {
				RankVDVImg.sprite = RankVDV_19;
				finishVDV = 1;
			}
		}
		if (idForce == 8) {
			if (rank == 1)
				RankRHBZImg.sprite = RankRHBZ_1;
			if (rank == 2)
				RankRHBZImg.sprite = RankRHBZ_2;
			if (rank == 3)
				RankRHBZImg.sprite = RankRHBZ_3;
			if (rank == 4)
				RankRHBZImg.sprite = RankRHBZ_4;
			if (rank == 5)
				RankRHBZImg.sprite = RankRHBZ_5;
			if (rank == 6)
				RankRHBZImg.sprite = RankRHBZ_6;
			if (rank == 7)
				RankRHBZImg.sprite = RankRHBZ_7;
			if (rank == 8)
				RankRHBZImg.sprite = RankRHBZ_8;
			if (rank == 9)
				RankRHBZImg.sprite = RankRHBZ_9;
			if (rank == 10)
				RankRHBZImg.sprite = RankRHBZ_10;
			if (rank == 11)
				RankRHBZImg.sprite = RankRHBZ_11;
			if (rank == 12)
				RankRHBZImg.sprite = RankRHBZ_12;
			if (rank == 13)
				RankRHBZImg.sprite = RankRHBZ_13;
			if (rank == 14)
				RankRHBZImg.sprite = RankRHBZ_14;
			if (rank == 15)
				RankRHBZImg.sprite = RankRHBZ_15;
			if (rank == 16)
				RankRHBZImg.sprite = RankRHBZ_16;
			if (rank == 17)
				RankRHBZImg.sprite = RankRHBZ_17;
			if (rank == 18)
				RankRHBZImg.sprite = RankRHBZ_18;
			if (rank == 19) {
				RankRHBZImg.sprite = RankRHBZ_19;
				finishRHBZ = 1;
			}
		}
		if (idForce == 9)
		{
			if (rank == 1)
				RankPoliticImg.sprite = RankPolitic_1;
			if (rank == 2)
				RankPoliticImg.sprite = RankPolitic_2;
			if (rank == 3)
				RankPoliticImg.sprite = RankPolitic_3;
			if (rank == 4)
				RankPoliticImg.sprite = RankPolitic_4;
			if (rank == 5)
				RankPoliticImg.sprite = RankPolitic_5;
			if (rank == 6)
				RankPoliticImg.sprite = RankPolitic_6;
			if (rank == 7)
				RankPoliticImg.sprite = RankPolitic_7;
			if (rank == 8)
				RankPoliticImg.sprite = RankPolitic_8;
			if (rank == 9)
				RankPoliticImg.sprite = RankPolitic_9;
			if (rank == 10)
				RankPoliticImg.sprite = RankPolitic_10;
			if (rank == 11)
				RankPoliticImg.sprite = RankPolitic_11;
			if (rank == 12)
				RankPoliticImg.sprite = RankPolitic_12;
			if (rank == 13)
				RankPoliticImg.sprite = RankPolitic_13;
			if (rank == 14)
				RankPoliticImg.sprite = RankPolitic_14;
			if (rank == 15)
				RankPoliticImg.sprite = RankPolitic_15;
			if (rank == 16)
				RankPoliticImg.sprite = RankPolitic_16;
			if (rank == 17)
				RankPoliticImg.sprite = RankPolitic_17;
			if (rank == 18)
				RankPoliticImg.sprite = RankPolitic_18;
			if (rank == 19)
			{
				RankPoliticImg.sprite = RankPolitic_19;
				finishPolitic = 1;
			}
		}
		if (idForce == 10)
		{
			if (rank == 1)
				RankEngineerImg.sprite = RankEngineer_1;
			if (rank == 2)
				RankEngineerImg.sprite = RankEngineer_2;
			if (rank == 3)
				RankEngineerImg.sprite = RankEngineer_3;
			if (rank == 4)
				RankEngineerImg.sprite = RankEngineer_4;
			if (rank == 5)
				RankEngineerImg.sprite = RankEngineer_5;
			if (rank == 6)
				RankEngineerImg.sprite = RankEngineer_6;
			if (rank == 7)
				RankEngineerImg.sprite = RankEngineer_7;
			if (rank == 8)
				RankEngineerImg.sprite = RankEngineer_8;
			if (rank == 9)
				RankEngineerImg.sprite = RankEngineer_9;
			if (rank == 10)
				RankEngineerImg.sprite = RankEngineer_10;
			if (rank == 11)
				RankEngineerImg.sprite = RankEngineer_11;
			if (rank == 12)
				RankEngineerImg.sprite = RankEngineer_12;
			if (rank == 13)
				RankEngineerImg.sprite = RankEngineer_13;
			if (rank == 14)
				RankEngineerImg.sprite = RankEngineer_14;
			if (rank == 15)
				RankEngineerImg.sprite = RankEngineer_15;
			if (rank == 16)
				RankEngineerImg.sprite = RankEngineer_16;
			if (rank == 17)
				RankEngineerImg.sprite = RankEngineer_17;
			if (rank == 18)
				RankEngineerImg.sprite = RankEngineer_18;
			if (rank == 19)
			{
				RankEngineerImg.sprite = RankEngineer_19;
				finishEngineer = 1;
			}
		}
		if (rank >= 2)
            blockBttns[0].SetActive(false);
		else 
			blockBttns[0].SetActive(true);
        if (rank >= 4)
            blockBttns[1].SetActive(false);
		else 
			blockBttns[1].SetActive(true);
        if (rank >= 6)
            blockBttns[2].SetActive(false);
		else 
			blockBttns[2].SetActive(true);
        if (rank >= 8)
            blockBttns[3].SetActive(false);
		else 
			blockBttns[3].SetActive(true);
        if (rank >= 10)
            blockBttns[4].SetActive(false);
		else 
			blockBttns[4].SetActive(true);
        if (rank >= 12)
            blockBttns[5].SetActive(false);
		else 
			blockBttns[5].SetActive(true);
        if (rank >= 14)
            blockBttns[6].SetActive(false);
		else 
			blockBttns[6].SetActive(true);
        if (rank >= 16)
            blockBttns[7].SetActive(false);
		else 
			blockBttns[7].SetActive(true);
       /*if (rank >= 18)
            blockBttns[8].SetActive(false);*/
    }

    public void pushUp()
    {
        exp += 50;
        expSlider.value += 50;
        waitBttns[0].SetActive(true);
        count[0] = 0;

    }

    public void fight()
    {
        exp += 100;
        expSlider.value += 100;
        waitBttns[1].SetActive(true);
        count[1] = 0;

    }

    public void speed()
    {
        exp += 200;
        expSlider.value += 200;
        waitBttns[2].SetActive(true);
        count[2] = 0;

    }

    public void shoting()
    {
        exp += 500;
        expSlider.value += 500;
        waitBttns[3].SetActive(true);
        count[3] = 0;

    }

    public void stundUp()
    {
        exp += 1000;
        expSlider.value += 1000;
        waitBttns[4].SetActive(true);
        count[4] = 0;
    }

    public void tank()
    {
        exp += 2000;
        expSlider.value += 2000;
        waitBttns[5].SetActive(true);
        count[5] = 0;
    }

    public void camping()
    {
        exp += 3500;
        expSlider.value += 3500;
        waitBttns[6].SetActive(true);
        count[6] = 0;
    }

    public void medal()
    {
        exp += 6000;
        expSlider.value += 6000;
        waitBttns[7].SetActive(true);
        count[7] = 0;
    }

	public void buySkill1() {
		if (Game.money >= costSkill1) {
			lvlSkill1++;
			bonusMoney += 1;
			Game.money -= costSkill1;
			int proc = ((costSkill1 * 25) / 100);
			costSkill1 += proc;
		}
	}

	public void buySkill2() {
		if (Game.money >= costSkill2) {
			lvlSkill2++;
			bonusMoney += 2;
			Game.money -= costSkill2;
			int proc = ((costSkill2 * 25) / 100);
			costSkill2 += proc;
		}
	}

	public void buySkill3()
	{
		if (Game.money >= costSkill3)
		{
			lvlSkill3++;
			bonusMoney += 3;
			Game.money -= costSkill3;
			int proc = ((costSkill3 * 25) / 100);
			costSkill3 += proc;
		}
	}

	public void buySkill4()
	{
		if (Game.money >= costSkill4)
		{
			lvlSkill4++;
			bonusMoney += 4;
			Game.money -= costSkill4;
			int proc = ((costSkill4 * 25) / 100);
			costSkill4 += proc;
		}
	}

	public void buySkill5()
	{
		if (Game.money >= costSkill5)
		{
			lvlSkill5++;
			bonusMoney += 5;
			Game.money -= costSkill5;
			int proc = ((costSkill5 * 25) / 100);
			costSkill5 += proc;
		}
	}

	public void buySkill6()
	{
		if (Game.gold >= costSkill6)
		{
			lvlSkill6++;
			BonusFromGold += 1;
			Game.gold -= costSkill6;
			costSkill6 += 20;
		}
	}

	public void buySkill7()
	{
		if (Game.gold >= costSkill7)
		{
			lvlSkill7++;
			percentGoldForClick += 100;
			Game.gold -= costSkill7;
			costSkill7 += 10;
		}
	}

	public IEnumerator randAds()
    {
        //yield return new WaitForSeconds(10f);
        while (true)
        {
            yield return new WaitForSeconds(50f);
            idAds = Random.Range(1, 10);
            if (idAds == 1)
                adsx2.SetActive(true);
            if (idAds == 2 || idAds == 3)
                adsx3.SetActive(true);
            if (idAds == 4 || idAds == 5)
                adsx4.SetActive(true);
            if (idAds > 5)
                adsx5.SetActive(true);
            yield return new WaitForSeconds(15f);
            adsx2.SetActive(false);
            adsx3.SetActive(false);
            adsx4.SetActive(false);
            adsx5.SetActive(false);
        }
    }

	public void CheckWage() {
		if (rank == 1)
			wage = (0 + bonusMoney);
		if (rank == 2)
			wage = (1 + bonusMoney);
		if (rank == 3)
			wage = (2 + bonusMoney);
		if (rank == 4)
			wage = (3 + bonusMoney);
		if (rank == 5)
			wage = (4 + bonusMoney);
		if (rank == 6)
			wage = (5 + bonusMoney);
		if (rank == 7)
			wage = (6 + bonusMoney);
		if (rank == 8)
			wage = (7 + bonusMoney);
		if (rank == 9)
			wage = (8 + bonusMoney);
		if (rank == 10)
			wage = (9 + bonusMoney);
		if (rank == 11)
			wage = (10 + bonusMoney);
		if (rank == 12)
			wage = (12 + bonusMoney);
		if (rank == 12)
			wage = (15 + bonusMoney);
		if (rank == 13)
			wage = (18 + bonusMoney);
		if (rank == 14)
			wage = (20 + bonusMoney);
		if (rank == 15)
			wage = (24 + bonusMoney);
		if (rank == 16)
			wage = (30 + bonusMoney);
		if (rank == 17)
			wage = (40 + bonusMoney);
		if (rank == 18)
			wage = (50 + bonusMoney);
		if (rank == 19)
			wage = (100 + bonusMoney);
	}

	public void checkOutfit() {
		if (Outfit.idOutfit == 2) {
			OutfitImg.sprite = Outfit1;
		}
		if (Outfit.idOutfit == 3) {
			OutfitImg.sprite = Outfit2;
		}
		if (Outfit.idOutfit == 4) {
			OutfitImg.sprite = Outfit3;
		}
		if (Outfit.idOutfit == 5) {
			OutfitImg.sprite = Outfit4;
		}
		if (Outfit.idOutfit == 6) {
			OutfitImg.sprite = Outfit5;
		}
		if (Outfit.idOutfit == 7) {
			OutfitImg.sprite = Outfit6;
		}
		if (Outfit.idOutfit == 8) {
			OutfitImg.sprite = Outfit7;
		}
		if (Outfit.idOutfit == 9) {
			OutfitImg.sprite = Outfit8;
		}
		if (Outfit.idOutfit == 10) {
			OutfitImg.sprite = Outfit9;
		}
		if (Outfit.idOutfit == 11) {
			OutfitImg.sprite = Outfit10;
		}
		if (Outfit.idOutfit == 12) {
			OutfitImg.sprite = Outfit11;
		}
		if (Outfit.idOutfit == 13) {
			OutfitImg.sprite = Outfit12;
		}
		if (Outfit.idOutfit == 14) {
			OutfitImg.sprite = Outfit13;
		}
		if (Outfit.idOutfit == 15) {
			OutfitImg.sprite = Outfit14;
		}
		if (Outfit.idOutfit == 16) {
			OutfitImg.sprite = Outfit15;
		}
		if (Outfit.idOutfit == 17) {
			OutfitImg.sprite = Outfit16;
		}
		if (Outfit.idOutfit == 18) {
			OutfitImg.sprite = Outfit17;
		}
		if (Outfit.idOutfit == 19) {
			OutfitImg.sprite = Outfit18;
		}
		if (Outfit.idOutfit == 20) {
			OutfitImg.sprite = Outfit19;
		}
		if (Outfit.idOutfit == 21) {
			OutfitImg.sprite = Outfit20;
		}
		if (Outfit.idOutfit == 22) {
			OutfitImg.sprite = Outfit21;
		}
		if (Outfit.idOutfit == 23) {
			OutfitImg.sprite = Outfit22;
		}
		if (Outfit.idOutfit == 24) {
			OutfitImg.sprite = Outfit23;
		}
		if (Outfit.idOutfit == 25) {
			OutfitImg.sprite = Outfit24;
		}
		if (Outfit.idOutfit == 26) {
			OutfitImg.sprite = Outfit25;
		}
		if (Outfit.idOutfit == 27) {
			OutfitImg.sprite = Outfit26;
		}
		if (Outfit.idOutfit == 28) {
			OutfitImg.sprite = Outfit27;
		}
	}

	public IEnumerator GetMoney() {
		while (true) {
			if (Passport.CadetSchool == 0)
				WageForCadet = 1;
			if (Passport.CadetSchool == 1)
				WageForCadet = 2;
			if (rank == 1)
			{
				money += (((0 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((0 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((0 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 2)
			{
				money += (((1 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((1 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((1 + bonusMoney) + Authority.WageAuthority) * WageForCadet);

			}
			if (rank == 3)
			{
				money += (((2 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((2 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((2 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 4)
			{
				money += (((3 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((3 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((3 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 5)
			{
				money += (((4 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((4 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((4 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 6)
			{
				money += (((5 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((5 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((5 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 7)
			{
				money += (((6 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((6 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((6 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 8)
			{
				money += (((7 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((7 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((7 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 9)
			{
				money += (((8 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((8 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((8 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 10)
			{
				money += (((9 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((9 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((9 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 11)
			{
				money += (((10 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((10 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((10 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 12)
			{
				money += (((12 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((12 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((12 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 13)
			{
				money += (((18 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((18 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((18 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 14)
			{
				money += (((20 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((20 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((20 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 15)
			{
				money += (((24 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((24 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((24 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 16)
			{
				money += (((30 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((30 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((30 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 17)
			{
				money += (((40 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((40 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((40 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 18)
			{
				money += (((50 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((50 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((50 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			if (rank == 19)
			{
				money += (((100 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
				int percent = (((100 + bonusMoney) + Authority.WageAuthority) * WageForCadet) / 100;
				money += (percent * Status.percentToWage);
				Status.totalEarnedMoney += (((100 + bonusMoney) + Authority.WageAuthority) * WageForCadet);
			}
			GameObject money_obj = Instantiate(PlusWagePref, PlusWagePref.transform.position, Quaternion.identity) as GameObject;
			money_obj.transform.SetParent(clickParent.transform);
			money_obj.transform.localScale = new Vector3 (1f, 1f, 1f);
			money_obj.transform.localPosition = new Vector3 (18f, 160f, 0f);
			Destroy(money_obj, 3f);
			yield return new WaitForSeconds(5f);
		}
	}

	public IEnumerator goPartner() {
		while (true) {
			money += Partner.totalProfitMoney;
			Status.totalEarnedMoney += Partner.totalProfitMoney;
			exp += Partner.totalProfitExp;
			yield return new WaitForSeconds (3f);
		}
	}

	public IEnumerator goBuyPan() {
		while (true) {
			yield return new WaitForSeconds (150f);
			if (proVersion == 0)
				BuyPan.SetActive (true);
			if (proVersion == 1)
				BuyPan.SetActive (false);
			yield return new WaitForSeconds (500f);
		}
	}

	public void BuyTimeOfflinePan_open()
	{
		BuyTimeOfflinePan.SetActive(true);
	}

	public void BuyTimeOfflinePan_close()
	{
		BuyTimeOfflinePan.SetActive(false);
	}

	public void InfoPan_Open()
    {
        InfoPan.SetActive(true);
        ClickPan.SetActive(false);
    }

    public void InfoPan_Close()
    {
        ClickPan.SetActive(true);
        InfoPan.SetActive(false);
    }

    public void MedalsPan_Open()
    {
        MedalsPan.SetActive(true);
        ClickPan.SetActive(false);
    }

	public void OutfitPan_Open() {
		OutfitPan.SetActive(true);
		ClickPan.SetActive(false);
	}

	public void OutfitPan_Close() {
		ClickPan.SetActive(true);
		OutfitPan.SetActive(false);
	}

	public void CourtPan_Open()
	{
		CourtPan.SetActive(true);
		ClickPan.SetActive(false);
	}

	public void CourtPan_Close()
	{
		ClickPan.SetActive(true);
		CourtPan.SetActive(false);
	}

    public void MedalsPan_Close()
    {
        ClickPan.SetActive(true);
        MedalsPan.SetActive(false);
    }

	public void RankUpPan_Close() {
		RankUpPan.SetActive (false);
	}

	public void SkillsPan_Open() {
		SkillsPan.SetActive (true);
	}

	public void SkillsPan_Close() {
		SkillsPan.SetActive (false);
	}

	public void ForcesPan_Open() {
		ForcesPan.SetActive (true);
	}

	public void ForcesPan_Close() {
		ForcesPan.SetActive (false);
	}

	public void StatusPan_Open()
	{
		StatusPan.SetActive(true);
	}

	public void StatusPan_Close()
	{
		StatusPan.SetActive(false);
	}

	public void CadetPan_Open() {
		CadetPan.SetActive (true);
	}

	public void CadetPan_Close() {
		CadetPan.SetActive (false);
	}

	public void NotesPan_Open()
	{
		NotesPan.SetActive(true);
	}

	public void NotesPan_Close()
	{
		NotesPan.SetActive(false);
	}

	public void PassportPan_Open() {
		PassportPan.SetActive (true);
	}

	public void PassportPan_Close() {
		PassportPan.SetActive (false);
	}

	public void BossesPan_Open() {
		BossesPan.SetActive (true);
	}

	public void BossesPan_Close() {
		BossesPan.SetActive (false);
	}

	public void PanelForScroll_open()
	{
		PanelForScroll.SetActive(true);
		PanelBuyGold.SetActive(false);
	}

	public void PanelBuyGold_open()
	{
		PanelBuyGold.SetActive(true);
		PanelForScroll.SetActive(false);
	}

	public void GoPanBuyGold ()
	{
		DonatPan.SetActive(true);
		PanelBuyGold.SetActive(true);
		PanelForScroll.SetActive(false);

	}

	public void EmblemsPan_Open() {
		if (rank >= 12 && idForce == 1 || idForce > 1 || BuyBonus.buyContent99 == 1)
			EmblemsPan.SetActive (true);
		else {
			
		}
	}

	public void EmblemsPan_Close() {
		EmblemsPan.SetActive (false);
	}

	public void PartnerPan_Open() {
		PartnerPan.SetActive (true);
	}

	public void PartnerPan_Close() {
		PartnerPan.SetActive (false);
	}

	public void DonatPan_Open() {
		DonatPan.SetActive (true);
	}

	public void DonatPan_Close() {
		DonatPan.SetActive (false);
	}
	public void BuyPan_Ok() {
		DonatPan.SetActive (true);
		BuyPan.SetActive (false);
	}

	public void BuyPan_Close() {
		BuyPan.SetActive (false);
	}

    public void watchads()
    {
        if (Advertisement.IsReady())
        {
            ShowOptions option = new ShowOptions();
            option.resultCallback = HandleShowResult;
            Advertisement.Show("rewardedVideo", option);
        }
    }

    public void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                //Game.bonusForClick = 2;
                //Game.countBonus = 0;
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }

    public void RateGame()
    {
        if (yesRate == 0)
        {
            yesRate = 1;
			Application.OpenURL("market://details?id=com.shikunovsstudio.gettothegeneral");
			bonusForRate = 3;
			RateBttn.SetActive(false);
        }
    }

	public void buyProVersion() {
		Application.OpenURL("market://details?id=com.shikunovsstudio.gettothegeneralpro");
	}

    /*public void plus10rubins()
    {
        if (Advertisement.IsReady())
        {
            ShowOptions option = new ShowOptions();
            option.resultCallback = HandleShowResult;
            Advertisement.Show("rewardedVideo", option);
        }
        //rubins += 10;
    }

    public void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                rubins += 10;
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }*/

}