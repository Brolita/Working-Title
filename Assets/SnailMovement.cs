using UnityEngine;
using System.Collections;

public class SnailMovement : MonoBehaviour
{
	public bool canMove = true;

	public string forwardKey1;
	public string forwardKey2;
	public string backwardKey1;
	public string backwardKey2;

	public float forwardSpeed;
	public float backwardSpeed;
	
	void Start () 
	{
	
	}
	void Update () 
	{
		if(canMove)
		{
			if(Input.GetKeyUp(forwardKey1))
			{
				transform.Translate(forwardSpeed,0f,0f);
			}
			else if(Input.GetKeyUp(backwardKey1))
			{
				transform.Translate(-backwardSpeed,0f,0f);
			}
		}
	}
}
