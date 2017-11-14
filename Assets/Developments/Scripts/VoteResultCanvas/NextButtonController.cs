using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtonController : MonoBehaviour {
	[SerializeField] VoteQuest1Controller vq1;

	public void onClick() {
		vq1.gonogo ();
	}
}
