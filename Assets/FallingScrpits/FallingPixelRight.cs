using UnityEngine;
using System.Collections;

public class FallingPixelRight : MonoBehaviour {
	private float fallSpeed;
	private float SideFallSpeed;
	public Sprite SquareColor;
	public Sprite CircleColor;
	public Sprite SquareBW;
	public Sprite CircleBW;



	void Start()
	{
		SideFallSpeed = 0.5f;
		if (PlayerPrefs.GetInt ("Mode") == 1) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = SquareColor;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3) { 
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = CircleColor;
		}
		if (PlayerPrefs.GetInt ("Mode") == 2) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = SquareBW;
		} 
		if (PlayerPrefs.GetInt ("Mode") == 4) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = CircleBW;
		}
		fallSpeed = 2f;

	}


	void Update() {
		transform.Translate (Vector3.left * SideFallSpeed * Time.deltaTime, Space.World);

		if (transform.position.x <= 1.38) {
			SideFallSpeed = 0f;


		}
		if (PlayerPrefs.HasKey ("On")) {
			if (PlayerPrefs.GetInt ("On") == 0) {
				fallSpeed = 0;
			}
		}
		if (PlayerPrefs.HasKey ("On")) {
			if (PlayerPrefs.GetInt ("On") == 1) {
				fallSpeed = GameController.force;
			}
		}

	
		transform.localEulerAngles = Vector3.zero;
		transform.Translate (Vector3.down * GameController.force * Time.deltaTime, Space.World);
		if (transform.position.y <= -3) {
			if (GameController.score <= 5) {

				transform.position = new Vector2 (transform.position.x, 3f);
			} else {
				transform.position = new Vector2 (1.38f, 3f);
			}	



		}
	}

	void OnCollisionStay2D(Collision2D col) {
		if (col.gameObject.tag == "Player"){
			PlayerPrefs.SetInt("On", 0);
		}

	}
}