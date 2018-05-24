using UnityEngine;
using System.Collections;

public class FallingYacht : MonoBehaviour {
	private float fallSpeed;
	public Sprite Normal;
	public Sprite Pixel;
	private bool runOnce = true;




	void Start()
	{	
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 1) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = Pixel;

		} else {
			gameObject.GetComponent<SpriteRenderer> ().sprite = Normal;
		}
	}

	void Update() {
		transform.localEulerAngles = new Vector3(0,0,0);
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
		if (transform.position.y <= -5f) {
			TeleportUp();
		}


	}
	void OnCollisionStay2D(Collision2D col) {
		if (col.gameObject.tag == "Coin") {
			TeleportUp ();
		}
		if (col.gameObject.tag == "B8") {
			TeleportUp ();
		}
		if (col.gameObject.tag == "Fish") {
			TeleportUp ();				
		}
		if (col.gameObject.tag == "Ship") {
			TeleportUp ();				
		}
		if (col.gameObject.tag == "Player") {
			TeleportUp ();
			PlayerPrefs.SetInt ("On", 0);
				

					
				
				
			}

		}

	void TeleportUp(){
		transform.position = new Vector2(Random.Range(-0.8F, 0.8F), 6f);	
	}
	void TeleportAway(){
		transform.position = new Vector2(20, 40);	
	}
}


