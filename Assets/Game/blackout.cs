using UnityEngine;
using System.Collections;

public class blackout : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 0){
						
		transform.position = new Vector3(0, 0, -1f);
		
	}
		
	}
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 1){

				transform.position = new Vector3(0, 9, 0);

			}

		}
	}
}
