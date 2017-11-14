using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestController : MonoBehaviour {

	[SerializeField] Text nameLabel;

	List <Player> players;
	[SerializeField] PlayerManager playerManager;
	[SerializeField] VoteQuest1Controller vq1;
	[SerializeField] SuccessButtonController s;
	[SerializeField] FaiureButtonController f;

	public int i = 0;
	public void setLabel(){
		players = playerManager.getPlayers ();
		nameLabel.text = players [vq1.selectMember [i].value].name + "さん";
		i++;
	}

	public void clear() {
		i = 0;
		s.clearSuccess ();
		f.clearFaiure ();
	}
}
