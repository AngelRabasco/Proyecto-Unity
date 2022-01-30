using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag != "Player")
		{
			if (collision.gameObject.tag == "Enemy")
			{
				collision.GetComponent<EnemyController>().Perish();
			}
			Destroy(gameObject);
		}

	}

}
