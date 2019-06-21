using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float X_Speed = 12;
	public float Jump_Speed = 5;
	public float Dive_Speed = 7;

	[Header("Debug")]
	public float InputZ;
	public Vector3 velocity;
	public bool JumpPressed;
	public bool DivePressed;

	Rigidbody _rb;

	// Use this for initialization
	void Start()
	{
		_rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	private void Update()
	{
		InputZ = Input.GetAxis("Horizontal");
		JumpPressed = Input.GetKeyDown("joystick button 0");
		DivePressed = Input.GetKeyDown("joystick button 1");

		if (_rb.velocity.y > Jump_Speed)
			_rb.velocity = new Vector3(0, Jump_Speed, _rb.velocity.z);

		if (_rb.velocity.y < -Dive_Speed)
			_rb.velocity = new Vector3(0, -Dive_Speed, _rb.velocity.z);
	}

	private void FixedUpdate()
	{
		Movement();
		Jump();
		Dive();
		velocity = _rb.velocity;
	}

	private void Movement()
	{
		_rb.velocity = new Vector3(0, _rb.velocity.y, X_Speed * InputZ);
	}

	private void Jump()
	{
		if (JumpPressed)
		{	
			//_rb.velocity = new Vector3(0, 0,_rb.velocity.z);
			_rb.velocity = new Vector3(0, Jump_Speed, _rb.velocity.z);
		}
	}

	private void Dive()
	{
		if(DivePressed)
		{
			//_rb.velocity = new Vector3(0, 0, _rb.velocity.z);
			_rb.velocity = new Vector3(0, -Dive_Speed, _rb.velocity.z);
		}
	}
}
