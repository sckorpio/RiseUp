using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
	public Rigidbody2D DOT;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 player_touch_pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		DOT.position = player_touch_pos;
	}
}
