using UnityEngine;
using System.Collections;

public class FlashOnScreen : MonoBehaviour {

	bool countDown;
	float timer;
	public SpriteRenderer s;

	void Start() {
		countDown = true;
		timer = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (countDown)
			timer -= Time.deltaTime;
		else if (!countDown)
			timer += Time.deltaTime;

		if (timer <= 0)
			countDown = false;
		else if (timer >= 0.5f)
			countDown = true;

		s.color = new Color(1f,1f,1f, timer * 0.75f);
	}
}
