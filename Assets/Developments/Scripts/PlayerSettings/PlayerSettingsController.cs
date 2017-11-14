using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettingsController : MonoBehaviour {

	[SerializeField] Text inputFieldText;
	[SerializeField] GameObject playerSettings;

	public void onClick() {
		string name = inputFieldText.text;
		playerSettings.GetComponent<PlayerManager> ().setPlayer (name);
		Invoke ("clearInputFieldText", 0.1f);
	}

	public void clearInputFieldText() {
		inputFieldText.text = "";
	}


}
