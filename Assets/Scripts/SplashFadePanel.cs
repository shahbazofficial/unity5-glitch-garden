using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashFadePanel : MonoBehaviour
{
	public enum FadeMode { NoFade, FadeInOnly, FadeOutOnly, FadeInAndOut };
	public FadeMode fadeMode;

	[SerializeField]
	private float fadeInTime;
	[SerializeField]
	private float waitTime;
	[SerializeField]
	private float fadeOutTime;
	[SerializeField]
	private string loadLevel;

	private IEnumerator Start()
	{
		if (fadeMode == FadeMode.FadeInOnly || fadeMode == FadeMode.FadeInAndOut)
		{
			Initialize();
			FadeIn();
		}
		yield return new WaitForSeconds(fadeInTime + waitTime);
		if (fadeMode == FadeMode.FadeOutOnly || fadeMode == FadeMode.FadeInAndOut)
			FadeOut();
		yield return new WaitForSeconds(fadeOutTime);
		LevelManager.LoadLevelStatic(loadLevel);
	}
	void Initialize()
	{
		GetComponent<Image>().canvasRenderer.SetAlpha(1.0f);
	}
	void FadeIn()
	{
		GetComponent<Image>().CrossFadeAlpha(0.0f, fadeInTime, false);
	}
	void FadeOut()
	{
		GetComponent<Image>().CrossFadeAlpha(1.0f, fadeInTime, false);
	}
}
