using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class big_button_mode : MonoBehaviour {
	private Button button;
	public Sprite Square_Color;
	public Sprite Square_White;
	public Sprite Circle_Color;
	public Sprite Circle_White;
	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();
		transform.localScale = new Vector2 (1, 1.2f); 
		transform.position = new Vector2 (Screen.width / 2, Screen.height / 3);


		if (PlayerPrefs.HasKey ("GraphMode")) {
		}
			
				
		else {
			PlayerPrefs.SetInt("GraphMode", 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Mode") == 2){
			button.image.sprite = Square_White;
		}
		if (PlayerPrefs.GetInt ("Mode") == 1){
			button.image.sprite = Square_Color;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3){
			button.image.sprite = Circle_Color;
		}
		if (PlayerPrefs.GetInt ("Mode") == 4){
			button.image.sprite = Circle_White;
		}
	}
	public void SwitchMode () {
		if (PlayerPrefs.GetInt ("GraphMode") == 1) {
			PlayerPrefs.SetInt ("GraphMode", 0);
		}
			else {
				PlayerPrefs.SetInt("GraphMode", 1);
			}



	}

}
