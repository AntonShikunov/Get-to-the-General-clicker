using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Localization : MonoBehaviour {


	public static string[] nameRank_EN = { "SOLDIER", "CORPORAL", "LANCE SERGEANT", "SERGEANT", "STAFF SERGEANT", "SENIOR",
		"ENSIGN", "SENIOR WARRANT", "SUBLIEUTENANT", "LIEUTENANT",
		"SENIOR LIEUTENANT", "CAPTAIN", "MAJOR", "LIEUTENANT COLONEL", "COLONEL",
		"GENERAL-MAJOR", "GEN-LIEUTENANT", "CENTRAL-GENERAL", "ARMY GENERAL"};

	public static string[] nameRankNavy_EN = { "SAILOR", "SENIOR SAILOR", "SENIOR 2 RANK", "SENIOR 1 RANK", "MASTER SENIOR",
		"MASTER SENIOR OF SHIP", "MICHMAN", "SENIOR MICHMAN", "SUBLIEUTENANT", "LIEUTENANT",
		"SENIOR LIEUTENANT", "CAPTAIN-LT", "CAPTAIN 3 RANK", "CAPTAIN 2 RANK", "CAPTAIN 1 RANK",
		"COUNTER-ADMIRAL", "VICE-ADMIRAL", "ADMIRAL", "FLEET ADMIRAL"};

	public static string[] nameRankPolice_EN = { "SQUADDIE POLICE", "LANCE SERGEANT", "SERGEANT", "SENIOR SERGEANT", "POLICE SENIOR",
		"POLICE WARRANT OFFICER", "SENIOR WARRANT", "SUBLIEUTENANT", "LIEUTENANT", "SENIOR LIEUTENANT",
		"CAPTAIN POLICE", "MAJOR POLICE", "LIEUTENANT COLONEL", "COLONEL POLICE", "GENERAL-MAJOR POLICE",
		"GEN-LIEUTENANT POLICE", "CENTRAL-GENERAL POLICE", "POLICE GENERAL"};

	public static string[] nameRankFBI_EN = { "IMPROVER", "YOUNG FBI AGENT", "FBI AGENT", "SENIOR FBI AGENT", "SPECIAL AGENT",
		"AGENT NATIONAL SECURITY", "AGENTURIAN MANAGER", "FBI ACADEMY HEAD", "AGENT DEP", "DEPUTY HEADS OF DEP MANAGEMENT",
		"HEAD OF MANAGEMENT DEP", "DEPUTY HEADS OF CID MANAGEMENT", "HEAD OF MANAGEMENT CID", "CHIEF NATIONAL SECURITY", "FBI CHIEF INSPECTOR",
		"FBI DIRECTOR"};

	public static string[] nameRankSPY_EN = { "IMPROVER", "WORKER", "YOUNG SPY-S AGENT", "AGENT SPY-S", "SENIOR AGENT SPY-S",
		"CODER", "SHADOW 3 RANK", "SHADOW 2 RANK", "SHADOW 1 RANK", "LIEUTENANT",
		"SENIOR LIEUTENANT", "MAJOR SPYING", "LOOKING KAIN", "COLONEL 2 RANK", "COLONEL 1 RANK",
		"UNSECURABLE AGENT", "COUNTER-INSPECTOR", "SPY DIRECTOR"};

	public static string[] nameRankSpace_EN = { "IMPROVER", "JUNIOR PILOT", "TEAM ASSISTANT", "AGENT OF PILOTS", "MENTOR OF GROUP", "CHIEF OF GROUP",
		"CHAPTER OF THE ACADEMY OF AIR", "GROUP MANAGER", "AGENT OF X-SPACE GROUP", " SENIOR AGENT OF X-SPACE GROUP",
		"PARTICIPANT OF THE NATIONAL A.F.", "MENTOR OF THE NATIONAL A.F.", "COMMANDER DIVISIONS", 
		"LIEUTENANT COLONEL", "COLONEL", "GEN-MAJOR 1 CLASS", "GEN-MAJOR 2 CLASS", "GENERAL SPACE FORCES"};

	public static string[] nameRankVDV_EN = { "SOLDIER", "CORPORAL", "LANCE SERGEANT", "SERGEANT", "STAFF SERGEANT", "SENIOR",
		"PARATROOPER 1 RANK", "PARATROOPER 2 RANK", "SENIOR PARATROOPER", "LIEUTENANT",
		"SENIOR LIEUTENANT", "CAPTAIN", "MAJOR", "LIEUTENANT COLONEL", "COLONEL",
		"GENERAL-MAJOR", "GEN-LIEUTENANT", "CENTRAL-GENERAL", "ARMY GENERAL"};

	public static string[] nameRankRHBZ_EN = { "SOLDIER", "CORPORAL", "LANCE SERGEANT", "SERGEANT", "STAFF SERGEANT", "SENIOR",
		"ENSIGN", "SENIOR WARRANT", "SUBLIEUTENANT", "LIEUTENANT",
		"SENIOR LIEUTENANT", "CAPTAIN", "MAJOR", "LIEUTENANT COLONEL", "COLONEL",
		"GENERAL-MAJOR", "GEN-LIEUTENANT", "CENTRAL-GENERAL", "ARMY GENERAL"};

	//====================================== ТЕКСТА ===============================================

	// панель кликов
	public Text NeedEmblemText, CaptionOutfit, CaptionEmblems, CaptionPatner, bonusForRate;
	public Text accessEmblems, accessPartner;
	// панель информации
	public Text DescInfoPanText;
	// панель кадета
	public Text DescCadet, StartText, Desc1, WarningCadet, CancelText, WarningCancelText, Desc2, ProgressText, EndCadetText;
	// панель медалей
	public Text DescMedalsPan, x2Text, x3Text, x4Text, x5Text, x10Text;
	// панель навыков
	public Text Skill1Text, Skill2Text, Skill3Text, Skill4Text, Skill5Text, Skill6Text, Skill7Text, DescSkillPanText;
	// панель экипировки
	public Text DescOutfitPanText;
	// панель войск
	public Text DescForcesPanText, WarningForcesText, DescProText, NameNavyText, NamePoliceText, NameFBIText, NameSPYText,
	NameSpaceText, NameArmyText, NameVDVText, NameRHBZText, MoreForcesText;
	// панель эмблем
	public Text DescEmblemsText;
	// панель паспорта
	public Text YearsText, ServeYearsText,
	NumServeText, NumServeForceseText,
	TicketText, MilitaryTicketText,
	CadetSchool, CadetSchoolText,
	TotalWage, TotalWageText,
	NumWinBosses, NumWinBossesText, NumWinCourtsText;
	// панель доната
	public Text DescDonatPanText, Desc30rub, BuyNow30, Desc60rub, BuyNow60, Desc99rub, BuyNow99, Bonus99rub, Desc159rub, BuyNow159, Bonus159rub,
				Desc590rub, BuyNow590, Bonus590rub;
	// панель "КУПИ СЕЙЧАС"
	public Text DescBuyNow, DescBuyNowPan, OkText;
	// панель "Боссы"
	public Text StrengthTextLoc, OnetoStrengthText, NameBoss1Text, PrizeBoss1, ChanceBoss1Text,
	NameBoss2Text, PrizeBoss2, ChanceBoss2Text,
	NameBoss3Text, PrizeBoss3, ChanceBoss3Text,
	NameBoss4Text, PrizeBoss4, ChanceBoss4Text,
	NameBoss5Text, PrizeBoss5, ChanceBoss5Text, 
	FightText, TimerFightText, WinText, CongratulationText, YourPrizeText, OkkText,
	BlockBossText, RequerForBossText;
	// панель экипировок
	public Text CostOutfit13, CostOutfit14, CostOutfit16, CostOutfit19, CostOutfit22, CostOutfit23,
	CostOutfit24, CostOutfit25, CostOutfit26;
	// Панель информации
	public Text FaqMoneyText, FaqAuthorityText, FaqGoldText, FaqScrollText, WarningFaqText;
	// Панель статуса
	public Text FaqStatusText;


	void Update () {
		if (Game.idLanguage == 1) {
			// ПАНЕЛЬ КЛИКОВ
			NeedEmblemText.text = "НУЖНА ЭМБЛЕМА";
			CaptionOutfit.text = "ЭКИПИРОВКА";
			CaptionEmblems.text = "ЭМБЛЕМА";
			CaptionPatner.text = "НАПАРНИКИ";
			bonusForRate.text = "+3 К КЛИКУ";
			//accessEmblems.text = "ДОСТУПНО С 12 РАНГА";
			accessPartner.text = "ДОСТУПНО С 8 РАНГА";
			// ИНФОРМАЦИЯ
			DescInfoPanText.text = "ИНФОРМАЦИЯ";
			// КАДЕТ
			DescCadet.text = "ШКОЛА КУРСАНТА";
			StartText.text = "НАЧАТЬ";
			Desc1.text = "ПРОЙДИТЕ ШКОЛУ КУРСАНТА, ЧТОБ ПОЛУЧИТЬ ВЫСШУЮ СТЕПЕНЬ КВАЛИФИКАЦИИ И УВЕЛИЧИТЬ СВОЙ ЗАРАБОТОК В 2 РАЗА!";
			WarningCadet.text = "ДЛЯ ОБУЧЕНИЯ ТРЕБУЕТСЯ ЛЮБАЯ ЭМБЛЕМА!"; 
			CancelText.text = "ОТМЕНА";
			WarningCancelText.text = "В ЛЮБОЙ МОМЕНТ ВЫ МОЖЕТЕ ПРЕРВАТЬ ОБУЧЕНИЕ, НО В СЛЕДУЮЩИЙ РАЗ ПРИДЁТСЯ НАЧАТЬ ВСЁ СНАЧАЛА.";
			Desc2.text = "ВЫ ОБУЧАЕТЕСЬ!"; 
			ProgressText.text = "ШКАЛА ПРОГРЕССА"; 
			EndCadetText.text = "ВЫ УСПЕШНО ЗАВЕРШИЛИ КАДЕТСКУЮ ШКОЛУ И ПОЛУЧИЛИ КВАЛИФИКАЦИЮ. ВАША ЗАРПЛАТА УВЕЛИЧЕНА В 2 РАЗА.\n\nПОЗДРАВЛЯЕМ!";
			// МЕДАЛИ
			DescMedalsPan.text = "БОНУСНЫЕ МЕДАЛИ";
			x2Text.text = "x2 НАВСЕГДА"; 
			x3Text.text = "x3 НАВСЕГДА"; 
			x4Text.text = "x4 НАВСЕГДА"; 
			x5Text.text = "x5 НАВСЕГДА"; 
			x10Text.text = "x10 НАВСЕГДА";
			// НАВЫКИ
			Skill1Text.text = "ПОВЫШАЕТ АГРЕССИЮ"; 
			Skill2Text.text = "ПОВЫШАЕТ КРАСНОРЕЧИЕ";
			Skill3Text.text = "ПОВЫШАЕТ СИЛУ";
			Skill4Text.text = "ПОВЫШАЕТ УСТОЙЧИВОСТЬ";
			Skill5Text.text = "ПОВЫШАЕТ ВЛИЯНИЕ";
			Skill6Text.text = "ПОВЫШАЕТ НАСТОЙЧИВОСТЬ";
			Skill7Text.text = "ПОВЫШАЕТ УДАЧУ";
			DescSkillPanText.text = "НАВЫКИ";
			// ЭКИПИРОВКИ
			DescOutfitPanText.text = "ЭКИПИРОВКИ";
			// ВОЙСКА
			DescForcesPanText.text = "ВОЙСКА";
			WarningForcesText.text = "ДОСТУПНО ПРИ ДОСТИЖЕНИИ ЗВАНИЯ ГЕНЕРАЛА АРМИИ";
			DescProText.text = "В PRO ВЕРСИИ У ВАС ПОЯВИТСЯ ВОЗМОЖНОСТЬ СЛУЖИТЬ В ЛЮБЫХ ВОЙСКАХ БЕЗ ДОСТИЖЕНИЯ ЗВАНИЯ \"ГЕНЕРАЛ АРМИИ\". А ТАК ЖЕ СТАРТОВЫЙ БОНУС. КУПИ СЕЙЧАС!";
			NameNavyText.text = "ВОЕННО-МОРСКОЙ ФЛОТ";				
			NamePoliceText.text = "ПОЛИЦЕЙСКИЙ ДЕПАРТАМЕНТ"; 
			NameFBIText.text = "ФЕДЕРАЛЬНОЕ БЮРО (ФБР)"; 
			NameSPYText.text = "ШПИОНАЖ";
			NameSpaceText.text = "ВОЗДУШНО-КОСМИЧЕСКИЕ СИЛЫ"; 
			NameArmyText.text = "АРМИЯ"; 
			NameVDVText.text = "ВОЗДУШНО-ДЕСАНТНЫЕ ВОЙСКА"; 
			NameRHBZText.text = "ВОЙСКА РХБ ЗАЩИТЫ";
			MoreForcesText.text = "\nСЕЙЧАС МЫ РАБОТАЕМ НАД НОВЫМИ ВОЙСКАМИ, КОТОРЫЕ ПОЗВОЛЯТ СДЕЛАТЬ СЛУЖБУ БОЛЕЕ ИНТЕРЕСНОЙ И ПОЛУЧАТЬ БОЛЬШЕ ПРИВИЛЕГИЙ." +
				"\n\nПРЕДЛАГАЙТЕ, КАКИЕ ВОЙСКА ВЫ ХОТЕЛИ БЫ ВИДЕТЬ. МЫ УЧТЁМ ВАШИ ПОЖЕЛАНИЯ.\n\nПРИЯТНОЙ ИГРЫ!";
			// ЭМБЛЕМЫ
			DescEmblemsText.text = "ЭМБЛЕМЫ";
			// ПАСПОРТ
			YearsText.text = "ВЫСЛУГА ЛЕТ:";
			NumServeText.text = "СКОЛЬКО РАЗ ОТСЛУЖИЛ:"; 
			TicketText.text = "ВОЕННЫЙ БИЛЕТ?:";
			CadetSchool.text = "КАДЕТСКАЯ ШКОЛА ПРОЙДЕНА?"; 
			TotalWage.text = "ОБЩАЯ ЗАРПЛАТА:"; 
			NumWinBosses.text = "БОССОВ ПОБЕЖДЕНО:";
			NumWinCourtsText.text = "ВЫИГРАНО СУДЕБНЫХ ДЕЛ:";
			// ДОНАТ
			DescDonatPanText.text = "БОНУСЫ";
			Desc30rub.text = "ВОЗМОЖНОСТЬ 1 РАЗ СМЕНИТЬ ВОЙСКА БЕЗ ДОСТИЖЕНИЯ МАКСИМАЛЬНОГО ЗВАНИЯ"; 
			BuyNow30.text = "НАЧАЛЬНЫЙ БОНУС"; 
			Desc60rub.text = "+ PRO ВЕРСИЯ ИГРЫ С ВОЗМОЖНОСТЬЮ МЕНЯТЬ ВОЙСКА БЕЗ ДОСТИЖЕНИЯ МАКСИМАЛЬНОГО ЗВАНИЯ"; 
			BuyNow60.text = "ВЫГОДНО"; 
			Desc99rub.text = "+ PRO ВЕРСИЯ ИГРЫ С ВОЗМОЖНОСТЬЮ МЕНЯТЬ ВОЙСКА БЕЗ ДОСТИЖЕНИЯ МАКСИМАЛЬНОГО ЗВАНИЯ"; 
			BuyNow99.text = "ЭЛИТА ВОЙСК"; 
			Bonus99rub.text = "БОНУС = 1000 КЛИКОВ ВМЕСТО 500";
			Desc159rub.text = "+ PRO ВЕРСИЯ ИГРЫ С ВОЗМОЖНОСТЬЮ МЕНЯТЬ ВОЙСКА БЕЗ ДОСТИЖЕНИЯ МАКСИМАЛЬНОГО ЗВАНИЯ"; 
			BuyNow159.text = "НАБОР ИЗБРАННИКА"; 
			Bonus159rub.text = "БОНУС = 2000 КЛИКОВ ВМЕСТО 500";
			Desc590rub.text = "+ PRO ВЕРСИЯ ИГРЫ С ВОЗМОЖНОСТЬЮ МЕНЯТЬ ВОЙСКА БЕЗ ДОСТИЖЕНИЯ МАКСИМАЛЬНОГО ЗВАНИЯ";
			BuyNow590.text = "ЛЕГЕНДАРНЫЙ НАБОР";
			Bonus590rub.text = "БОНУС = 4000 КЛИКОВ ВМЕСТО 500";
			// "КУПИ СЕЙЧАС"
			DescBuyNow.text = "СОВЕРШИ ПОКУПКУ И ПОЛУЧИ ВОЗМОЖНОСТЬ СЛУЖИТЬ В ЛЮБЫХ ВОЙСКАХ БЕЗ ДОСТИЖЕНИЯ ЗВАНИЯ \"ГЕНЕРАЛ АРМИИ\".\nА ТАК ЖЕ БОНУСЫ"; 
			DescBuyNowPan.text = "ПРЕДЛОЖЕНИЕ"; 
			OkText.text = "ОТЛИЧНО";
			// БОССЫ
			StrengthTextLoc.text = "СИЛА УДАРА"; 
			OnetoStrengthText.text = "+1 К СИЛЕ УДАРА";
			NameBoss1Text.text = " СКИНХЕД";
			ChanceBoss1Text.text= "ЕСТЬ ШАНС ВЫБИТЬ КОСТЮМ";
			NameBoss2Text.text = " МАФИОЗИ";
			ChanceBoss2Text.text= "ЕСТЬ ШАНС ВЫБИТЬ КОСТЮМ";
			NameBoss3Text.text= " ЗЛОЙ КАСПЕР";
			ChanceBoss3Text.text= "ЕСТЬ ШАНС ВЫБИТЬ КОСТЮМ";
			NameBoss4Text.text = " ЗОМБЕРМЭН"; 
			ChanceBoss4Text.text = "ЕСТЬ ШАНС ВЫБИТЬ КОСТЮМ"; 
			NameBoss5Text.text = " ДОКТОР \"ЭЛ\""; 
			ChanceBoss5Text.text = "ЕСТЬ ШАНС ВЫБИТЬ КОСТЮМ"; 
			FightText.text = "БЕЙ!"; 
			TimerFightText.text = Bosses.Timer + " СЕК";
			WinText.text = "ВЫ ПОБЕДИЛИ БОССА!"; 
			CongratulationText.text = "ПОЗДРАВЛЯЕМ!\n\nБОСС ПОБЕЖДЁН! ВЫ МОЖЕТЕ НАПАДАТЬ НА НЕГО ПОВТОРНО, НО В СЛЕДУЮЩИЙ РАЗ ПРИЗ БУДЕТ МЕНЬШЕ! "; 
			YourPrizeText.text = "ВЫ ВЫИГРАЛИ..."; 
			OkkText.text = "ОТЛИЧНО"; 
			BlockBossText.text = "БОССЫ НЕДОСТУПНЫ"; 
			RequerForBossText.text= "ТРЕБУЕТСЯ ВЫСЛУГА: 5 ЛЕТ";
			// ЭКИПИРОВКИ
			CostOutfit13.text = "ПОЛУЧИ АДМИРАЛА ФЛОТА"; 
			CostOutfit14.text = "ПОЛУЧИ ГЕНЕРАЛА ПОЛИЦИИ"; 
			CostOutfit16.text = "ПОЛУЧИ ГЕНЕРАЛА В ВОЙСКАХ ВДВ";
			CostOutfit19.text = "ПОЛУЧИ ГЕНЕРАЛА В ВОЙСКАХ РХБЗ"; 
			CostOutfit22.text = "МОЖЕТ ВЫПАСТЬ С \"СКИНХЕД\"";
			CostOutfit23.text = "МОЖЕТ ВЫПАСТЬ С \"МАФИОЗИ\"";
			CostOutfit24.text = "МОЖЕТ ВЫПАСТЬ С \"ЗЛОЙ КАСПЕР\"";
			CostOutfit25.text = "МОЖЕТ ВЫПАСТЬ С \"ЗОМБЕРМЭН\""; 
			CostOutfit26.text = "МОЖЕТ ВЫПАСТЬ С \"ДОКТОР \"ЭЛ\"\"";
			// ИНФОРМАЦИЯ (FAQ)
			FaqMoneyText.text = "- ОСНОВНАЯ ВАЛЮТА В ИГРЕ. ЗА НЕЁ МОЖНО УЛУЧШАТЬ НАВЫКИ, ПАРТНЁРОВ, ПОВЫШАТЬ АВТОРИТЕТ И ЗАРАБОТОК.";
			FaqAuthorityText.text = "- АВТОРИТЕТ. ОЧКИ АВТОРИТЕРА ПОВЫШАЮТ ТВОЙ УРОВЕНЬ АВТОРИТЕТА. С КАЖДЫМ УРОВНЕМ АВТОРИТЕТА ДОП.ЗАРАБОТОК ПОВЫШАЕТСЯ."; 
			FaqGoldText.text = "- ЗОЛОТО. ПОЗВОЛЯЕТ ПОКУПАТЬ ОСОБЫЕ УЛУЧШЕНИЯ, НАВЫКИ, А ТАК ЖЕ СТРЕМИТЕЛЬНО РАЗВИВАТЬСЯ В СФЕРЕ СУДЕБНЫХ ПРИСТАВОВ.";
			FaqScrollText.text = "- СВИТКИ. ОТКРЫВАЮТ ДОПОЛНИТЕЛЬНЫЕ ВОЗМОЖНОСТИ И ПРИВИЛЕГИИ ИГРЕ. КОЛИЧЕСТВО СВИТКОВ УКАЗЫВАЕТ НА УРОВЕНЬ ТВОЕЙ ЭЛИТНОСТИ.";
			WarningFaqText.text = "ПРЕДУПРЕЖДЕНИЕ: ВСЕ ПОГОНЫ НЕ ЯВЛЯЮТСЯ РЕАЛЬНЫМ ПРОЕЦИРОВАНИЕМ. БОЛЬШИНСТВО ПОГОН СИЛЬНО ИЛИ ЧАСТИЧНО СХОЖИ С НАСТОЯЩИМИ, ОДНАКО ЛЮБЫЕ НЕТОЧНОСТИ НЕ ЯВЛЯЮТСЯ ОШИБКОЙ. НЕКОТОРЫЕ ПОГОНЫ - ВЫМЫСЕЛ, В ЦЕЛЯХ РАЗНООБРАЗИЯ ИГРОВОГО ПРОЦЕССА.";
			// СТАТУС
			FaqStatusText.text = "СТАТУС УКАЗЫВАЕТ НА ТВОЙ ПРЕСТИЖ ПО ЗАРАБОТКУ. ЧЕМ БОЛЬШЕ ДЕНЕГ ТЫ ЗАРАБОТАЛ - ТЕМ ВЫШЕ СТАТУС. КАЖДЫЙ СТАТУС ДАЁТ СВОИ ДОПОЛНИТЕЛЬНЫЕ БОНУСЫ.";

		}

		if (Game.idLanguage == 2) {
			// ПАНЕЛЬ КЛИКОВ
			NeedEmblemText.text = "NEED EMBLEM";
			CaptionOutfit.text = "OUTFIT";
			CaptionEmblems.text = "EMBLEM";
			CaptionPatner.text = "PARTNERS";
			bonusForRate.text = "+3 TO CLICK";
			//accessEmblems.text = "AVAILABLE FROM 12 RANK";
			accessPartner.text = "AVAILABLE FROM 8 RANK";
			// ИНФОРМАЦИЯ
			DescInfoPanText.text = "INFORMATION";
			// КАДЕТ
			DescCadet.text = "SCHOOL OF THE COURSANT";
			StartText.text = "START";
			Desc1.text = "PASS THE SCHOOL OF A COURSANT TO GET A HIGHER DEGREE OF QUALIFICATION AND INCREASE YOUR EARNINGS 2 TIMES!";
			WarningCadet.text = "FOR TRAINING, ANY EMBLEM IS REQUIRED!"; 
			CancelText.text = "CANCEL";
			WarningCancelText.text = "AT ANY MOMENT, YOU MAY BE CANCELED TRAINING, BUT THE NEXT TIME WILL COME TO START EVERYTHING AT FIRST";
			Desc2.text = "YOU TRAIN!"; 
			ProgressText.text = "YOUR PROGRESS"; 
			EndCadetText.text = "YOU SUCCESSFULLY COMPLETE THE CADET SCHOOL AND GOT QUALIFICATIONS. YOUR SALARY IS INCREASED 2 TIMES. \n\nCONGRATULATIONS!";
			// МЕДАЛИ
			DescMedalsPan.text = "BONUS MEDALS";
			x2Text.text = "x2 FOREVER"; 
			x3Text.text = "x3 FOREVER"; 
			x4Text.text = "x4 FOREVER"; 
			x5Text.text = "x5 FOREVER"; 
			x10Text.text = "x10 FOREVER";
			// НАВЫКИ
			Skill1Text.text = "INCREASES AGGRESSION"; 
			Skill2Text.text = "INCREASES REDNESS";
			Skill3Text.text = "INCREASES STRENGTH";
			Skill4Text.text = "INCREASES STABILITY";
			Skill5Text.text = "INCREASES INFLUENCE";
			Skill6Text.text = "INCREASES RESISTANCE";
			Skill7Text.text = "INCREASES LUCK";
			DescSkillPanText.text = "SKILLS";
			// ЭКИПИРОВКИ
			DescOutfitPanText.text = "OUTFITS";
			// ВОЙСКА
			DescForcesPanText.text = "FORCES";
			WarningForcesText.text = "AVAILABLE WHEN ACHIEVING THE TITLE OF THE ARMY GENERAL";
			DescProText.text = "IN THE PRO VERSION, YOU WILL HAVE AN OPPORTUNITY TO SERVE IN ANY FORCES WITHOUT ACHIEVING THE TITLE \"GENERAL OF THE ARMY \". ALSO START BONUS. BUY NOW!";
			NameNavyText.text = "NAVY";				
			NamePoliceText.text = "POLICE DEPARTMENT"; 
			NameFBIText.text = "FEDERAL BUREAU OF INVESTIGATION\n"; 
			NameSPYText.text = "SPY";
			NameSpaceText.text = "AIR-SPACE FORCES"; 
			NameArmyText.text = "ARMY"; 
			NameVDVText.text = "AIR-PARATROOPER TROOPS"; 
			NameRHBZText.text = "CHEMICAL RADIATION PROTECTION";
			MoreForcesText.text = "\nSUGGEST WHAT TROOPS YOU WOULD LIKE TO SEE. WE WILL TAKE INTO ACCOUNT YOUR WISHES.\n\nHAVE A NICE GAME!\n";
			// ЭМБЛЕМЫ
			DescEmblemsText.text = "EMBLEMS";
			// ПАСПОРТ
			YearsText.text = "SERVICE YEARS:";
			NumServeText.text = "HOW MANY TIME I SERVED:"; 
			TicketText.text = "MILITATY TICKET?:";
			CadetSchool.text = "COURSANTS SCHOOL PASSED?"; 
			TotalWage.text = "YOUR TOTAL WAGE:"; 
			NumWinBosses.text = "HOW MANY TIMES WON THE BOSSES:";
			NumWinCourtsText.text = "HOW MANY TRIAL HAVE BEEN WON:";
			// ДОНАТ
			DescDonatPanText.text = "BONUSES";
			Desc30rub.text = "OPPORTUNITY 1 TIME TO CHANGE A FORCES WITHOUT ACHIEVING THE MAXIMUM RANK"; 
			BuyNow30.text = "INITIAL BONUS"; 
			Desc60rub.text = "+ PRO VERSION OF THE GAME YOU HAVE OPPORTUNITY TO CHANGE A FORCE WITHOUT ACHIEVING THE MAXIMUM RANK"; 
			BuyNow60.text = "PROFITABLE"; 
			Desc99rub.text = "+ PRO VERSION OF THE GAME YOU HAVE OPPORTUNITY TO CHANGE A FORCE WITHOUT ACHIEVING THE MAXIMUM RANK"; 
			BuyNow99.text = "ELITE TROOPS"; 
			Bonus99rub.text = "BONUS = 1000 CLICKS INSTEAD 500";
			Desc159rub.text = "+ PRO VERSION OF THE GAME YOU HAVE OPPORTUNITY TO CHANGE A FORCE WITHOUT ACHIEVING THE MAXIMUM RANK"; 
			BuyNow159.text = "FAVORITE SET"; 
			Bonus159rub.text = "BONUS = 2000 CLICKS INSTEAD 500";
			Desc590rub.text = "+ PRO VERSION OF THE GAME YOU HAVE OPPORTUNITY TO CHANGE A FORCE WITHOUT ACHIEVING THE MAXIMUM RANK";
			BuyNow590.text = "LEGENDARY SET";
			Bonus590rub.text = "BONUS = 4000 CLICKS INSTEAD 500";
			// "КУПИ СЕЙЧАС"
			DescBuyNow.text = "COMPLETE A PURCHASE AND GET THE OPPORTUNITY TO SERVE IN ANY FORCES WITHOUT ACHIEVEMENT OF THE TITLE \"GENERAL OF THE ARMY \". ALSO BONUSES"; 
			DescBuyNowPan.text = "SENTENCE"; 
			OkText.text = "FINE";
			// БОССЫ
			StrengthTextLoc.text = "STRENGTH"; 
			OnetoStrengthText.text = "+1 TO STRENGTH";
			NameBoss1Text.text = " SKINHEAD";
			ChanceBoss1Text.text= "THERE A CHANCE TO GET THE OUTFIT";
			NameBoss2Text.text = " MAFIA";
			ChanceBoss2Text.text= "THERE A CHANCE TO GET THE OUTFIT";
			NameBoss3Text.text= " EVIL CASPER";
			ChanceBoss3Text.text= "THERE A CHANCE TO GET THE OUTFIT";
			NameBoss4Text.text = " ZOMBERMAN"; 
			ChanceBoss4Text.text = "THERE A CHANCE TO GET THE OUTFIT"; 
			NameBoss5Text.text = " ДОКТОР \"EL\""; 
			ChanceBoss5Text.text = "THERE A CHANCE TO GET THE OUTFIT"; 
			FightText.text = "PUSH!"; 
			TimerFightText.text = Bosses.Timer + " SEC";
			WinText.text = "YOU WIN BOSS!"; 
			CongratulationText.text = "CONGRATULATIONS!\n\nBOSS WON! YOU CAN ATTACK ON IT AGAIN BUT NEXT TIME THE PRIZE WILL BE LESS! "; 
			YourPrizeText.text = "YOUR PRIZE..."; 
			OkkText.text = "OKAY"; 
			BlockBossText.text = "BOSSES BLOCKET"; 
			RequerForBossText.text= "REQUIREMENTS SERVICE YEARS: 5";
			// ЭКИПИРОВКИ
			CostOutfit13.text = "GET TO THE FLEET ADMIRAL"; 
			CostOutfit14.text = "GET THE CHEFF POLICE"; 
			CostOutfit16.text = "GET TO THE GENERAL AIR-PARATROOPER TROOPS";
			CostOutfit19.text = "GET TO THE GENERAL CHEMICAL RADIATION PROTECTION"; 
			CostOutfit22.text = "YOU CAN GET FROM BOSS \"SKINHEAD\"";
			CostOutfit23.text = "YOU CAN GET FROM BOSS \"MAFIA\"";
			CostOutfit24.text = "YOU CAN GET FROM BOSS \"EVIL CASPER\"";
			CostOutfit25.text = "YOU CAN GET FROM BOSS \"ZOMBERMAN\""; 
			CostOutfit26.text = "YOU CAN GET FROM BOSS \"DOCTOR \"EL\"\"";
			// ИНФОРМАЦИЯ (FAQ)
			FaqMoneyText.text = "- BASIC CURRENCY IN THE GAME. IT CURRENCY GIVE IS POSSIBLE TO IMPROVE SKILLS, PARTNERS, INCREASE AUTHORITY AND EARNINGS MORE.";
			FaqAuthorityText.text = "- AUTHORITY. AUTHOR'S SCORE INCREASE YOUR AUTHORITY LEVEL. WITH EVERY LEVEL OF AUTHORITY, ADDITIONAL EARNINGS INCREASES.";
			FaqGoldText.text = "- GOLD. LETS TO BUY SPECIAL IMPROVEMENTS, SKILLS, AND ALSO ASKINGLY DEVELOP IN THE FIELD OF THE BAILIFFS.";
			FaqScrollText.text = "- SCROLLS. IT OPEN ADDITIONAL OPPORTUNITIES AND PRIVILEGES TO THE GAME. NUMBER OF SCROLLS INDICATES AT THE LEVEL OF YOUR ELITE.";
			WarningFaqText.text = "WARNING: ALL SHOULDER STRAPS ARE NOT A REAL PROJECTION. MOST OF THE CHASES ARE STRONG OR PARTIALLY SIMILAR TO THE PRESENT, BUT ANY INACCURACIES ARE NOT A MISTAKE. SOME POOR - FABRICATION, FOR THE DIVERSITY OF THE GAME PROCESS.";
			// СТАТУС
			FaqStatusText.text = "STATUS SHOW YOUR PRESTIGE FOR YOUR EARNINGS. IF YOU EARNED A LOT OF MONEY - YOUR STATUS WILL IMPROVE. EACH STATUS GIVES ITS ADDITIONAL BONUSES.";
		}
	}

	public void RU_Language() { // включает русский язык в игре
		Game.idLanguage = 1;
	}

	public void EN_Language() { // включает английский язык в игре
		Game.idLanguage = 2;
	}
}
