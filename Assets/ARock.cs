using UnityEngine;
using System.Collections;

public class ARock : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(Random.Range(-3, 3), transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
