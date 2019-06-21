using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawlerBehavior : MonoBehaviour
{
	public float speed;
	public float RayDistanceFrontal,RayDistancePatas;
	public Transform childobj,childobj2;
	[HideInInspector] public bool deteccionTrasera = true,
		deteccionDelantera = true,
		deteccionFrontal = false;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(0, 0, speed * Time.deltaTime);

		RaycastHit hit;
		if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit, RayDistanceFrontal))
		{
			if (hit.collider && !deteccionFrontal)
				deteccionFrontal = true;
		}
		else
		{
			if(deteccionFrontal)
				deteccionFrontal = false;
		}
		if (Physics.Raycast(childobj.position, transform.TransformDirection(Vector3.down), out hit, RayDistancePatas))
		{
			if(hit.collider && !deteccionTrasera)
				deteccionTrasera = true;
		}
		else
		{
			if(deteccionTrasera)
			deteccionTrasera = false;
		}
		if (Physics.Raycast(childobj2.position, transform.TransformDirection(Vector3.down), out hit, RayDistancePatas))
		{
			if (hit.collider && !deteccionDelantera)
				deteccionDelantera = true;	
		}
		else
		{
			if(deteccionDelantera)
			deteccionDelantera = false;
		}


		if(deteccionFrontal && deteccionDelantera && deteccionTrasera)
		{
			transform.Rotate(-90, 0, 0);
		}

		if (!deteccionTrasera && !deteccionDelantera && !deteccionFrontal)
		{
			transform.Rotate(90, 0, 0);
		}
	}

	private void OnDrawGizmosSelected()
	{
		RaycastDetectionMethod();
	}

	private void RaycastDetectionMethod()
	{
		Debug.DrawRay(childobj.position, transform.TransformDirection(Vector3.down) * RayDistancePatas, Color.cyan);
		Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * RayDistanceFrontal, Color.cyan);
		Debug.DrawRay(childobj2.position, transform.TransformDirection(Vector3.down) * RayDistancePatas, Color.cyan);
	}
}
