 using UnityEngine;
 using System.Collections;
 
 public class FallingB8 : MonoBehaviour {
	private float fallSpeed;
	public Sprite Normal;
	public Sprite Pixel;
	private bool runOnce = true;
 


     
     void Start()
	{	
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			gameObject.GetComponent<Renderer> ().material.color = new Color32 (255, 255, 255, 255);	

     
		} else {
			gameObject.GetComponent<Renderer> ().material.color = new Color32 (0, 0, 0, 255);
		}
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = Pixel;
		} else {
			gameObject.GetComponent<SpriteRenderer> ().sprite = Normal;

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
		if (col.gameObject.tag == "B8") {
			TeleportUp ();
		}
		if (col.gameObject.tag == "Yacht") {
			TeleportUp ();
		}
		if (col.gameObject.tag == "Fish"){
			  TeleportUp();				
		}
		if (col.gameObject.tag == "Ship"){
			  TeleportUp();				
		}
		if (col.gameObject.tag == "Player"){
			TeleportUp();
			PlayerPrefs.SetInt("On", 0);
		
		

		}			
			  
 
 }
 void TeleportUp(){
		transform.position = new Vector2(Random.Range(-0.9F, 0.9F), Random.Range(3f, 7f));	
 }
	void TeleportAway(){
		transform.position = new Vector2(20, 20);	
	}
 }

 
 