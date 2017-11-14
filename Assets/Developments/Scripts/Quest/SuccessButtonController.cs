using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessButtonController : MonoBehaviour {

	public static int success = 0;
	[SerializeField] QuestController questController;
	[SerializeField] SelectMember selectMember;
	[SerializeField] Camera mainCamera;
	[SerializeField] QuestResultController questResult;

	public void onClick() {
		success++;
		if (questController.i == selectMember.memberCount) {
			mainCamera.transform.position += new Vector3 (600, 0, 0);
			questResult.setLabel ();
		} else {
			questController.setLabel ();
		}
	}

	public void clearSuccess() {
		success = 0;
	}
}