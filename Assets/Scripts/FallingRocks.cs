using UnityEngine;
using System.Collections;

public class FallingRocks : MonoBehaviour {

	Transform tr;
	float speed;

	// Use this for initialization
	void Start () 
	{
		tr = GetComponent<Transform> ();
		speed = Random.Range(-.005f, -.022f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		tr.Translate(new Vector2(0, speed));
	}
}
