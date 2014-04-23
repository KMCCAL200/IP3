using UnityEngine;
using System.Collections;

//Main script for second part of levels(finding object)

public class Part2 : MonoBehaviour {

	public AudioClip otherClip;
	public bool startLooking;
	public MapMove SelectorMove;
	// Use this for initialization
	void Start () {

		if(Application.loadedLevelName == "Level2.2"){PlayerPrefs.SetInt ("Hiker",  1);}
		if(Application.loadedLevelName == "Level3.2"){PlayerPrefs.SetInt ("Nessie", 1);}
		if(Application.loadedLevelName == "Level4.2"){PlayerPrefs.SetInt ("Deero",  1);}
		if(Application.loadedLevelName == "Level5.2"){PlayerPrefs.SetInt ("Ghost",  1);}
		if(Application.loadedLevelName == "Level6.2"){PlayerPrefs.SetInt ("Busker", 1);}
		audio.clip = otherClip;
		audio.Play ();
		startLooking = false;
	}
	
	// Update is called once per frame
	void Update () {
		Dialog();
		GetClue();
	}

	void GetClue(){
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if (Physics.Raycast(ray, out hit))
			{
				if(hit.transform.name == "Right")
				{
					SelectorMove.GoTo();
					startLooking = true;
				}
				if(hit.transform.name == "WrongH") 
				{PlayerPrefs.SetInt ("Hiker", 2);}
				
				if(hit.transform.name == "WrongN") 
				{PlayerPrefs.SetInt ("Nessie", 2);}
				
				if(hit.transform.name == "WrongD") 
				{PlayerPrefs.SetInt ("Deero", 2);}
				
				if(hit.transform.name == "WrongG") 
				{PlayerPrefs.SetInt ("Ghost", 2);}
				
				if(hit.transform.name == "WrongB") 
				{PlayerPrefs.SetInt ("Busker", 2);}
				
				if (startLooking == true)
				{
					if (hit.transform.name == "GoTo2.3") {
						Application.LoadLevel ("Level2.3");}
					
					if (hit.transform.name == "GoTo3.3") {
						Application.LoadLevel ("Level3.3");}
					
					if (hit.transform.name == "GoTo4.3") {
						Application.LoadLevel ("Level4.3");}
					
					if (hit.transform.name == "GoTo5.3") {
						Application.LoadLevel ("Level5.3");}
				}
			}
		}
	}

	void Dialog()
	{
		if (!audio.isPlaying) 
		{
			if (Input.GetMouseButtonDown (0)) { // if left button pressed...
				Ray ray = camera.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				
				if (Physics.Raycast (ray, out hit)) 
				{					
					if (hit.transform.name == "Replay") 
					{
						audio.clip = otherClip;
						audio.Play ();
					}
				}
			}
		}
	}
}