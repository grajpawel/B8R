using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scorepos : MonoBehaviour {
	public Font pixel;
	public Font normal;
	// Use this for initialization
	void OnGUI () {
		Debug.Log (GUI.skin.font);
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			GUI.skin.font = pixel;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			GUI.skin.font = normal;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 0){
		transform.position = new Vector3(2f, 6f, 0);
		
		}
}
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 1){
				transform.position = new Vector3(0.5f, 0.955f, 0);

			}
		}

}
}