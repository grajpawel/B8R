using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public GUIText scoreText;
	public static int score;
	private int now = 1; 
	public float timer;
	public int highscore = 0;
	public static float force;

	public Font pixel;
	public Font normal;

		
	
	public GUIStyle guiStyleScore = new GUIStyle();
	public GUIStyle guiStyleHighScore = new GUIStyle();
	public GUIStyle guiStyleNewHighScore = new GUIStyle();
	public GUIStyle guiStyleScoreCounter = new GUIStyle();
	public GUIStyle guiStyleScoreText = new GUIStyle();
	public GUIStyle guiStyleHighscoreText = new GUIStyle();



	// Use this for initialization
	void Start () {

	


		
		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
			guiStyleScoreCounter.font = pixel;
			guiStyleScoreText.font = pixel;
			guiStyleHighscoreText.font = pixel;
			guiStyleScore.font = pixel;
			guiStyleHighScore.font = pixel;
			guiStyleNewHighScore.font = pixel;
		}
		if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
			guiStyleScoreCounter.font = normal;
			guiStyleScoreText.font = normal;
			guiStyleHighscoreText.font = normal;
			guiStyleScore.font = normal;
			guiStyleHighScore.font = normal;
			guiStyleNewHighScore.font = normal;

		}




		if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
			guiStyleScoreCounter.normal.textColor = Color.black;
			guiStyleScoreText.normal.textColor = new Color32(238, 195, 153, 255);
			guiStyleHighscoreText.normal.textColor = new Color32(238, 195, 153, 255);
			guiStyleScore.normal.textColor = new Color32(238, 195, 153, 255);
			guiStyleHighScore.normal.textColor = new Color32(238, 195, 153, 255);
			guiStyleNewHighScore.normal.textColor = Color.red;
		}
		if (PlayerPrefs.GetInt ("Mode") == 2 || PlayerPrefs.GetInt ("Mode") == 4) {
			guiStyleScoreCounter.normal.textColor = Color.white;
			guiStyleScoreText.normal.textColor = Color.white;
			guiStyleHighscoreText.normal.textColor = Color.white;
			guiStyleScore.normal.textColor = Color.white;
			guiStyleHighScore.normal.textColor = Color.white;
			guiStyleNewHighScore.normal.textColor = Color.blue;
		}
		score = 0;
		PlayerPrefs.SetInt("On", 1);
		force = 1.2f;
	
	if(PlayerPrefs.HasKey("Highscore")){
		highscore = PlayerPrefs.GetInt("Highscore");
	}
	
	UpdateScore ();
	InvokeRepeating ("AddOne", 1, 1);
	}
	

	void Update () {

		Debug.Log (PlayerPrefs.GetInt ("On"));
		Debug.Log (PlayerPrefs.GetInt ("CoinNum"));


		force = force + 0.0005f;
	


		guiStyleScoreCounter.fontSize = Screen.width / 10;

		
		if (PlayerPrefs.HasKey ("Highscore")) {
			if (PlayerPrefs.GetInt ("Highscore") < score) {
				PlayerPrefs.SetInt ("Highscore", score);
			}	
		} else {
			PlayerPrefs.SetInt ("Highscore", score);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene("2");
			return;
		}
	}
	
	

	void UpdateScore (){
	scoreText.text = score.ToString();
	}	
	
	
   void AddOne () {
		if (PlayerPrefs.HasKey ("On")) {
			if (PlayerPrefs.GetInt ("On") == 1) {
				
				if (now > 0) {
					score = score + 1;
	  
					UpdateScore ();
				}    
			}  
		}
	}

void OnGUI() {
guiStyleScore.alignment = TextAnchor.UpperCenter;	
guiStyleHighScore.alignment = TextAnchor.UpperCenter;		
guiStyleNewHighScore.alignment = TextAnchor.UpperCenter;	



		GUI.Label(new Rect(Screen.width/2, Screen.height/21, 0, 0), score.ToString(), guiStyleScoreCounter);

	


			if(PlayerPrefs.GetInt("On") == 0){
			guiStyleScoreCounter.fontSize = -1;
			guiStyleScore.fontSize = Screen.width / 4;
			guiStyleHighScore.fontSize = Screen.width / 5;
			guiStyleHighscoreText.fontSize = Screen.width /10;
			guiStyleScoreText.fontSize = Screen.width / 10;
		GUI.Label(new Rect(Screen.width/2, Screen.height/7, 0, 0), score.ToString(), guiStyleScore);
		GUI.Label(new Rect(Screen.width/2, Screen.height/2, 0, 0), highscore.ToString(), guiStyleHighScore);


			if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
				GUI.Label (new Rect (Screen.width / 2, Screen.height / 2.2f, 0, 0), "highscore", guiStyleHighscoreText);
			}


			if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
				GUI.Label (new Rect (Screen.width / 2, Screen.height / 14, 0, 0), "score", guiStyleScoreText);
			}
			if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
				GUI.Label (new Rect (Screen.width / 2, Screen.height / 2.2f, 0, 0), "Highscore", guiStyleHighscoreText);
			}


			if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
				GUI.Label (new Rect (Screen.width / 2, Screen.height / 14, 0, 0), "Score", guiStyleScoreText);
			}





				if(highscore < score){
				if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 2) {
					GUI.Label (new Rect (Screen.width / 2, Screen.height / 3, 0, 0), "new highscore", guiStyleNewHighScore);
				}
				if (PlayerPrefs.GetInt ("Mode") == 3 || PlayerPrefs.GetInt ("Mode") == 4) {
					GUI.Label (new Rect (Screen.width / 2, Screen.height / 3, 0, 0), "New Highscore", guiStyleNewHighScore);
				}
				timer += Time.deltaTime;
				if (timer > 2) {
					if (guiStyleNewHighScore.fontSize == Screen.width / 10) {
						guiStyleNewHighScore.fontSize = -4;
						timer = 0;
					}
				}
				if (timer > 1.5){
					if (guiStyleNewHighScore.fontSize == -4) {
						guiStyleNewHighScore.fontSize = Screen.width / 10;
						timer = 0;
					}
				
					
						

					
			}

			

}
}

}
	}



	

