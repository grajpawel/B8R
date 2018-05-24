using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class EasyMove : MonoBehaviour {
	private float fallSpeed;
	public Sprite FishNormal;
	public Sprite FishPixel;
	private bool hasPlayed;
	private int soundId;


void Start () {
		soundId = AudioCenter.loadSound ("bikehorn");

		fallSpeed = 0.85f;
		if (PlayerPrefs.GetInt ("FishEq") == 0) {
			if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (0, 0, 0, 255);
			}

			if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
				gameObject.GetComponent<Renderer> ().material.color = new Color32 (255, 255, 255, 255);
			}
		}
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = FishPixel;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = FishNormal;
		}
		if (PlayerPrefs.GetInt ("FishEq") == 1) {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}
		if (PlayerPrefs.GetInt ("FishEq") == 2) {
			gameObject.GetComponent<Renderer> ().material.color = Color.green;
		}
		if (PlayerPrefs.GetInt ("FishEq") == 3) {
			gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
		}
		if (PlayerPrefs.GetInt ("FishEq") == 4) {
			gameObject.GetComponent<Renderer> ().material.color = Color.cyan;
		}
		if (PlayerPrefs.GetInt ("FishEq") == 5) {
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;
		}

	}

void Update () {

		transform.Translate (Vector3.up * fallSpeed* Time.deltaTime, Space.World);

		if (transform.position.y >= -2){
			fallSpeed = 0f;


		}


		if(PlayerPrefs.GetInt("On") == 1){
			hasPlayed = false;
if(Input.touchCount == 1){
Touch touch = Input.GetTouch(0);
float x = -1.4f + 0.95f * touch.position.x / Screen.width * 3f;

transform.position = new Vector3(x, -2f, 0);
}
		} else {
			if (hasPlayed == false) {
				if (PlayerPrefs.GetInt ("Sound") == 1)		
				AudioCenter.playSound (soundId);
				hasPlayed = true;
			}

}
}
}