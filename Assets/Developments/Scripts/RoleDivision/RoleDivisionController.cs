using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleDivisionController : MonoBehaviour {

	[SerializeField] PlayerManager playerManager;

	public void divisionRole(int role) {
		playerManager.GetComponent<PlayerManager> ().setRole ();

	}
}
