﻿using UnityEngine;
using System.Collections;

public class CharMove : MonoBehaviour {

	public	float	speed = 10.0f;

	public	Vector3	testDirection	= new Vector3 (1.0f, 0.0f, 0.0f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.MovePosition (testDirection);
	}
}
