using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour {
	public Sprite Square_Black;
	public Sprite Square_White;
	public Sprite Circle_Black;
	public Sprite Circle_White;
	private Button button;


	void Start () {
		
		button = GetComponent<Button> ();
	
		if (PlayerPrefs.GetInt ("Mode") == 2)
			button.image.sprite = Square_White;
		
		if (PlayerPrefs.GetInt ("Mode") == 1)
			button.image.sprite = Square_Black;
		
		if (PlayerPrefs.GetInt ("Mode") == 3)
			button.image.sprite = Circle_Black;
		
		if (PlayerPrefs.GetInt ("Mode") == 4)
			button.image.sprite = Circle_White;
		

	}

	public void StartGame() {
		SceneManager.LoadScene("1");

	}

void Update(){


		if (PlayerPrefs.GetInt ("On") == 0) {

			transform.position = new Vector3(-0.6f, -2f, 0);







			}



			if(PlayerPrefs.GetInt("On") == 1){
				transform.position = new Vector3(-0.6f, -4.2f, 0);
		
				
			}

	}
	public void Menu(){
		SceneManager.LoadScene ("2");
	}
}