using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject player;
	public GameObject gameOverScreen;

	public void EndGame()
	{
		player.SetActive(false);
		gameOverScreen.SetActive(true);
	}

	public void Restart()
	{
		SceneManager.LoadScene(0);
	}
}
