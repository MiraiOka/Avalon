using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPageController : MonoBehaviour {

	public void onClick() {
		this.transform.position += new Vector3 (600, 0, 0);
	}
}
