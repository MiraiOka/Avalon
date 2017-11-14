using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MerlinPanelController : MonoBehaviour {

	[SerializeField] Text evil1;
	[SerializeField] Text evil2;
	[SerializeField] Text evil3;
	[SerializeField] Text evil4;
	[SerializeField] PlayerManager playerManager;


	void Start() {
		int i = 0;
		List<Player> players = playerManager.getPlayers ();
		foreach (Player p in players) {
			if (p.role == 2 && i == 0) {
				evil1.text = p.name; 
				i++;
			} else if (p.role == 2 && i == 1) {
				evil2.text = p.name; 
				i++;
			} else if (p.role == 2 && i == 2) {
				evil3.text = p.name; 
				i++;
			} else if (p.role == 2 && i == 3) {
				evil4.text = p.name; 
				i++;
			} 
		}
	}
}
