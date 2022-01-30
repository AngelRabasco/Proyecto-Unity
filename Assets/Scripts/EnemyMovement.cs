using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

	[SerializeField]
	Transform[] waypoints;

	[SerializeField]
	float moveSpeed = 2f;

	int waypointIndex = 0;

	[SerializeField]
	Animator animator;
	void Start()
	{

		animator.SetFloat("Speed", 1);
		transform.position = waypoints[waypointIndex].transform.position;
	}

	void FixedUpdate()
	{
		Move();
	}

	void Move()
	{
		transform.position = Vector2.MoveTowards(transform.position,
												waypoints[waypointIndex].transform.position,
												moveSpeed * Time.deltaTime);

		if (waypoints[waypointIndex].transform.position.x == transform.position.x)
		{
			animator.SetFloat("Vertical", waypoints[waypointIndex].transform.position.y > transform.position.y ? 1 : -1);
			animator.SetFloat("Horizontal", 0);
		}
		else
		{
			animator.SetFloat("Horizontal", waypoints[waypointIndex].transform.position.x > transform.position.x ? 1 : -1);
			animator.SetFloat("Vertical", 0);
		}

		if (transform.position == waypoints[waypointIndex].transform.position)
		{
			waypointIndex += 1;
		}

		if (waypointIndex == waypoints.Length)
			waypointIndex = 0;
	}

}
