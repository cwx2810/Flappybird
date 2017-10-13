using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static int GAMESTATE_MENU = 0;
	public static int GAMESTATE_PLAYING = 1;
	public static int GAMESTATE_END = 2;

	public Transform firstBg;
	public int score = 0;
	public int GameState = GAMESTATE_MENU;

	public static GameManager _instance;

	private GameObject bird;

	void Awake() {
		_instance = this;
		bird = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update(){
		if (GameState == GameManager.GAMESTATE_MENU) {
			if (Input.GetMouseButtonDown (0)) {
				GameState = GAMESTATE_PLAYING;
				bird.SendMessage ("activeBird");
			}
		}
	}
}
