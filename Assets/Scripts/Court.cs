using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Court : MonoBehaviour
{
    public static int yesCourt = 0; // открыт ли суд (1 - да, 0 - нет)
    public static int numInvestigation = 1; // номер дела
    public static int chanceWinInvestigation = 10; // шанс выиграть дело (изначально 10 процентов)
    public static int timeCourt = -1; // время суда (суд будет идти 2 минуты)
    public static int maxTimeCourt = 120;
    public static int winScroll = 0;
    public static int winGold = 0;
    public static int xPrize = 1; // множитель призов
    public static int compensationScroll = 0;
    public static int costUpdCourt1 = 10;
    public static int costUpdCourt2 = 20;
    public static int costUpdCourt3 = 100;
    public static int WinCourt = 0; // выигран ли суд (0 - выключено, 1 - нет, 2 - да)
    public static int autoCourt = 0; // автоматически забирает приз суда и начинает новый (0 - нет, 1 - да)
    public static int countWinCourt = 0; // счётчик, сколько судебных дел выиграно
    

    public static int randInvest = 0; // номер дела для описания (рандом)

    public Slider ProcessCourtSlider; // слайдер процесса суда


    public GameObject iconFinishCourt; // иконка появляется, когда суд завершён. Типа уведомление, ёпт
    public GameObject BlockCourt; // панель блокирования суда, если он не куплен
    public GameObject ProcessCourtSliderObj; // объект слайдера, чтоб его выключать в нужный момент
    public GameObject StartCourtBttn; // кнопка "Начать суд"
    public GameObject timeCourtTextObj, chanceWinInvestigationTextObj; // объеты текста, которые будут выключаться
    public GameObject PrizePan; // панель приза, вызывается в случае победыыыыыы!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public GameObject LosePan; // панель компенсации, в случае поражения суда......... =((((
    public GameObject AutoCourtBttn; 

    public Text NumInvestigationText, DescrInvestigationText;
    public Text timeCourtText, chanceWinInvestigationText;
    public Text WinSrollText, WinGoldText, CompensationScrollText;
    public Text CostUpdCourt1Text, CostUpdCourt2Text, CostUpdCourt3Text;

    public static string[] DescrInvestigation = { "Джон Рейк, 31 год. Поздно вечером подкараулил девушку возле подъезда. Угражая расправой, он ограбил бедную девушку, разбил её телефон, дабы ограничить в своевременной связи с органами, и скрылся из виду. Девушка запомнила его лицо и составила фоторобот.", 
        "Дебора Ли-Харли, 28 лет. Обвинила своего мужа, Джона Ли-Харли в насилии женщин, которых он заманивал в свой офис под видом индивидуального предпринимателя, с возможностью найти лёгкую высокооплачиваемую работу. Доказательства она нашла в его телефоне и соц.сети.",
    "Конан Дрейк, 46 лет. Профессиональный аферист. Созваниваясь со своими жертвами, навязывает им полезные услуги очень популярной компанией *название скрыто*. Преступнк владеет убеждением и находит слабые точки жертвы. По подсчётам, обманывает людей на 30.000-20.000 рублей. Доказательства имеются в виде записей телефонных разговоров.",
    "Оливия Трелони, 30 лет. Вместе со своими братьями Джейком Трелони и Куртом Трелони ограбили 3 локальных магазина техники. Преступники надевали маски, и вооружившись, нападали на граждан и кассиров. По предворительным данным пострадало более 30 человек, а сумма награбленного составляет боле 18.000.000 рублей.",
    "Артур Маквин, 38 лет. Напал на молодую девушку в ночь на 28 октября. Со слов свидетелей: девушка возвращалась домой после ночной смены, к ней подошёл мужчина средних лет, что-то сказал, достал огромный тупой предмет и напал на девушку, после чего скрылся.",
    "Антон Переломный, 35 лет. Вместе со своим напарником ограбил дом индивидуального предпринимателя ООО *скрыто*, побил все стёкла в доме и устроил дебош у соседей, которые включили свет на крики. Смертей нет, но 4 человека тяжело ранены. Напарника выявить не удалось.",
    "Ирина Долговязова, 28 лет. Разгром. Подробнее: в ночь на 5 сентября молодая девушка напросилась в гости к своей подруге, ударила по голове, и разгромила всю квартиру. По словам подруги она поссорилась с ней из-за парня. Из имущества так же был разбит автомобиль и дорогостоящая техника.",
    "Иван Добров, 21 год. Грабил пожилых женщин на протяжении двух лет. Молодой преступник очень тщательно скрывался и заметал следы, но вскоре сам попался в руки полиции. Очередным вечером он напал на подполковника Ирину Шейкову, которая обезвредила его и отвезла в участок. Парню грозит до 18 лет лишения свободы.",
    "Дрейк Бонджи, 30 лет. Угон автомобилей. Сведения: Мужчина бил стёкла иномарок и угонял их. По словам преступника, он их перепродавал, чтоб заработать денег, так как на нём висят огромные долги, которые он не в состоянии погасить. Сумма угнанного составляет более 50 млн.",
    "Линдия Макензи, 54 года. За ней числится минимум 5 убийств. По последним данным женщина ограбила своего брата, после чего инсценировала его самоубийство. Данные были взяты расспросом соседей, которые, по их словам, всё видели, и на которых она так же напала, но не смогла догнать в связи с алкогольным опьянением."}; // 10
    void Start()
    {
        StartCoroutine(GoCourt());
    }

    void Update()
    {
        if (yesCourt == 0)
        {
            BlockCourt.SetActive(true);
            ProcessCourtSliderObj.SetActive(false);
            iconFinishCourt.SetActive(false);
        }
        if (yesCourt == 1)
        {
            BlockCourt.SetActive(false);
            NumInvestigationText.text = "ДЕЛО №" + numInvestigation;
            DescrInvestigationText.text = "" + DescrInvestigation[randInvest];
            chanceWinInvestigationText.text = "УСПЕШНОСТЬ: " + chanceWinInvestigation + "%";
            timeCourtText.text = "ДО ОКОНЧАНИЯ СУДА: " + timeCourt + " СЕК";
            ProcessCourtSlider.maxValue = maxTimeCourt;
            ProcessCourtSlider.value = timeCourt;
            CostUpdCourt1Text.text = costUpdCourt1 + "   ";
            CostUpdCourt2Text.text = costUpdCourt2 + "    ";
            CostUpdCourt3Text.text = costUpdCourt3 + "    ";
        }

        if (autoCourt == 0)
            AutoCourtBttn.SetActive(true);
        if (autoCourt == 1)
            AutoCourtBttn.SetActive(false);
    }

    public void BuyCourt()
    {
        if (Game.gold >= 100)
        {
            Game.gold -= 100;
            yesCourt = 1;
            StartCourtBttn.SetActive(true);
            timeCourtTextObj.SetActive(false);
            if (Advertisement.IsReady())
            {
                ShowOptions option = new ShowOptions();
                Advertisement.Show("rewardedVideo", option);
            }
        }
    }

    public void StartCourt()
    {
        timeCourt = maxTimeCourt;
        ProcessCourtSliderObj.SetActive(true);
        StartCourtBttn.SetActive(false);
        timeCourtTextObj.SetActive(true);
        iconFinishCourt.SetActive(false);
    }

    public void FinishCourt() // вызывается автоматически, когда заканчивается суд
    {
        int rand = Random.Range(0, 100);
        iconFinishCourt.SetActive(true);
        if (rand <= chanceWinInvestigation) // победа
        {
            PrizePan.SetActive(true);
            WinCourt = 2;
            int randWinSroll = Random.Range(20, 31);
            winScroll = (randWinSroll * xPrize);
            WinSrollText.text = "+" + winScroll;
            int randWinGold = Random.Range(1, 4);
            winGold = (randWinGold * xPrize);
            WinGoldText.text = "+" + winGold;
            countWinCourt += 1;

        }
        else // поражение
        {
            LosePan.SetActive(true);
            WinCourt = 1;
            int randCompensationScroll = Random.Range(1, 5);
            compensationScroll = (randCompensationScroll * xPrize);
            CompensationScrollText.text = "+" + compensationScroll;

        }
        ProcessCourtSliderObj.SetActive(false);
        timeCourt = -1;
        timeCourtTextObj.SetActive(false);
        chanceWinInvestigationTextObj.SetActive(false);
        if (autoCourt == 1)
        {
            GoAutoCourt();
        }
        else { }
    }

    public void GetPrize() // взять приз
    {
        PrizePan.SetActive(false);
        chanceWinInvestigationTextObj.SetActive(true);
        Game.scroll += winScroll;
        Game.gold += winGold;
        winScroll = 0;
        winGold = 0;
        numInvestigation += 1;
        randInvest = Random.Range(0, 10);
        StartCourtBttn.SetActive(true);
        iconFinishCourt.SetActive(false);
        WinCourt = 0;
    }

    public void GetCompensation() // взять компенсацию (в случае поражения суда)
    {
        LosePan.SetActive(false);
        chanceWinInvestigationTextObj.SetActive(true);
        Game.scroll += compensationScroll;
        compensationScroll = 0;
        numInvestigation += 1;
        randInvest = Random.Range(0, 10);
        StartCourtBttn.SetActive(true);
        iconFinishCourt.SetActive(false);
        WinCourt = 0;
    }

    public void updCourt1() // улучшить вероятность успешного суда
    {
        if (Game.gold >= costUpdCourt1 && chanceWinInvestigation < 100)
        {
            Game.gold -= costUpdCourt1;
            chanceWinInvestigation += 5;
            costUpdCourt1 += 5;
        }
    }

    public void updCourt2()
    {
        if (Game.gold >= costUpdCourt2 && maxTimeCourt > 10)
        {
            Game.gold -= costUpdCourt2;
            maxTimeCourt -= 10;
            timeCourt -= 10;
            costUpdCourt2 += 15;
        }
    }

    public void updCourt3()
    {
        if (Game.gold >= costUpdCourt3)
        {
            Game.gold -= costUpdCourt3;
            xPrize += 1;
            costUpdCourt3 += 100;
        }
    }

    public void GoAutoCourt()
    {
        if (WinCourt == 2)
        {
            GetPrize();
        }
        if (WinCourt == 1)
        {
            GetCompensation();
        }
        StartCourt();
    }

    public IEnumerator GoCourt()
    {
        while (true)
        {
            if (timeCourt > 0)
            {
                timeCourt -= 1;
            }
            if (timeCourt == 0)
            {
                FinishCourt();
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
