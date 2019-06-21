using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollowPlayer : MonoBehaviour
{
	public GameObject objectToFollow;
	public Vector3 offSet;

	public float speed = 2.0f;

	// Use this for initialization
	void Start()
	{

	}

	void LateUpdate()
	{
		float interpolation = speed * Time.deltaTime;

		Vector3 position = this.transform.position;

		position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y + offSet.y, interpolation);
		position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x + offSet.x, interpolation);
		position.z = Mathf.Lerp(this.transform.position.z, objectToFollow.transform.position.z + offSet.z, interpolation);

		this.transform.position = position;
	}
}

