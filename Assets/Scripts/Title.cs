using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q) && Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.O) && Input.GetKey (KeyCode.P))
		{				
			Application.LoadLevel ("QWOP");
		}
	}
}
