using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleCount : MonoBehaviour {

	[SerializeField] GameObject playerManager;
	[SerializeField] Text playerCountLabel;
	[SerializeField] Text minionCountLabel;
	[SerializeField] Text servantCountLabel;


	public void setRoleCount () {
		int playerCount = playerManager.GetComponent<PlayerManager> ().getPlayerCount();
		playerCountLabel.text = playerCount + "PLAYERS";
		minionCountLabel.text = "モードレッドの手下：" + PlayerManager.minion;
		servantCountLabel.text = "家来：" + PlayerManager.servant;
	}
}
