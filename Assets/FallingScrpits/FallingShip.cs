  using UnityEngine;
 using System.Collections;
 
 public class FallingShip : MonoBehaviour {
private float fallSpeed;

 private float[] PosArray;
 private int a;
 public Sprite[] ship_pixel;
 public Sprite[] ship_normal;
 public Sprite ship_normal_bw;
 public Sprite ship_pixel_bw;
private bool hasPlayed;
public bool runOnce = true;



 
 
     
	void Start(){
		if (PlayerPrefs.GetInt ("Mode") == 1){
			gameObject.GetComponent<SpriteRenderer> ().sprite = ship_pixel[1];

		}
		if (PlayerPrefs.GetInt ("Mode") == 3){
			gameObject.GetComponent<SpriteRenderer> ().sprite = ship_normal[1];
		}
		if (PlayerPrefs.GetInt ("Mode") == 4){
			gameObject.GetComponent<SpriteRenderer> ().sprite = ship_normal_bw;
		}
		if (PlayerPrefs.GetInt ("Mode") == 2){
			gameObject.GetComponent<SpriteRenderer> ().sprite = ship_pixel_bw;
		}
		 PosArray = new float[2];
	  
	  PosArray[0] = -0.75F;
	  PosArray[1] = 0.75F;
	 
	  
      
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
				hasPlayed = false;
				fallSpeed = GameController.force;
			}
		}

		


	 int i = Random.Range(0, ship_pixel.Length);
	 	transform.localEulerAngles = new Vector3(0,0,0);
         transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        if (transform.position.y <= -4f) {
			a = UnityEngine.Random.Range (0, 2);
     transform.position = new Vector2(PosArray[a], 4.4f);
			if (PlayerPrefs.GetInt ("Mode") == 1){
				gameObject.GetComponent<SpriteRenderer> ().sprite = ship_pixel[i];
	
     }
			if (PlayerPrefs.GetInt ("Mode") == 3){
				gameObject.GetComponent<SpriteRenderer> ().sprite = ship_normal[i];
 }
			if (PlayerPrefs.GetInt ("Mode") == 4){
				gameObject.GetComponent<SpriteRenderer> ().sprite = ship_normal_bw;
	}
			if (PlayerPrefs.GetInt ("Mode") == 2){
				gameObject.GetComponent<SpriteRenderer> ().sprite = ship_pixel_bw;
			}
	}
	}
 void OnCollisionStay2D(Collision2D col) {
        if (col.gameObject.tag == "Player"){
			TeleportUp ();
			PlayerPrefs.SetInt("On", 0);
			if (hasPlayed == false) {
				
				hasPlayed = true;
			}
		}
			
}

	void TeleportUp(){
		transform.position = new Vector2(Random.Range(-0.9F, 0.9F), 5f);	
	}
	void TeleportAway(){
		transform.position = new Vector2(20, 30);	
	}

 }