using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SquareScript : MonoBehaviour {
public static float SquareScale;
private float SideFallSpeed;
	// Use this for initialization
	void Start () {
		SideFallSpeed = 0.5f;
		Time.timeScale = 1;
		SquareScale = 0.002F;


		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
			gameObject.GetComponent<Renderer>().material.color = Color.yellow;

		}
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			
		}
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.down * SideFallSpeed* Time.deltaTime, Space.World);

		if (transform.position.y <= 2.459){
			SideFallSpeed = 0f;


		}
		transform.localScale -= new Vector3 (SquareScale, 0, 0);
	
		if (transform.localScale.x < 0) {
			transform.localScale = Vector3.zero; 
			  
			PlayerPrefs.SetInt ("On", 0);
			  
			  
		}
		if (PlayerPrefs.HasKey ("On")) {
			if (PlayerPrefs.GetInt ("On") == 0) {
				transform.localScale = new Vector3 (0, 0, 0); 
			}
		}
	}

	public void changePos(){
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 1){
				transform.localScale = new Vector3(1.8f, 0.3f, 0); 
			}
		}
}
}