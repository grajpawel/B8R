using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonInfo: MonoBehaviour {
	public Sprite Pixel;
	public Sprite Normal;
	private Button button;

	// Use this for initialization
	void Awake () {
		button = GetComponent<Button> ();

			}

	// Update is called once per frame
	public void OnTap () {
		SceneManager.LoadScene("Info");
	}
	void Update () {
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			transform.localScale = new Vector2 (0.85f, 0.85f);
			button.image.sprite = Pixel;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			transform.localScale = Vector2.one;
			button.image.sprite = Normal;

		}
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
			button.image.color = Color.black;
		}
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {

			button.image.color = Color.white;
		}


	}
}
