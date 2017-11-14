using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DicisionButton : MonoBehaviour {

	[SerializeField] Dropdown selectMerlin;
	[SerializeField] Camera mainCamera;
	[SerializeField] PlayerManager playerManager;
	List<Player> players;

	public void onClick() {
		players = playerManager.getPlayers ();
		if (players [selectMerlin.value].role == 1) {
			mainCamera.transform.position -= new Vector3 (600, 0, 0);
		} else {
			mainCamera.transform.position += new Vector3 (600, 0, 0);
		}
	}
}
