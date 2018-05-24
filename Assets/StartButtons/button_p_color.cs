using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class button_p_color : MonoBehaviour {

	public Sprite Square_Black;
	public Sprite Square_White;
	public Sprite Circle_Black;
	public Sprite Circle_White;
	private Button button;


	// Use this for initialization
	void Start () {
		
		transform.position = new Vector2 (Screen.width / 7, Screen.height / 5);
		button = GetComponent<Button> ();
		if (PlayerPrefs.HasKey ("Mode")) {
			} 
		else {
			PlayerPrefs.SetInt ("Mode", 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (PlayerPrefs.GetInt ("Mode"));
		if (PlayerPrefs.GetInt ("Mode") == 1) {
			button.image.rectTransform.sizeDelta = new Vector2 (Screen.width/4, Screen.width/4);
		} else {
			button.image.rectTransform.sizeDelta = new Vector2 (Screen.width/5, Screen.width/5);
		}
		if (PlayerPrefs.GetInt ("Mode") == 1){
			button.image.sprite = Square_Black;
		}
		if (PlayerPrefs.GetInt ("Mode") == 2){
			button.image.sprite = Square_White;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3){
			button.image.sprite = Circle_Black;
		}
		if (PlayerPrefs.GetInt ("Mode") == 4){
			button.image.sprite = Circle_White;
		}
	}
			

	public void Mode1 () {
		PlayerPrefs.SetInt ("Mode", 1);	

}
}

