using UnityEngine;
using System.Collections;

public class ARock : MonoBehaviour {
    public Sprite[] SpriteSetA = new Sprite[2];
    public Sprite[] SpriteSetB = new Sprite[4];
    public Sprite[] SpriteSetC = new Sprite[7];
    public Sprite SpriteRock;

	// Use this for initialization
	void Start () {
        float currentTime = GameObject.Find("GameState").GetComponent<GameState>().t;
        transform.position = new Vector3(Random.Range(-3.5f, 3.5f), 2.75f, transform.position.z);
        
	}
	
	// Update is called once per frame
	void Update () {

	}
}
