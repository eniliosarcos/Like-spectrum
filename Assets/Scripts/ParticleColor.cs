using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColor : MonoBehaviour
{
	ParticleSystem WorldParticle;
	// Use this for initialization
	void Awake()
	{
		WorldParticle = GetComponent<ParticleSystem>();
	}

	public void ParticleWorldChangeColor(Color ChangeParticleTocolor)
	{
		WorldParticle.Stop();
		WorldParticle.startColor = ChangeParticleTocolor;
		WorldParticle.Play();
	}
}
