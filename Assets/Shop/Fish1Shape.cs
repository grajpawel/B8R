using UnityEngine;
using System.Collections;

public class Fish1Shape : MonoBehaviour {
	public Sprite FishNormal;
	public Sprite FishPixel;
	// Use this for initialization
	void Start () {
		
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = FishPixel;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = FishNormal;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("ShopPage") == 1) {
			
			transform.position = new Vector2 (0, 0);
		} else {
			
			transform.position = new Vector2 (10, 0);
	}
		transform.eulerAngles += new Vector3 (0, 1, 0);
}
}
