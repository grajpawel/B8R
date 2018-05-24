using UnityEngine;
using System.Collections;

public class TextColor : MonoBehaviour {
	public GUIStyle guiStyleB8R = new GUIStyle();
	public Font pixel;
	public Font normal;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


	}
	void OnGUI() {
		guiStyleB8R.fontSize = Screen.width / 4;


		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
			guiStyleB8R.normal.textColor = Color.black;

			
		}
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			guiStyleB8R.normal.textColor = Color.white;

	}
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			GUI.skin.font = pixel;

		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			GUI.skin.font = normal;

		
		}
		GUI.Label(new Rect(Screen.width/2, Screen.height/10, 0, 0), "B8R", guiStyleB8R);
			
}
}



