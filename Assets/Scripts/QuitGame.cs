﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
	private void Awake()
	{
		GetComponent<Button>().onClick.AddListener(delegate { LevelManager.QuitGame(); });
	}
}
