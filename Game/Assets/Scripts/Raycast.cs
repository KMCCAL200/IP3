using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

	public AudioClip Dialog;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape))
			Application.LoadLevel("Main Menu");
		ChangeLevel();
	}

	void ChangeLevel()
	{
		if (Input.GetMouseButtonDown(0))
		{ // if left button pressed...
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				if(hit.transform.name == "GoTo1") 
				{
					Application.LoadLevel("Level1");
				}
				if(hit.transform.name == "GoTo2") 
				{
					Application.LoadLevel("Level2");
				}
				if(hit.transform.name == "GoTo2.5") 
				{
					Application.LoadLevel("Level2.5");
				}
				if(hit.transform.name == "GoTo3") 
				{
					Application.LoadLevel("Main Menu");
				}
				if(hit.transform.name == "Replay") 
				{
					audio.PlayOneShot (Dialog);
					Debug.Log("fcjmijgfio");
				}
			}
		}
	}
}
