using UnityEngine;
using System.Collections;

public class GenerateRock : MonoBehaviour {
    public GameObject Rock;
    public float FallingFrequency = 2f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateARock", 0f, FallingFrequency);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void GenerateARock() {
        Instantiate(Rock);
    }
}
