using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (Screen.width / 10, Screen.height / 1.1f);
		transform.localScale = new Vector2 (Screen.width / 185, Screen.width / 185); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void StartGame() {
		SceneManager.LoadScene("2");

	}
}
