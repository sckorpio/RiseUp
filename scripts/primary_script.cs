﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primary_script : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (this.transform.position.y <= -10.0f) 
		{
			Debug.Log ("Destroyed");
			Destroy (this);
		}
	}
}
