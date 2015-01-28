using UnityEngine;
using System.Collections;

public class SnailMovement : MonoBehaviour
{
	public bool canMove = true;

	public Animator a;
	public float maxTimeBetweenPresses;
	private bool isWalking;
	private float hasBeenWalking;
	private bool isWalkingBack;
	private float hasBeenWalkingBack;

	public string forwardKey1;
	public string forwardKey2;
	public string backwardKey1;
	public string backwardKey2;

	public float forwardSpeed;
	public float backwardSpeed;
	
	void Start () 
	{
		a = GetComponent<Animator> ();
		maxTimeBetweenPresses = .1666f;
		hasBeenWalking = 0f;
		hasBeenWalkingBack = 0f;
		isWalking = false;
		isWalkingBack = false;
	}
	void Update () 
	{
		if(canMove)
		{
			if(Input.GetKeyUp(forwardKey1))
			{
				a.SetBool("IsWalking", true);
				isWalking = true;
				hasBeenWalking = 0f;
				transform.Translate(forwardSpeed,0f,0f);
			}
			else if(Input.GetKeyUp(forwardKey2))
			{
				a.SetBool("IsWalking", true);
				isWalking = true;
				hasBeenWalking = 0f;
				transform.Translate(forwardSpeed,0f,0f);
			}
			else if(Input.GetKeyUp(backwardKey1))
			{
				a.SetBool("IsWalkingBack", true);
				isWalkingBack = true;
				hasBeenWalkingBack = 0f;
				transform.Translate(-backwardSpeed,0f,0f);
			}
			else if(Input.GetKeyUp(backwardKey2))
			{
				a.SetBool("IsWalkingBack", true);
				isWalkingBack = true;
				hasBeenWalkingBack = 0f;
				transform.Translate(-backwardSpeed,0f,0f);
			}
			else
			{
				if(isWalking)
				{
					hasBeenWalking += Time.deltaTime;
					if(hasBeenWalking > maxTimeBetweenPresses)
					{
						a.SetBool("IsWalking", false);
						isWalking = false;
					}
				}
				if(isWalkingBack)
				{
					hasBeenWalkingBack += Time.deltaTime;
					if(hasBeenWalkingBack > maxTimeBetweenPresses)
					{
						a.SetBool("IsWalkingBack", false);
						isWalkingBack = false;
					}
				}
			}
		}
	}
}
