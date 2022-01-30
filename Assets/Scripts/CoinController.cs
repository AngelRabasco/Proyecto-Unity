using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
	[SerializeField]
	private AudioSource SFX;

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag.Equals("Player"))
		{
			SFX.Play();
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
			gameObject.GetComponent<Collider2D>().enabled=false;
			//Destroy(gameObject);
		}

	}

}
