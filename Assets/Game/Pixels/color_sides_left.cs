﻿using UnityEngine;
using System.Collections;

public class color_sides_left : MonoBehaviour {
	private float SideFallSpeed;
	// Use this for initialization
	void Start () {
		SideFallSpeed = 0.5f;
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
			gameObject.GetComponent<Renderer>().material.color = new Color32(238, 195, 153, 255);
		}
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 255);
		}
	}


	// Update is called once per frame

		void Update () {
			transform.Translate (Vector3.right * SideFallSpeed* Time.deltaTime, Space.World);

			if (transform.position.x >= -1.6){
				SideFallSpeed = 0f;


			}
		
}
}