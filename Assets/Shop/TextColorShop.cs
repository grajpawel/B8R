using UnityEngine;
using System.Collections;

public class TextColorShop : MonoBehaviour {
	public GUIStyle guiStyleB8R = new GUIStyle();
	public GUIStyle guiStyleMoney = new GUIStyle();
	public GUIStyle guiStyleCoins = new GUIStyle();
	public Font pixel;
	public Font normal;
	public float posX;
	public float posY;


	// Use this for initialization
	void Start () {

		posX = Screen.width / 2;
		posY = Screen.height / 1.45f;
	}

	// Update is called once per frame
	void Update () {


	}
	void OnGUI() {
		guiStyleB8R.fontSize = Screen.width / 5;
		guiStyleMoney.fontSize = Screen.width / 10;
		guiStyleCoins.fontSize = Screen.width / 10;



			guiStyleB8R.normal.textColor = Color.black;



		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			GUI.skin.font = pixel;

		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			GUI.skin.font = normal;


		}
		GUI.Label(new Rect(Screen.width/2, Screen.height / 10, 0, 0), "shop", guiStyleB8R);

		if (PlayerPrefs.GetInt ("ShopPage") == 0) {

				if (PlayerPrefs.GetInt ("FishEq") == 0) {
					GUI.Label (new Rect (posX, posY, 0, 0), "equipped", guiStyleMoney);
				} else {
					GUI.Label (new Rect (posX, posY, 0, 0), "free", guiStyleMoney);
				}

			if (PlayerPrefs.GetInt ("FishEq") != 1 && PlayerPrefs.GetInt ("FishEq") != 2 && PlayerPrefs.GetInt ("FishEq") != 3 && PlayerPrefs.GetInt ("FishEq") != 4 && PlayerPrefs.GetInt ("FishEq") != 5 && PlayerPrefs.GetInt ("FishEq") != 6) {
				GUI.Label (new Rect (posX, posY, 0, 0), "equipped", guiStyleMoney);
			}
		}
		if (PlayerPrefs.GetInt ("ShopPage") == 1) {
			if (PlayerPrefs.GetInt ("Bought1") == 1) {
				if (PlayerPrefs.GetInt ("FishEq") == 1) {
					GUI.Label (new Rect (posX, posY, 0, 0), "equipped", guiStyleMoney);
				} else {
					GUI.Label (new Rect (posX, posY, 0, 0), "free", guiStyleMoney);
				}
			} else {
				GUI.Label (new Rect (posX,posY, 0, 0), "50", guiStyleMoney);
			}
		}
		if (PlayerPrefs.GetInt ("ShopPage") == 2) {
			if (PlayerPrefs.GetInt ("Bought2") == 1) {
				if (PlayerPrefs.GetInt ("FishEq") == 2) {
					GUI.Label (new Rect (posX, posY, 0, 0), "equipped", guiStyleMoney);
				} else {
					GUI.Label (new Rect (posX, posY, 0, 0), "free", guiStyleMoney);
				}
			} else {
				GUI.Label (new Rect (posX,posY, 0, 0), "50", guiStyleMoney);
			}
		}
		if (PlayerPrefs.GetInt ("ShopPage") == 3) {
			if (PlayerPrefs.GetInt ("Bought3") == 1) {
				if (PlayerPrefs.GetInt ("FishEq") == 3) {
					GUI.Label (new Rect (posX, posY, 0, 0), "equipped", guiStyleMoney);
				} else {
					GUI.Label (new Rect (posX, posY, 0, 0), "free", guiStyleMoney);
				}
			} else {
				GUI.Label (new Rect (posX,posY, 0, 0), "50", guiStyleMoney);
			}
		}
		if (PlayerPrefs.GetInt ("ShopPage") == 4) {
			if (PlayerPrefs.GetInt ("Bought4") == 1) {
				if (PlayerPrefs.GetInt ("FishEq") == 4) {
					GUI.Label (new Rect (posX, posY, 0, 0), "equipped", guiStyleMoney);
				} else {
					GUI.Label (new Rect (posX, posY, 0, 0), "free", guiStyleMoney);
				}
			} else {
				GUI.Label (new Rect (posX,posY, 0, 0), "50", guiStyleMoney);
			}
		}
		if (PlayerPrefs.GetInt ("ShopPage") == 5) {
			if (PlayerPrefs.GetInt ("Bought5") == 1) {
				if (PlayerPrefs.GetInt ("FishEq") == 5) {
					GUI.Label (new Rect (posX, posY, 0, 0), "equipped", guiStyleMoney);
				} else {
					GUI.Label (new Rect (posX, posY, 0, 0), "free", guiStyleMoney);
				}
			} else {
				GUI.Label (new Rect (posX,posY, 0, 0), "50", guiStyleMoney);
			}
		}
		if (PlayerPrefs.GetInt ("ShopPage") == 6) {
			if (PlayerPrefs.GetInt ("Bought6") == 1) {
				if (PlayerPrefs.GetInt ("FishEq") == 6) {
					GUI.Label (new Rect (posX, posY, 0, 0), "equipped", guiStyleMoney);
				} else {
					GUI.Label (new Rect (posX, posY, 0, 0), "free", guiStyleMoney);
				}
			} else {
				GUI.Label (new Rect (posX,posY, 0, 0), "100", guiStyleMoney);
			}
		}

			GUI.Label (new Rect (Screen.width, 0, 0, 0), (PlayerPrefs.GetInt ("CoinNum").ToString()), guiStyleCoins);
	}

}



