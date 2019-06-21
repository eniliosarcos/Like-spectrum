using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFieldOfView : MonoBehaviour
{
	public int lines = 18;
	public int betweenAngles = 20;
	public float distance = 2.38f;


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		RaycastDetectionMethod();
	}

	private void RaycastDetectionMethod()
	{
		RaycastHit hit;
		Quaternion stepAngle = Quaternion.AngleAxis(betweenAngles, Vector3.left);
		var angle = transform.rotation * stepAngle;
		var direction = angle * Vector3.left;
		for (int i = 0; i < lines; i++)
		{
			if (Physics.Raycast(transform.position, direction, out hit, distance))
			{
				float distance = hit.distance;
				if (hit.collider.tag == "obstacles")
				{	
					Debug.DrawRay(transform.position, direction * distance, Color.red);
				}
				else
				{
					Debug.DrawRay(transform.position, direction * distance, Color.cyan);
				}

			}
			else
			{
				Debug.DrawRay(transform.position, direction * distance, Color.cyan);
			}

			direction = stepAngle * direction;
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (Application.isPlaying)
			return;

		RaycastDetectionMethod();
	}
}
