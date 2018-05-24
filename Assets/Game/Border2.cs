using UnityEngine;
using System.Collections;

public class Border : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.x <= -1.07f) {
     transform.position = new Vector2(-1.07f, transform.position.y);
 } else if (transform.position.x >= 1.07f) {
     transform.position = new Vector2(1.07f, transform.position.y);
 
 }
}
}