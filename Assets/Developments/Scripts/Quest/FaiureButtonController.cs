using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaiureButtonController : MonoBehaviour {

	public static int faiure = 0;
	[SerializeField] QuestController questController;
	[SerializeField] SelectMember selectMember;
	[SerializeField] Camera mainCamera;
	[SerializeField] QuestResultController questResult;

	public void onClick() {
		faiure++;
		if (questController.i == selectMember.memberCount) {
			mainCamera.transform.position += new Vector3 (600, 0, 0);
			questResult.setLabel ();
		} else {
			questController.setLabel ();
		}
	}

	public void clearFaiure() { 
		faiure = 0;
	}
}
