using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public float timer;
	public int frameNumber = 10;//frame number per second
	public int frameCount = 0;//frame counter

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().velocity = new Vector3 (3, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		//test
		//Vector3 vel = this.GetComponent<Rigidbody> ().velocity;
		//this.GetComponent<Rigidbody>().velocity = new Vector3 (5, vel.y, vel.z);

		timer += Time.deltaTime;
		if (timer >= 1.0f / frameNumber) {
			frameCount++;
			timer -= 1.0f / frameNumber;

			//update matirial's offset x while frame count ++
			int frameIndex = frameCount % 3;
			this.GetComponent<Renderer>().material.SetTextureOffset ("_MainTex", new Vector2 (0.33f * frameIndex, 0));
		}

		//jump
		if(Input.GetMouseButton(0)){
			Vector3 vel2 = this.GetComponent<Rigidbody> ().velocity;
			this.GetComponent<Rigidbody> ().velocity = new Vector3 (vel2.x, 5, vel2.z);
		}
	}
}
