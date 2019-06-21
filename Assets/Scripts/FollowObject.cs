using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {

	public GameObject obj;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(obj.transform.position.x + offset.x, obj.transform.position.y + offset.y, obj.transform.position.z + offset.z);
	}
}
