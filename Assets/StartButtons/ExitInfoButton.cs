using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitInfoButton : MonoBehaviour {
	private Button button;
	public Sprite Square_Black;
	public Sprite Square_White;
	public Sprite Circle_Black;
	public Sprite Circle_White;
	// Use this for initialization
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
	public void OnTap(){
		SceneManager.LoadScene ("2");

	}
	// Update is called once per frame
	void Update () {
		
	}
}
