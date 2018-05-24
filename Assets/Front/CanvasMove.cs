using UnityEngine;
using System.Collections;

public class CanvasMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1) {
			Touch touch = Input.GetTouch (0);
			float x = touch.position.x;

			transform.position = new Vector3 (x, Screen.height / 1.7f, 0);
		} else {
			transform.position = new Vector2 (Screen.width / 2, Screen.height / 1.7f);
		}
	}
}
