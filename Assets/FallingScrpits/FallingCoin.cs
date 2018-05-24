using UnityEngine;
using System.Collections;

public class FallingCoin : MonoBehaviour {
private float fallSpeed;
public Sprite coin;
public Sprite coin_bw;
public Sprite circle_coin_bw;
public Sprite circle_coin;
private int soundId;



 public int coinnum = 0;
	// Use this for initialization
	void Start () {
		
		if (PlayerPrefs.GetInt ("Mode") == 1) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = coin;
			soundId = AudioCenter.loadSound ("coin");
		}
		if (PlayerPrefs.GetInt ("Mode") == 2) {
			soundId = AudioCenter.loadSound ("coin");
			gameObject.GetComponent<SpriteRenderer> ().sprite = coin_bw;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3) {
			soundId = AudioCenter.loadSound ("cork");
			gameObject.GetComponent<SpriteRenderer> ().sprite = circle_coin;
		}
		if (PlayerPrefs.GetInt ("Mode") == 4) {
			soundId = AudioCenter.loadSound ("cork");
			gameObject.GetComponent<SpriteRenderer> ().sprite = circle_coin_bw;
		}




		if(PlayerPrefs.HasKey("CoinNum")){
		coinnum = PlayerPrefs.GetInt("CoinNum");
			}
	
	
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 0){
				fallSpeed = 0;
				TeleportUp ();
			}
		}
		if(PlayerPrefs.HasKey("On")){
			if(PlayerPrefs.GetInt("On") == 1){
				fallSpeed = GameController.force;	
			}
		}
		


	

	transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
    if (transform.position.y <= -4f) {
		TeleportUp();
		}
}
void OnCollisionEnter2D(Collision2D col) 
{
        if (col.gameObject.tag == "B8"){
			  TeleportUp();
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
			if (PlayerPrefs.GetInt ("Sound") == 1)				
		AudioCenter.playSound (soundId);
		TeleportUp();
		PlayerPrefs.SetInt("CoinNum", (PlayerPrefs.GetInt("CoinNum")+1));
		}
}
void TeleportUp(){
	transform.position = new Vector2(Random.Range(-0.9F, 0.9F), 12f);
}
}