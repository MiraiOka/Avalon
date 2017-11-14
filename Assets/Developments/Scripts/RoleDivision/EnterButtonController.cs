using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterButtonController : MonoBehaviour {

	[SerializeField] GameObject identificationPanel;

	public void onClick() {
		identificationPanel.SetActive (true);
	}

}
