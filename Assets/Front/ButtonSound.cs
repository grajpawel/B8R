using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonSound: MonoBehaviour {
	public Sprite Pixel;
	public Sprite PixelOff;
	public Sprite Normal;
	public Sprite NormalOff;
	private Button button;

	// Use this for initialization
	void Awake () {
		button = GetComponent<Button> ();

	}

	// Update is called once per frame
	public void OnTap () {
		if (PlayerPrefs.GetInt ("Sound") == 1) {
			PlayerPrefs.SetInt ("Sound", 0);
		

		}else {
			PlayerPrefs.SetInt("Sound", 1);
			}
	}
	void Update () {
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			if (PlayerPrefs.GetInt ("Sound") == 1) {
				AudioListener.volume = 1;
				button.image.sprite = Pixel;
			}
			else {
				button.image.sprite = PixelOff;
				AudioListener.volume = 0;
			}
		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			if (PlayerPrefs.GetInt ("Sound") == 1) {
				AudioListener.volume = 1;
				button.image.sprite = Normal;
			}
			else {
				button.image.sprite = NormalOff;
				AudioListener.volume = 0;
			}

		}
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
			button.image.color = Color.black;
		}
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {

			button.image.color = Color.white;
		}


	}
}
