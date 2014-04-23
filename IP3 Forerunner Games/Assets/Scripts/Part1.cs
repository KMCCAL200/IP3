using UnityEngine;
using System.Collections;

//Main script for first part of levels(meeting character)

public class Part1 : MonoBehaviour {
	public MapMove MapMove;
	public MapMove JournalMove;
	public AudioClip otherClip;
	public GameObject M1;
	public GameObject M2;
	public GameObject J1;
	public GameObject J2;
	public GameObject N1;
	public GameObject N2;
	int showButtons;
	// Use this for initialization
	void Start () {
		showButtons=0;
		audio.clip = otherClip;
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		Dialog ();
		ChangeLevel ();
		Map ();
	}

	void ChangeLevel ()
	{
		
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel ("Main Menu");
		}
		
		if (Input.GetMouseButtonDown (0)) { // if left button pressed...
			Ray ray = camera.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast (ray, out hit))
			{
				if (hit.transform.name == "GoTo2.2") {
					Application.LoadLevel ("Level2.2");
				}
				if (hit.transform.name == "GoTo3.2") {
					Application.LoadLevel ("Level3.2");
				}
				if (hit.transform.name == "GoTo4.2") {
					Application.LoadLevel ("Level4.2");
				}
				if (hit.transform.name == "GoTo5.2") {
					Application.LoadLevel ("Level5.2");
				}
				
				if (hit.transform.name == "GoTo7.3Correct") {
					Application.LoadLevel ("Level7.3");
				}
				if (hit.transform.name == "GoTo7.3Wrong") {
					Application.LoadLevel ("Level7.4");
				}
			}
		}
	}

	void Map () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast(ray, out hit))
			{
				if(hit.transform.name == "HideJournal") 
				{
					JournalMove.GoBack();
				}
				if(hit.transform.name == "ShowJournal") 
				{
					JournalMove.GoTo();
				}
				if(hit.transform.name == "HideMap") 
				{
					MapMove.GoBack();
				}
				if(hit.transform.name == "ShowMap") 
				{
					MapMove.GoTo();
				}
			}
		}
	}

	void Dialog ()
	{
		if (!audio.isPlaying) {
			if(showButtons < 2)
			{
				showButtons++;
				M1.renderer.enabled = true;
				M2.renderer.enabled = true;
				J1.renderer.enabled = true;
				J2.renderer.enabled = true;
				N1.renderer.enabled = true;
				N2.renderer.enabled = true;
			}			
			if (Input.GetMouseButtonDown (0)) { // if left button pressed...
				Ray ray = camera.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				
				if (Physics.Raycast (ray, out hit)) {
					
					if (hit.transform.name == "Replay") {
						showButtons=0;
						audio.clip = otherClip;
						audio.Play ();
					}
				}
			}
		}
		else
		{
			M1.renderer.enabled = false;
			M2.renderer.enabled = false;
			J1.renderer.enabled = false;
			J2.renderer.enabled = false;
			N1.renderer.enabled = false;
			N2.renderer.enabled = false;
		}
	}
}