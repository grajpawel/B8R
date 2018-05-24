using UnityEngine;
using System.Collections;

public class BgScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


			if (PlayerPrefs.GetInt ("Mode") == 1 || PlayerPrefs.GetInt ("Mode") == 3) {
		
		 Color[] colors = new Color[6];
     
  
         colors[0] = new Color32(0, 210, 255, 255);
		 colors[1] = new Color32(0, 180, 255, 255);
		 colors[2] = new Color32(0, 202, 245, 255);
		 colors[3] = new Color32(0, 127, 255, 255);
		 colors[4] = new Color32(0, 162, 255, 255);
		 colors[5] = new Color32(52, 162, 255, 255);
         
		 
		 gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, 6)];
	
			} else {
				gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 255);
			}
		}

	
	// Update is called once per frame
	void Update () {
	
	}
}
