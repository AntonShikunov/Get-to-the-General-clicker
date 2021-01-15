using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class Authority : MonoBehaviour {

	public static int authority = 0;
	public static int expAuthority = 0;
	public static int needExpAuthority = 50;
	public static int WageAuthority = 0;
	public static int WageForCadet = 1;

	public Slider AuthoritySlider;
	public Text WageAuthorityText;
	public Text LvlAuthorityText;

	void Update () {
		LvlAuthorityText.text = authority + "";
		if (Passport.CadetSchool == 0)
			WageForCadet = 1;
		if (Passport.CadetSchool == 1)
			WageForCadet = 2;
		if (Game.idLanguage == 1)
			WageAuthorityText.text = "ДОП.ПЛАТА: " + (WageAuthority * WageForCadet).ToString("N0");
		if (Game.idLanguage == 2)
			WageAuthorityText.text = "ADDITIONAL PAYMENT: " + (WageAuthority * WageForCadet).ToString("N0");
		AuthoritySlider.value = expAuthority;
		AuthoritySlider.maxValue = needExpAuthority;
		if (expAuthority >= needExpAuthority) {
			authority += 1;
			expAuthority = 0;
			int proc = ((needExpAuthority * 50) / 100);
			needExpAuthority += proc;
			WageAuthority += (authority * 3);
		}
		AuthoritySlider.value = expAuthority;
		AuthoritySlider.maxValue = needExpAuthority;
	}
}
