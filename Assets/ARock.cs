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
        if (currentTime > 20)
        {
            System.Random rnd = new System.Random();
            int index = rnd.Next(0, 2);
            gameObject.GetComponent<SpriteRenderer>().sprite = SpriteSetA[index];
        }
        else
        {
            System.Random rnd = new System.Random();
            int index = rnd.Next(0, 20);
            if (index == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = SpriteRock;
            }
            else
            {
                if (currentTime > 10)
                {
                    rnd = new System.Random();
                    index = rnd.Next(0, 4);
                    gameObject.GetComponent<SpriteRenderer>().sprite = SpriteSetB[index];
                }
                else
                {
                    rnd = new System.Random();
                    index = rnd.Next(0, 7);
                    gameObject.GetComponent<SpriteRenderer>().sprite = SpriteSetC[index];
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {

	}
}
