using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
	public int sceneNumber;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			SceneManager.LoadScene(sceneNumber);
		}
	}
}
