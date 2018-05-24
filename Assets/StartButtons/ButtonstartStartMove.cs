using UnityEngine;
using System.Collections;

public class ButtonstartStartMove : MonoBehaviour {
	private float fallSpeed;
	private float RotateSpeed;
	private int Gamemode;
	private AudioSource source;
	private bool hasPlayed = false;
	private int soundId;

	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("whoosh");
		transform.position = new Vector2 (Screen.width / 2, Screen.height / 1.7f);
	}

	// Update is called once per frame
	void Update () {
		Debug.Log (hasPlayed);
		
		if (Input.touchCount == 1) {
			Touch touch = Input.GetTouch (0);
			float x = touch.position.x;
			if (x < transform.position.x) {
				fallSpeed = 900f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (x == transform.position.x) {
				fallSpeed = 0f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (x > transform.position.x) {
				fallSpeed = 900f;
				transform.Translate (Vector3.right * fallSpeed * Time.deltaTime, Space.World);
			}
		}
		if (Input.touchCount == 0) {
			if (Screen.width / 2 < transform.position.x) {
				if (hasPlayed == false) {
					if (PlayerPrefs.GetInt ("Sound") == 1)				
					AudioCenter.playSound (soundId);
					hasPlayed = true;
				}
				transform.position = new Vector2(Screen.width / 2, transform.position.y);	

			}
				if (Screen.width / 2 == transform.position.x) {
				fallSpeed = 0f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
				hasPlayed = false;

			}
			if (Screen.width / 2 > transform.position.x) {
				if (hasPlayed == false) {
					if (PlayerPrefs.GetInt ("Sound") == 1)				
					AudioCenter.playSound (soundId);
					hasPlayed = true;
				}
				transform.position = new Vector2(Screen.width / 2, transform.position.y);	

			
	}
}
}
}



