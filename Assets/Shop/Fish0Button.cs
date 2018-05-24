using UnityEngine;
using System.Collections;

public class Fish0Button : MonoBehaviour {
	private int clickId;
	// Use this for initialization
	void Start () {
		clickId = AudioCenter.loadSound ("click2");
		transform.localScale = new Vector2 (Screen.width/220, Screen.width/120); 
	}

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("ShopPage") == 0) {

			transform.position = new Vector2 (Screen.width/2, Screen.height / 3f);
		} else {

			transform.position = new Vector2 (Screen.width + 100, Screen.height/3);
		}
	}
	public void Buying (){
		if (PlayerPrefs.GetInt ("Bought0") == 1) {
			if (PlayerPrefs.GetInt ("FishEq") != 0) {
				if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioCenter.playSound (clickId);

				PlayerPrefs.SetInt ("FishEq", 0);
			}
		} else {
			if (PlayerPrefs.GetInt ("CoinNum") >= 0) {
				if (PlayerPrefs.GetInt ("Sound") == 1)
				AudioCenter.playSound (clickId);
				PlayerPrefs.SetInt ("Bought0", 1);
				PlayerPrefs.SetInt ("FishEq", 0);
			}
		}
	}
}
