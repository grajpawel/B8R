using UnityEngine;
using System.Collections;


public class ShopSwipe : MonoBehaviour {
	private float fingerStartTime  = 0.0f;
	private Vector2 fingerStartPos = Vector2.zero;
	private int soundId;

	private bool isSwipe = false;
	private float minSwipeDist  = 50.0f;
	private float maxSwipeTime = 1f;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("CoinNum", 1190);
		soundId = AudioCenter.loadSound ("whoosh");
		PlayerPrefs.SetInt("ShopPage", 0);
	}

	// Update is called once per frame
	void Update () {

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
								if (PlayerPrefs.GetInt ("ShopPage") == 0) {
								}
								else { 
									if (PlayerPrefs.GetInt ("Sound") == 1)				
										
									AudioCenter.playSound (soundId);

									PlayerPrefs.SetInt("ShopPage", (PlayerPrefs.GetInt ("ShopPage") - 1 ));
								}
								// MOVE RIGHT

							}else{ // move left
								if (PlayerPrefs.GetInt ("ShopPage") == 6) {

								}
								else {
									if (PlayerPrefs.GetInt ("Sound") == 1)				
										
									AudioCenter.playSound (soundId);

									PlayerPrefs.SetInt("ShopPage", (PlayerPrefs.GetInt ("ShopPage") + 1 ));
								}	
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
