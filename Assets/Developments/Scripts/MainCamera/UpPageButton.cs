using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPageButton : MonoBehaviour {

	public void onClick() {
		this.transform.position += new Vector3 (0, 1000, 0);
	}
}
