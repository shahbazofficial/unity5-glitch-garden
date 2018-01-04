using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
	public AudioClip[] levelMusicArray;

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
		SceneManager.sceneLoaded += OnLevelLoaded;
	}
	private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
	{
		if (levelMusicArray[scene.buildIndex])
		{
			GetComponent<AudioSource>().clip = levelMusicArray[scene.buildIndex];
			GetComponent<AudioSource>().loop = true;
			GetComponent<AudioSource>().Play();
		}
	}
}
