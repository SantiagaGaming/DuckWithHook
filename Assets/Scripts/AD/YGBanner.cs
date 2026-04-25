using UnityEngine;
using YG;

public class YGBanner : MonoBehaviour
{
	private void Start()
	{
		YG2.GameReadyAPI();
		YG2.StickyAdActivity(true);
	}
}
