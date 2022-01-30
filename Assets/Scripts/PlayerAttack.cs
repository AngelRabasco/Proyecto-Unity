using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

	public Transform firePoint;
	public GameObject arrowPrefab;
	public float arrowForce = 20f;

	public Animator anim;

	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
	}

	void Shoot()
	{
		GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
		Rigidbody2D rigidBody2D = arrow.GetComponent<Rigidbody2D>();
		rigidBody2D.AddForce(firePoint.up * arrowForce, ForceMode2D.Impulse);

		anim.SetTrigger("Attack");
	}
}
