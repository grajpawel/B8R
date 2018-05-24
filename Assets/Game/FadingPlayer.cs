using UnityEngine;

public class FadingPlayer : MonoBehaviour
{
	public float Speed = 1;
	private Renderer rend;

	void Start()
	{
		rend = GetComponent<Renderer>();
	}

	void Update()
	{
		if (PlayerPrefs.GetInt ("FishEq") == 6) {
		rend.material.SetColor("_Color", HSBColor.ToColor(new HSBColor( Mathf.PingPong(Time.time * Speed, 1), 1, 1)));
	}
}
}