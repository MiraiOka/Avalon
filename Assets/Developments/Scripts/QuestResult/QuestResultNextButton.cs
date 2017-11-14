using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestResultNextButton : MonoBehaviour {

	[SerializeField] Camera mainCamera;
	[SerializeField] SelectMember selectMember;
	[SerializeField] VoteQuest1Controller vq1;
	[SerializeField] QuestController questController;

	public void onClick() {
		mainCamera.transform.position = new Vector3 (2400, 0, -820);
		selectMember.questTime++;
		selectMember.minusTime ();
		selectMember.clearSelectMember ();
		selectMember.selectMembers ();
		vq1.clearVote ();
		questController.clear ();
	}
}
