using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDie : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			GameManager._instance.GameState = GameManager.GAMESTATE_END;
		}
	}
}
