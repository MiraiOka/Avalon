using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

	[SerializeField] List<Player> players = new List<Player>();

	[SerializeField] GameObject playerPanel;
	[SerializeField] GameObject playerPanels;

	public static int modered = 1;
	public static int minion;
	public static int marlin = 1;
	public static int servant;
	public static int COUNT;

	Player player = new Player ();
	int playerCount = 0;

	public void setPlayer(string name) {
		var data = new Player ();
		data.setName (name);
		players.Add (data);
		playerCount++;
		setPlayerPanel ();
	}

	void setPlayerPanel() {
		deletePlayerPanel ();
		int i = 0, x = 260, y = -130;
		foreach (Player p in players) {
			GameObject obj = Instantiate (playerPanel);
			obj.transform.parent = playerPanels.transform;
			obj.transform.position = playerPanels.transform.position + new Vector3(260*(i%2), -130*(i/2), 0);
			var panel = obj.GetComponent<PlayerPanel> ();
			panel.setValue (p);
			i++;
		}
		COUNT = players.Count;
	}

	void deletePlayerPanel() {
		foreach ( Transform n in playerPanels.transform )
		{
			GameObject.Destroy(n.gameObject);
		}
	}

	public int getPlayerCount(){
		switch (playerCount) {
		case 5:
			minion = 1;
			servant = 2;
			break;
		case 6:
			minion = 1;
			servant = 3;
			break;
		case 7:
			minion = 2;
			servant = 3;
			break;
		case 8:
			minion = 2;
			servant = 4;
			break;
		case 9:
			minion = 2;
			servant = 5;
			break;
		case 10:
			minion = 3;
			servant = 5;
			break;
		}
		return playerCount;
	}

	public void setRole() {
		/*
		モードレッド → 0
		マーリン → 1
		モードレッドの手下 → 2
		アーサーの忠実なる家来 → 3
		*/
		for(int i = 0; i < players.Count; i++) {
			players [i].role = -1;
		}
		for(int i = 0; i < players.Count; i++) {
			players[i].role = Random.Range (0, players.Count);
			for (int j = 0; j < i; j++) {
				if (players [i].role == players [j].role) {
					i--;
					break;
				}
			}
		}
		foreach (Player p in players) {
			if (p.role >= 2 && p.role < 2 + minion) p.role = 2;
			else if (p.role >= 2 + minion && p.role < 2 + minion + servant) p.role = 3;
		}
	}

	public List<Player> getPlayers() {
		return players;
	}
}
