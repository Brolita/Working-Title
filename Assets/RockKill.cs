using UnityEngine;
using System.Collections;

public class RockKill : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			other.GetComponent<Death>().HandleDeath();
			Destroy(gameObject);
		}
	}
}
