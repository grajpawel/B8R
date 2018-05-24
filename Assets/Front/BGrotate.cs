using UnityEngine;
using System.Collections;

public class BGrotate : MonoBehaviour {
	public Sprite Black;
	public Sprite Blue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = Black;
		} else {
			gameObject.GetComponent<SpriteRenderer> ().sprite = Blue;
		}
		transform.localEulerAngles += new Vector3(0, 0, 0.05f);
	}
}
