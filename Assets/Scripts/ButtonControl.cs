using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour {

	public static ButtonControl _instance;
	void Awake(){
		_instance = this;
		this.gameObject.SetActive (false);
	}
}
