using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManageScript : MonoBehaviour
{
	public ParticleColor ParticleColor;
	public WorldColor WorldColor;

	public Color WorldColorPlaying;
	public Color ParticleColorPlaying;

	public Animator ImageFade;

	public void PlayFadeAnimationToColor()
	{
		ImageFade.Play("Fade", 0, 0f);
	}
}
