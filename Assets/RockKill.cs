using UnityEngine;
using System.Collections;

public class RockKill : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			other.GetComponent<Death>().HandelDeath();
			Destroy(gameObject);
		}
	}
}
