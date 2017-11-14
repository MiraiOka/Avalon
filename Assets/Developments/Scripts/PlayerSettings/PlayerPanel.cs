using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour {

	[SerializeField] Text nameLabel;

	public void setValue(Player player) {
		nameLabel.text = player.name;
	}
}
