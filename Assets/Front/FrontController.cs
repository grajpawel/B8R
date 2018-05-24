using UnityEngine;
using System.Collections;


public class FrontController : MonoBehaviour {
	private float fingerStartTime  = 0.0f;
	private Vector2 fingerStartPos = Vector2.zero;

	private bool isSwipe = false;
	private float minSwipeDist  = 50.0f;
	private float maxSwipeTime = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		

		if (PlayerPrefs.GetInt ("GraphMode") == 1) {
			if (PlayerPrefs.GetInt ("ColorMode") == 1) {
				PlayerPrefs.SetInt ("Mode", 1);
			}
			if (PlayerPrefs.GetInt ("ColorMode") == 0) {
				PlayerPrefs.SetInt ("Mode", 2);
			}

		}
		if (PlayerPrefs.GetInt ("GraphMode") == 0) {
			if (PlayerPrefs.GetInt ("ColorMode") == 1) {
				PlayerPrefs.SetInt ("Mode", 3);
			}
			if (PlayerPrefs.GetInt ("ColorMode") == 0) {
				PlayerPrefs.SetInt ("Mode", 4);
			}

		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
			return;
		}
		if (Input.touchCount == 0)
			return;
		if (Input.touchCount > 0){

			foreach (Touch touch in Input.touches)
			{
				switch (touch.phase)
				{
				case TouchPhase.Began :
					/* this is a new touch */
					isSwipe = true;
					fingerStartTime = Time.time;
					fingerStartPos = touch.position;
					break;

				case TouchPhase.Canceled :
					/* The touch is being canceled */
					isSwipe = false;
					break;

				case TouchPhase.Ended :

					float gestureTime = Time.time - fingerStartTime;
					float gestureDist = (touch.position - fingerStartPos).magnitude;

					if (isSwipe && gestureTime < maxSwipeTime && gestureDist > minSwipeDist){
						Vector2 direction = touch.position - fingerStartPos;
						Vector2 swipeType = Vector2.zero;

						if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y)){
							// the swipe is horizontal:
							swipeType = Vector2.right * Mathf.Sign(direction.x);
						}else{
							// the swipe is vertical:
							swipeType = Vector2.up * Mathf.Sign(direction.y);
						}

						if(swipeType.x != 0.0f){
							if(swipeType.x > 0.0f){
								if (PlayerPrefs.GetInt ("GraphMode") == 1) {
									PlayerPrefs.SetInt ("GraphMode", 0);
								}
								else {
									PlayerPrefs.SetInt("GraphMode", 1);
								}	// MOVE RIGHT

							}else{
								if (PlayerPrefs.GetInt ("ColorMode") == 1) {
									PlayerPrefs.SetInt ("ColorMode", 0);
								}
								else {
									PlayerPrefs.SetInt("ColorMode", 1);
								}// MOVE LEFT
							}
						}

						if(swipeType.y != 0.0f ){
							if(swipeType.y > 0.0f){
								// MOVE UP
							}else{
								// MOVE DOWN
							}
						}

					}

					break;
				}
			}
		}

	}
}
	