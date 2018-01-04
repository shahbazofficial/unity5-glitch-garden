using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public static void LoadLevelStatic (string name)
	{
		SceneManager.LoadScene(name);
	}
	public void LoadLevel (string name)
	{
		LoadLevelStatic(name);
	}
	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void QuitGame ()
	{
		Application.Quit();
	}
}
