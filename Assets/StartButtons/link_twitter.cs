using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class link_twitter : MonoBehaviour {
	private Button button;
	public Sprite Black;
	public Sprite Blue;
	private float fallSpeed;
	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (Screen.width / 2, Screen.height / 3 - 2*Screen.height / 12);
		button = GetComponent<Button> ();
	}

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			button.image.sprite = Black;
		} else {
			button.image.sprite = Blue;
		}

		if (Input.touchCount == 1) {
			Touch touch = Input.GetTouch (0);
			float x = touch.position.x;
			if (x < transform.position.x) {
				fallSpeed = 160f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (x == transform.position.x) {
				fallSpeed = 0f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (x > transform.position.x) {
				fallSpeed = 160f;
				transform.Translate (Vector3.right * fallSpeed * Time.deltaTime, Space.World);
			}
		}
		if (Input.touchCount == 0) {
			if (Screen.width / 2 < transform.position.x) {
				fallSpeed = 160f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (Screen.width / 2 == transform.position.x) {
				fallSpeed = 0f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (Screen.width / 2 > transform.position.x) {
				fallSpeed = 160f;
				transform.Translate (Vector3.right * fallSpeed * Time.deltaTime, Space.World);
			}
	}
	}

	public void press (){
		Application.OpenURL("https://twitter.com/_Papl0_");
	}
}
