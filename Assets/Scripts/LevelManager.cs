﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public static void LoadLevel (string name)
	{
		SceneManager.LoadScene(name);
	}
	public static void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public static void QuitGame ()
	{
		Application.Quit();
	}
}
