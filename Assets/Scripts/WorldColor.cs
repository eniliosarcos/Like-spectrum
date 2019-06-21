using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldColor : MonoBehaviour
{
	Renderer[] rend;

	private void Awake()
	{
		rend = GetComponentsInChildren<Renderer>();
	}

	// Use this for initialization
	public void ObjectWorldChangeColor(Color ChangeWorldTocolor)
	{
		foreach (var item in rend)
		{
			item.material.color = ChangeWorldTocolor;
		}
	}
}
