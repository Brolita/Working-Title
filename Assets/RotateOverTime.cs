using UnityEngine;
using System.Collections;

public class RotateOverTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0.0f,0.0f,5.0f);
	}
}
