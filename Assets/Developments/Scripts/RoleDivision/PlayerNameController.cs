using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameController : MonoBehaviour {

	[SerializeField] PlayerManager playerManager;
	[SerializeField] Text playerNameLabel;
	[SerializeField] Text identificationLabel;
	[SerializeField] GameObject moderedPanel;
	[SerializeField] GameObject merlinPanel;
	[SerializeField] GameObject minionPanel;
	[SerializeField] GameObject servantPanel;
	[SerializeField] GameObject enterButton;
	[SerializeField] SelectMember selectMember;

	List<Player> players;
	int i = 0;

	public void checkRole() {
		players = playerManager.getPlayers();
		playerNameLabel.text = players[i].name;
		identificationLabel.text = players [i].name + "さんで間違いありませんか？";
	}

	public void setActiveRolePanel() {
		switch (players [i].role) {
		case 0:
			moderedPanel.SetActive (true);
			break;
		case 1:
			merlinPanel.SetActive (true);
			break;
		case 2:
			minionPanel.SetActive (true);
			break;
		case 3:
			servantPanel.SetActive (true);
			break;
		}
	}

	public void onNextClick() {
		i++;

		if (i < players.Count) {
			moderedPanel.SetActive (false);
			merlinPanel.SetActive (false);
			minionPanel.SetActive (false);
			servantPanel.SetActive (false);
			enterButton.SetActive (true);
			checkRole ();
		} else {
			selectMember.selectMembers ();
		}
	}
}
