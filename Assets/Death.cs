using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	
	public float deathTime;
	public float pushBackPerTick;
	private float timeRemaining;
	private bool dying;
	// Use this for initialization
	void Start () {
		dying = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (dying)
		{
			if (timeRemaining > 0)
			{
				transform.Translate(-0.1f,0.0f,0.0f);
				timeRemaining -= 1;
			}
			else
			{
				dying = false;
				SnailMovement snailMovement = GetComponent<SnailMovement>();
				snailMovement.canMove = true;
				
			}
		}
	}
	
	public void HandleDeath()
	{
		dying = true;
		timeRemaining = deathTime;
		SnailMovement snailMovement = GetComponent<SnailMovement>();
		snailMovement.canMove = false;
		transform.Translate(-1.0f,0.0f,0.0f);
		Debug.Log("hi");
	}
	
	
	
}
