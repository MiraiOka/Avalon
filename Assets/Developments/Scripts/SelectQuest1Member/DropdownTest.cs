using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownTest : MonoBehaviour {
	[SerializeField] Dropdown dd;
	[SerializeField] PlayerManager playerManager;

	void Start() {
		List<Player> players = playerManager.getPlayers ();
		List<string> names = new List<string> ();

		foreach (Player p in players) names.Add (p.name);
		if (dd) {
			dd.ClearOptions ();
			dd.AddOptions (names);
		}
	}

}
