using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFadePanel : MonoBehaviour
{
	[SerializeField]
	private float fadeInTime;
	private IEnumerator Start()
	{
		GetComponent<Image>().CrossFadeAlpha(0.0f, fadeInTime, false);
		yield return new WaitForSeconds(fadeInTime);
		gameObject.SetActive(false);
	}
}
