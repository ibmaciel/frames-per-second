using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour 
{

	public void StartGame(int index)
	{
		SceneManager.LoadScene(index);
	}

	public void RestartGame(int index)
	{
		SceneManager.LoadScene(index);
	}
}
