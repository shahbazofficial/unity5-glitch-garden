using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SplashFade : MonoBehaviour
{
	public enum FadeMode { NoFade, FadeInOnly, FadeOutOnly, FadeInAndOut };

	public Image backgroundImage;
	public Text titleText;
	public FadeMode fadeMode;

	[SerializeField]
	private float fadeInTime;
	[SerializeField]
	private float waitTime;
	[SerializeField]
	private float fadeOutTime;
	[SerializeField]
	private string loadLevel;

	IEnumerator Start()
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
		LevelManager.LoadLevel(loadLevel);
	}
	void Initialize()
	{
		backgroundImage.canvasRenderer.SetAlpha(0.0f);
		titleText.canvasRenderer.SetAlpha(0.0f);
	}
	void FadeIn()
	{
		backgroundImage.CrossFadeAlpha(1.0f, fadeInTime, false);
		titleText.CrossFadeAlpha(1.0f, fadeInTime, false);
	}
	void FadeOut()
	{
		backgroundImage.CrossFadeAlpha(0.0f, fadeOutTime, false);
		titleText.CrossFadeAlpha(0.0f, fadeOutTime, false);
	}
}
