using UnityEngine;
using YG;
public static class CorrectLang
{
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		YG2.onCorrectLang += OnСhangeLang;
	}

	public static void OnСhangeLang(string lang)
	{
		YG2.lang = "ru";
	}
}