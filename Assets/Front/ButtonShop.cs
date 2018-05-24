using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonShop : MonoBehaviour {
	public Sprite Pixel;
	public Sprite Normal;
	private Button button;
	private float fallSpeed;
	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();

		transform.position = new Vector2 (Screen.width/2, Screen.height/3); 

	}
	
	// Update is called once per frame
	public void OnTap () {
		SceneManager.LoadScene("Shop");
	}
	void Update () {
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			button.image.sprite = Pixel;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			button.image.sprite = Normal;

		}
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
			button.image.color = Color.black;
		}
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			
			button.image.color = Color.white;
		}


		if (Input.touchCount == 1) {
			Touch touch = Input.GetTouch (0);
			float x = touch.position.x;
			if (x < transform.position.x) {
				fallSpeed = 300f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (x == transform.position.x) {
				fallSpeed = 0f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (x > transform.position.x) {
				fallSpeed = 300f;
				transform.Translate (Vector3.right * fallSpeed * Time.deltaTime, Space.World);
			}
		}
		if (Input.touchCount == 0) {
			if (Screen.width / 2 < transform.position.x) {
				fallSpeed = 300f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (Screen.width / 2 == transform.position.x) {
				fallSpeed = 0f;
				transform.Translate (Vector3.left * fallSpeed * Time.deltaTime, Space.World);
			}
			if (Screen.width / 2 > transform.position.x) {
				fallSpeed = 300f;
				transform.Translate (Vector3.right * fallSpeed * Time.deltaTime, Space.World);
			}
		}
}
}
