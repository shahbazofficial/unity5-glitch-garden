﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
	private void Awake()
	{
		GetComponent<Button>().onClick.AddListener(delegate { LevelManager.LoadLevel("Game"); });
	}
}
