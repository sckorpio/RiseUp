using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager_script : MonoBehaviour 
{

	public GameObject[] obsticles;
	public float start_time;
	public float level_time;
	public float delay_time;
	public GameObject DOT;
	public GameObject METER;
	public Text LABEL;
	public Text SCORE;

	public GameObject CONSOLE;

	public int level;

	// Use this for initialization
	void Start () 
	{
		CONSOLE.SetActive (true);	
		METER.SetActive (false);
		DOT.SetActive (false);
	}

	// Update is called once per frame
	void Update () 
	{
		
	}

	public void On_Click_Play()
	{
		CONSOLE.SetActive (false);
		New_Game();
	}

	public void On_Click_Exit()
	{
		//TODO: Exit
		Debug.Log("Exit!!!");
	}

	public void New_Game()
	{
		METER.SetActive (true);
		DOT.SetActive (true);
		level = 0;
		LABEL.color = Color.cyan;
		SCORE.color = Color.cyan;
		LABEL.text = "READY!!! ";
		SCORE.text = " ";

		InvokeRepeating ("ready_new_level", start_time, level_time);	
	}

	public void Lost_Game()
	{
		CancelInvoke ();
		LABEL.text = "LOST ";
		LABEL.color = Color.red;
		SCORE.color = Color.red;
		METER.SetActive (true);
		DOT.SetActive (false);

		//TODO: GoodleAdMob then..Ask to replay call the UI
		CONSOLE.SetActive (true);	
	}

	public void Finish_Game()
	{
		CancelInvoke ();
		LABEL.text = "FINISH ";
		LABEL.color = Color.green;
		METER.SetActive (true);
		DOT.SetActive (false);
		//TODO: GoodleAdMob then..Ask to replay call the UI
		CONSOLE.SetActive (true);
	}

	IEnumerator my_delay()
	{
		METER.SetActive (true);
	
		yield return new WaitForSeconds(delay_time);

		METER.SetActive (false);
		generate_obsticle (level);
	}

	void ready_new_level()
	{
		LABEL.text = "LEVEL";
		level++;

		if (level > 10)
			Finish_Game ();
		else
		{
			SCORE.text = level.ToString ();
			StartCoroutine (my_delay ());
		}

	}

	void generate_obsticle(int x)
	{
		Instantiate (obsticles [x-1], transform.position, transform.rotation);
	}


}
