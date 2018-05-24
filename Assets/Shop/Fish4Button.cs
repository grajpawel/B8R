using UnityEngine;
using System.Collections;

public class Fish4Button : MonoBehaviour {
	private int soundId;
	private int clickId;
	// Use this for initialization
	void Start () {
		soundId = AudioCenter.loadSound ("cash");
		clickId = AudioCenter.loadSound ("click2");
		transform.localScale = new Vector2 (Screen.width/220, Screen.width/120); 
	}

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("ShopPage") == 4) {

			transform.position = new Vector2 (Screen.width/2, Screen.height / 3f);
		} else {

			transform.position = new Vector2 (Screen.width + 100, Screen.height/3);
		}
	}
	public void Buying (){
		if (PlayerPrefs.GetInt ("Bought4") == 1) {
			if (PlayerPrefs.GetInt ("FishEq") != 4) {
				if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioCenter.playSound (clickId);

				PlayerPrefs.SetInt ("FishEq", 4);
			}
		} else {
			if (PlayerPrefs.GetInt ("CoinNum") >= 50) {
				if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioCenter.playSound (soundId);
				PlayerPrefs.SetInt ("CoinNum", (PlayerPrefs.GetInt ("CoinNum") - 50));
				PlayerPrefs.SetInt ("Bought4", 1);
				PlayerPrefs.SetInt ("FishEq", 4);
			}
		}
	}
}
