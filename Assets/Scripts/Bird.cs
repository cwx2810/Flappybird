using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public float timer;
	public int frameNumber = 10;//frame number per second
	public int frameCount = 0;//frame counter

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().velocity = new Vector3 (5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 1.0f / frameNumber) {
			frameCount++;
			timer -= 1.0f / frameNumber;

			//update matirial's offset x while frame count ++
			int frameIndex = frameCount % 3;
			this.GetComponent<Renderer>().material.SetTextureOffset ("_MainTex", new Vector2 (0.33f * frameIndex, 0));
		}
	}
}
