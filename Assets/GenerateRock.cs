using UnityEngine;
using System.Collections;

public class GenerateRock : MonoBehaviour {
    public GameObject Rock;
    public float FallingFrequency = 2f;
	public GameObject[] Set1;
	public GameObject[] Set2;
	public GameObject[] Set3;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateARock", 0f, FallingFrequency);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void GenerateARock() {
		float currentTime = GameObject.Find("GameState").GetComponent<GameState>().t;
		if (currentTime < 20)
		{
			System.Random rnd = new System.Random();
			int index = rnd.Next(0, Set1.Length);
			Instantiate(Set1[index]);
		}
		else if(currentTime < 40)
		{
			System.Random rnd = new System.Random();
			int index = rnd.Next(0, Set2.Length);
			Instantiate(Set2[index]);
		}
		else
		{
			System.Random rnd = new System.Random();
			int index = rnd.Next(0, Set3.Length);
			Instantiate(Set3[index]);
		}
	}
}
