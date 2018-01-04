using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	public static bool exist = false;
	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
		if (exist)
			Destroy(gameObject);
		else
			exist = true;
	}	
}
