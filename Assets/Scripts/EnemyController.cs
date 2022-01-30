using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
	public GameObject coin;
	public CapsuleCollider2D enemyCollider;
	public Animator animator;

	public void Perish()
	{
		this.GetComponent<EnemyMovement>().enabled = false;
		enemyCollider.enabled = false;
		Instantiate(coin, transform.position, Quaternion.identity);
		animator.SetTrigger("Perish");
	}


}
