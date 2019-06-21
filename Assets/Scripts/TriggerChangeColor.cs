using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangeColor : MonoBehaviour
{
	public Color WorldPreviousColor;
	public Color ParticlePreviousColor;

	public Color ChangeWorldTocolor;
	public Color ChangeParticleTocolor;

	Color WorldAuxPreviousColor,ParticleAuxPreviousColor;

	ColorManageScript colormanage;

	private void Awake()
	{
		colormanage = GameObject.Find("ColorManage").GetComponent<ColorManageScript>();
	}


	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			colormanage.PlayFadeAnimationToColor();

			colormanage.WorldColor.ObjectWorldChangeColor(ChangeWorldTocolor);
			WorldAuxPreviousColor = WorldPreviousColor;
			WorldPreviousColor = ChangeWorldTocolor;
			ChangeWorldTocolor = WorldAuxPreviousColor;

			colormanage.ParticleColor.ParticleWorldChangeColor(ChangeParticleTocolor);
			ParticleAuxPreviousColor = ParticlePreviousColor;
			ParticlePreviousColor = ChangeParticleTocolor;
			ChangeParticleTocolor = ParticleAuxPreviousColor;
		}
	}
}
