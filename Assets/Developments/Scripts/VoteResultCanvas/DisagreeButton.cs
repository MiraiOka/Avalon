using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisagreeButton : MonoBehaviour {

	[SerializeField] Text disagreeName;
	[SerializeField] Text agreeCountLabel;
	[SerializeField] Text disagreeCountLabel;
	[SerializeField] VoteQuest1Controller vq1;
	[SerializeField] Camera mainCamera;
	[SerializeField] PlayerManager playerManager;

	public void onClick() {
		List<Player> players = playerManager.getPlayers();
		disagreeName.text += players[VoteQuest1Controller.i].name + " ";
		VoteQuest1Controller.disagree++;
		VoteQuest1Controller.i++;

		if (VoteQuest1Controller.i == PlayerManager.COUNT) {
			mainCamera.transform.position += new Vector3 (600, 0, 0);
			print ("反対：" + VoteQuest1Controller.disagree);
			print ("賛成：" + VoteQuest1Controller.agree);
			agreeCountLabel.text = "賛成：" + VoteQuest1Controller.agree;
			disagreeCountLabel.text = "反対：" + VoteQuest1Controller.disagree;
			VoteQuest1Controller.i = 0;
		} else {
			vq1.setLabel ();
		}
	}
}
