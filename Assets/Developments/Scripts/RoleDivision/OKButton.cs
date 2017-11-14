using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OKButton : MonoBehaviour {

	[SerializeField] GameObject identificationPanel;
	[SerializeField] GameObject enterButton;
	[SerializeField] GameObject nextButton;
	[SerializeField] PlayerNameController pn;

	public void onClick() {
		identificationPanel.SetActive (false);
		enterButton.SetActive (false);
		nextButton.SetActive (true);
		pn.setActiveRolePanel ();
	}
}
