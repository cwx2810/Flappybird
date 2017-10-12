using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	void Start(){
		RandomGeneratePosition ();
	}

	public void RandomGeneratePosition(){
		float pos_y = Random.Range (-0.2f, 0.1f);
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x, pos_y, this.transform.localPosition.z);
	}

	//tirgger of score
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			GameManager._instance.score++;
		}
	}

	//test score
	void OnGUI(){
		GUILayout.Label ("Score:" + GameManager._instance.score);
	}
}
