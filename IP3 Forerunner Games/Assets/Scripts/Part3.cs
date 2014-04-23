using UnityEngine;
using System.Collections;

//Main script for third part of levels(getting clue for finale)

public class Part3 : MonoBehaviour
{
		public MapMove MapMove;
		public MapMove JournalMove;
		public bool clue = false;
		public AudioClip correct;
		public AudioClip incorrect;
		public GameObject M1;
		public GameObject M2;
		public GameObject J1;
		public GameObject J2;
		int showButtons;
	 
		// Use this for initialization
		void Start ()
		{
				showButtons = 0;

				if (Application.loadedLevelName == "Level2.3" && PlayerPrefs.GetInt ("Hiker") == 1) {
						clue = true;
				}
				if (Application.loadedLevelName == "Level3.3" && PlayerPrefs.GetInt ("Nessie") == 1) {
						clue = true;
				}
				if (Application.loadedLevelName == "Level4.3" && PlayerPrefs.GetInt ("Deero") == 1) {
						clue = true;
				}
				if (Application.loadedLevelName == "Level5.3" && PlayerPrefs.GetInt ("Ghost") == 1) {
						clue = true;
				}
				if (Application.loadedLevelName == "Level6.3" && PlayerPrefs.GetInt ("Busker") == 1) {
						clue = true;
				}
				if (Application.loadedLevelName == "Level7.3") {
						clue = true;
				}

				if (clue == true) {
						audio.clip = correct;
				} else {
						audio.clip = incorrect;
				}

				audio.Play ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				Dialog ();
				ChangeLevel ();
		}

		void ChangeLevel ()
		{		
				if (Input.GetKey (KeyCode.Escape)) {
						Application.LoadLevel ("Main Menu");
				}
		
				if (Input.GetMouseButtonDown (0)) { // if left button pressed...
						Ray ray = camera.ScreenPointToRay (Input.mousePosition);
						RaycastHit hit;
			
						if (Physics.Raycast (ray, out hit)) {
								if (hit.transform.name == "GoTo2.1") {
										Application.LoadLevel ("Level2.1");
								}
								if (hit.transform.name == "GoTo3.1") {
										Application.LoadLevel ("Level3.1");
								}
								if (hit.transform.name == "GoTo4.1") {
										Application.LoadLevel ("Level4.1");
								}
								if (hit.transform.name == "GoTo5.1") {
										Application.LoadLevel ("Level5.1");
								}
								if (hit.transform.name == "GoTo7.1") {
										Application.LoadLevel ("Level7.1");
								}
								if (hit.transform.name == "HideJournal") {
										JournalMove.GoBack ();
								}
								if (hit.transform.name == "ShowJournal") {
										JournalMove.GoTo ();
								}
								if (hit.transform.name == "HideMap") {
										MapMove.GoBack ();
								}
								if (hit.transform.name == "ShowMap") {
										MapMove.GoTo ();
								}
								if (hit.transform.name == "Menu") {
										Application.LoadLevel ("1Main Menu");
								}
						}
				}
		}
	
		void Dialog ()
		{
				if (!audio.isPlaying) {
						if (showButtons < 2) {
								showButtons++;
								M1.renderer.enabled = true;
								M2.renderer.enabled = true;
								J1.renderer.enabled = true;
								J2.renderer.enabled = true;
						}
						if (Input.GetMouseButtonDown (0)) { // if left button pressed...
								Ray ray = camera.ScreenPointToRay (Input.mousePosition);
								RaycastHit hit;
				
								if (Physics.Raycast (ray, out hit)) {
					
										if (hit.transform.name == "Replay") {

												audio.clip = correct;
												audio.Play ();
										}
								}
						}
				} else {
						showButtons = 0;
						M1.renderer.enabled = false;
						M2.renderer.enabled = false;
						J1.renderer.enabled = false;
						J2.renderer.enabled = false;
				}
		}
}