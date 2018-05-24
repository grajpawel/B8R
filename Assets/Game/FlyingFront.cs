 using UnityEngine;
 using System.Collections;
 
 public class FlyingFront : MonoBehaviour {
 public float fallSpeed = 1.0f;


     
     void Start()
     {
		 
     
	 }
     
 void Update() {
	 
 
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        if (transform.position.y <= -6f) {
	transform.position = new Vector2(Random.Range(-0.9F, 0.9F), 6f);
	transform.localEulerAngles = new Vector3(0f, 0f, Random.Range(0f, 360f));	
		}
 }
 }
 
 