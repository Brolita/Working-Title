using UnityEngine;
using System.Collections;

public class FallingRocks : MonoBehaviour {

	Transform tr;

	// Use this for initialization
	void Start () 
	{
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		tr.Translate(new Vector2(0, -.001f));
	}
}
