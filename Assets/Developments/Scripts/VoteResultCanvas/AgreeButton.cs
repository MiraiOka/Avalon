using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgreeButton : MonoBehaviour {
	[SerializeField] Text agreeName;
	[SerializeField] Text agreeCountLabel;
	[SerializeField] Text disagreeCountLabel;
	[SerializeField] VoteQuest1Controller vq1;
	[SerializeField] Camera mainCamera;
	[SerializeField] PlayerManager playerManager;

	public void onClick() {
		List<Player> players = playerManager.getPlayers();
		VoteQuest1Controller.agree++;
		agreeName.text += players[VoteQuest1Controller.i].name + " ";
		VoteQuest1Controller.i++;

		if (VoteQuest1Controller.i == PlayerManager.COUNT) {
			mainCamera.transform.position += new Vector3 (600, 0, 0);
			agreeCountLabel.text = "賛成：" + VoteQuest1Controller.agree;
			disagreeCountLabel.text = "反対：" + VoteQuest1Controller.disagree;
			VoteQuest1Controller.i = 0;
		} else {
			vq1.setLabel ();
		}

	}
}
