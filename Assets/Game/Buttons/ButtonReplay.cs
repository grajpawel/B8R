using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonReplay : MonoBehaviour {
	

	void Start () {
		
	}

	public void StartGame() {
		SceneManager.LoadScene("1");
	}

	public void Update(){
		
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 0){

				transform.position = new Vector3(0, 0, 0);


			}
		}
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 1){

				transform.position = new Vector3(0, 12, 0);
			}
		}
	}
}