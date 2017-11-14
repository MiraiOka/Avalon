using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VoteQuest1Controller : MonoBehaviour {

	[SerializeField] PlayerManager playerManager;

	[SerializeField] Text nameLabel;
	[SerializeField] Text memberLabel;
	[SerializeField] public Dropdown[] selectMember;
	[SerializeField] SelectMember sm;
	[SerializeField] Text agreeText;
	[SerializeField] Text disagreeText;
	[SerializeField] Camera mainCamera;
	[SerializeField] QuestController questController;
	[SerializeField] Text questTimeLabel;

	public static int agree = 0;
	public static int disagree = 0;
	public static int i = 0;

	List<Player> players;
	public void setLabel() {
		players = playerManager.getPlayers();
		nameLabel.text = players [i].name + "さん";
		memberLabel.text = players [selectMember [0].value].name;

		for (int j = 1; j < sm.memberCount; j++) {
			memberLabel.text += "\nと\n" + players [selectMember [j].value].name;
		}
		memberLabel.text += "\nでよろしいでしょうか？";

		questTimeLabel.text = "第" + sm.questTime + "クエスト"; 
	}

	public void gonogo() {
		if (agree > players.Count / 2 || sm.time == 6) {
			mainCamera.transform.position += new Vector3 (600, 0, 0);
			questController.setLabel ();
		} else {
			sm.selectMembers ();
			clearVote ();
		}
	}

	public void clearVote() {
		agree = 0;
		disagree = 0;
		agreeText.text = "";
		disagreeText.text = "";
	}
}
