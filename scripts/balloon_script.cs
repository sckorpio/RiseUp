using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon_script : MonoBehaviour 
{
	public manager_script MANAGER;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "DANGER") 
		{
			Debug.Log ("Ballon Burst-- You Loose!!!");
			MANAGER.Lost_Game ();
		}
	}
}
