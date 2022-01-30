using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody2D rigidBody2D;
	public Transform firePoint;
	public Animator animator;

	public Vector2 movement;

	public float moveSpeed = 5f;

	void Update()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
		movement = movement.normalized;

		if (movement != Vector2.zero)
		{
			if (movement.y == 0)
			{
				if (movement.x < -0.7)
				{
					firePoint.transform.SetPositionAndRotation(new Vector3(rigidBody2D.position.x - 0.42f, rigidBody2D.position.y - 0.42f, 0f), Quaternion.Euler(new Vector3(0, 0, 90)));
				}
				else
				{
					firePoint.transform.SetPositionAndRotation(new Vector3(rigidBody2D.position.x + 0.42f, rigidBody2D.position.y - 0.42f, 0f), Quaternion.Euler(new Vector3(0, 0, -90)));
				}
			}
			else if (movement.y < -0.7)
			{
				firePoint.transform.SetPositionAndRotation(new Vector3(rigidBody2D.position.x, rigidBody2D.position.y - 0.59f, 0f), Quaternion.Euler(new Vector3(0, 0, 180)));
			}
			else
			{
				firePoint.transform.SetPositionAndRotation(new Vector3(rigidBody2D.position.x, rigidBody2D.position.y + 0.4f, 00f), Quaternion.Euler(new Vector3(0, 0, 0)));
			}

			animator.SetFloat("Horizontal", movement.x);
			animator.SetFloat("Vertical", movement.y);
		}
		animator.SetFloat("Speed", movement.sqrMagnitude);
	}

	void FixedUpdate()
	{
		rigidBody2D.MovePosition(rigidBody2D.position + movement * moveSpeed * Time.fixedDeltaTime);
	}
}
