using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Transform firstBg;
	public int score = 0;

	public static GameManager _instance;

	void Awake() {
		_instance = this;
	}
}
