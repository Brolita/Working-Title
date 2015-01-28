using UnityEngine;
using System.Collections;

public class ARock : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(Random.Range(-3.5f, 3.5f), 2.75f, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
