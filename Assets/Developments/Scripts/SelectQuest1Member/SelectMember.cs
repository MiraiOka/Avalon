using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectMember : MonoBehaviour {
	[SerializeField] Camera mainCamera;
	[SerializeField] GameObject[] selectMember;
	[SerializeField] Text selectNumber;
	List<Player> players;
	[SerializeField] PlayerManager playerManager;
	[SerializeField] Text timeLabel;
	[SerializeField] Text questTimeLabel;

	public static int i;
	bool isFirst = true;
	public int questTime = 1;
	public int memberCount;
	public int time = 1;


	public void selectMembers() {
		players = playerManager.getPlayers ();
		mainCamera.transform.position = new Vector3 (2400, 0, -820);
		if (isFirst) {
			i = Random.Range (0, players.Count);
			isFirst = false;
		} else {
			if (i == players.Count-1) i = 0;
			else i++;
		}

		switch (questTime) {
		case 1:
			if (players.Count < 8) {
				memberCount = 2;	
			} else {
				memberCount = 3;
			}
			break;
		case 2:
			if (players.Count < 8) {
				memberCount = 3;	
			} else {
				memberCount = 4;
			}
			break;
		case 3:
			if (players.Count == 5) {
				memberCount = 2;	
			} else if (players.Count == 7) {
				memberCount = 3;
			} else {
				memberCount = 4;
			}
			break;
		case 4:
			if (players.Count < 7) {
				memberCount = 3;	
			} else if (players.Count == 7) {
				memberCount = 4;
			} else {
				memberCount = 5;
			}
			break;
		case 5:
			if (players.Count == 5) {
				memberCount = 3;	
			} else if (players.Count < 8) {
				memberCount = 4;
			} else {
				memberCount = 5;
			}
			break;
		}

		questTimeLabel.text = "第" + questTime + "クエスト";
		selectNumber.text = players[i].name + "さん、第" + questTime + "クエストに連れて行く" + memberCount + "人を選んでください。";
		timeLabel.text = time + "回目";
		time++;
		for (int j = 0; j < memberCount; j++) {
			selectMember [j].SetActive (true);
		}
	}

	public void minusTime() {
		time--;
	}

	public void clearSelectMember() {
		foreach (GameObject sm in selectMember) {
			sm.SetActive (false);
		}
	}
}
