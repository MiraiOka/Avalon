using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour {
	[SerializeField] GameObject identificationPanel;

	public void onClick() {
		identificationPanel.SetActive (false);
	}

}
