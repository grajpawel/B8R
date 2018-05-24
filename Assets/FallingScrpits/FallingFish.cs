 using UnityEngine;
 using System.Collections;
 
 public class FallingFish : MonoBehaviour {
 private float fallSpeed;
 private bool runOnce = true;
private int soundId;
     
     void Start()
     {	
		soundId = AudioCenter.loadSound ("fish");
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
			gameObject.GetComponent<Renderer>().material.color = new Color32(255, 237, 0, 255);
		}
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			gameObject.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
		}
	}
	 
     
 void Update() {
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 0){
				fallSpeed = 0;
				TeleportAway ();
				runOnce = true;
			}
		}
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 1){
				if (runOnce == true) {
					TeleportUp ();
					runOnce = false;
				}
				fallSpeed = GameController.force;	
			}
		}
	
	 	
	

transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        if (transform.position.y <= -4f) {
				TeleportUp();
	   }
 
	 
 }
 void OnCollisionStay2D(Collision2D col) {
        if (col.gameObject.tag == "Coin"){
			  TeleportUp();
		}
		if (col.gameObject.tag == "B8"){
			  TeleportUp();				
		}
		if (col.gameObject.tag == "Ship"){
			  TeleportUp();				
		}
		if (col.gameObject.tag == "Yacht") {
			TeleportUp ();
		}
		if (col.gameObject.tag == "Player"){
			if (PlayerPrefs.GetInt ("Sound") == 1)				
			AudioCenter.playSound (soundId);
			GameObject.FindGameObjectWithTag("Square").transform.localScale = new Vector3(1.8f, 0.3f, 1f);
			TeleportUp();
			
		}			
			  
 
 }
 void TeleportUp(){
	 transform.position = new Vector2(Random.Range(-0.9F, 0.9F), 8f);	
		transform.localEulerAngles = new Vector3(0,0,(Random.Range(0f, 360f)));
 }
	void TeleportAway(){
		transform.position = new Vector2(20, 60);	
	}
 }

 
 
 