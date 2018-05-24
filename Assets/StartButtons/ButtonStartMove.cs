using UnityEngine;
using System.Collections;

public class ButtonStartMove : MonoBehaviour {
	private float fallSpeed;

	// Use this for initialization
	void Start () {
		fallSpeed = 500f;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (Vector3.up * fallSpeed* Time.deltaTime, Space.World);

		if (transform.position.y > 155){
			fallSpeed = 0f;


		}
	
	}
}

