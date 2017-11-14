using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinionPanelController : MonoBehaviour {

	[SerializeField] Text friend1;
	[SerializeField] Text friend2;
	[SerializeField] Text friend3;
	[SerializeField] Text friend4;
	[SerializeField] PlayerManager playerManager;

	void Start() {
		int i = 0;
		List<Player> players = playerManager.getPlayers ();
		foreach (Player p in players) {
			if ((p.role == 0 || p.role == 2) && i == 0) {
				friend1.text = p.name; 
				i++;
			} else if ((p.role == 0 || p.role == 2) && i == 1) {
				friend2.text = p.name; 
				i++;
			} else if ((p.role == 0 || p.role == 2) && i == 2) {
				friend3.text = p.name; 
				i++;
			} else if ((p.role == 0 || p.role == 2) && i == 3) {
				friend4.text = p.name; 
				i++;
			} 
		}
	}
}
