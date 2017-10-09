using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour {

	public Transform currentBg;

	public void OnTriggerEnter (Collider other) {
		if (other.tag == "player") {
			//load 3rd Bg
			Transform firstBg = GameManager._instance.firstBg;
			//update currentBg's position after 3rd Bg
			currentBg.position = new Vector3 (firstBg.position.x+10,currentBg.position.y,currentBg.position.z);
			//update 3rd Bg
			GameManager._instance.firstBg = currentBg;
		}
	}
}
