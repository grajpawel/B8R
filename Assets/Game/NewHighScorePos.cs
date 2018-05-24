using UnityEngine;
using System.Collections;

public class NewHighScorePos : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 0){
			transform.position = new Vector3(0.5f, 0.3f, 0);
				GUIUtility.RotateAroundPivot(-90, new Vector2(160, 30));

		}
	}
}
}