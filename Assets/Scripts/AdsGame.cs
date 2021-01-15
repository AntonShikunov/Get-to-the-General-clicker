using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class AdsGame : MonoBehaviour {


	void Update () {
		
	}

	public void goPresidentGame() {
		Application.OpenURL("market://details?id=com.shikunovsstudio.gettothepresident");
	}
}
