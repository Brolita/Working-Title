using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {
	
	public float t;
	public Text text;
	public float timerStart;
	
	public GameObject nuke;
	public Vector2 nukeStartPos;
	public Vector2 nukeEndPos;
	
	public GameObject NukeSymbol;
	
	// Use this for initialization
	void Start () {
		t = timerStart;
	}
	
	// Update is called once per frame
	void Update () {
		t -= Time.deltaTime;
		
		if (t <= 0f) {
			Application.OpenURL ("http://www.youtube.com/watch?v=rymKmdYmsv0" );
			Application.Quit();
			this.enabled = false;
		}

		if (t <= 10f) {
			NukeSymbol.SetActive(true);
		}

		
		text.text = (Mathf.Round (t * 10f) / 10f).ToString();
		if (Mathf.Round (t) == Mathf.Round (t * 10f) / 10f) {
			text.text = (text.text.ToString() + ".0");
		}
		
		nuke.transform.position = Vector2.Lerp(nukeEndPos, nukeStartPos, t / 30f);
	}
}