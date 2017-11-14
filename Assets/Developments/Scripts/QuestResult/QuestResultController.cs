using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestResultController : MonoBehaviour {

	[SerializeField] Text successLabel;
	[SerializeField] Text failureLabel;
	[SerializeField] Image[] questImage;
	[SerializeField] SelectMember selectMember;
	[SerializeField] Camera mainCamera;
	[SerializeField] GameObject selectMerlin;

	int questSuccess = 0;
	int questFailure = 0;

	public void setLabel() {
		successLabel.text = "成功：" + SuccessButtonController.success;
		failureLabel.text = "失敗：" + FaiureButtonController.faiure;

		if (FaiureButtonController.faiure > 0) {
			questFailure++;
			questImage [selectMember.questTime - 1].color = Color.red;
			if (questFailure == 3) {
				mainCamera.transform.position += new Vector3 (600, 0, 0);
			}
		} else {
			questSuccess++;
			questImage [selectMember.questTime - 1].color = Color.blue;
			if (questSuccess == 3) {
				mainCamera.transform.position += new Vector3 (1200, 0, 0);
				selectMerlin.SetActive (true);
			}
		}
	}
}
