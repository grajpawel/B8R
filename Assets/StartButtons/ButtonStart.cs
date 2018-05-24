using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour {
	public Sprite Square_Black;
	public Sprite Square_White;
	public Sprite Circle_Black;
	public Sprite Circle_White;
	private Button button;

	void Start () {
		button = GetComponent<Button> ();
		transform.localScale = new Vector2 (1, 1); 

	}
	
	public void StartGame() {
	SceneManager.LoadScene("1");
	}

	public void Update(){
		
		if (PlayerPrefs.GetInt ("Mode") == 2){
			button.image.sprite = Square_White;
		}
		if (PlayerPrefs.GetInt ("Mode") == 1){
			button.image.sprite = Square_Black;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3){
			button.image.sprite = Circle_Black;
		}
		if (PlayerPrefs.GetInt ("Mode") == 4){
			button.image.sprite = Circle_White;
		}
	

}
	}
