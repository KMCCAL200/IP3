using UnityEngine;
using System.Collections;

//Displayes clues the player has collected
//Is user clicks on clue audio is played

public class Stickers : MonoBehaviour
{
		public GameObject S1;
		public GameObject S2;
		public GameObject S3;
		public GameObject S4;
		public GameObject S5;
		public AudioClip A1;
		public AudioClip A2;
		public AudioClip A3;
		public AudioClip A4;
		public AudioClip A5;

		// Use this for initialization
		void Start ()
		{
				S1.renderer.enabled = false;
				S2.renderer.enabled = false;
				S3.renderer.enabled = false;
				S4.renderer.enabled = false;
				S5.renderer.enabled = false;
				if (PlayerPrefs.GetInt ("Hiker") == 1) {
						S1.renderer.enabled = true;
				}
				if (PlayerPrefs.GetInt ("Nessie") == 1) {
						S2.renderer.enabled = true;
				}
				if (PlayerPrefs.GetInt ("Deero") == 1) {
						S3.renderer.enabled = true;
				}
				if (PlayerPrefs.GetInt ("Ghost") == 1) {
						S4.renderer.enabled = true;
				}
				if (PlayerPrefs.GetInt ("Busker") == 1) {
						S5.renderer.enabled = true;
				}
		}

		// Update is called once per frame
		void Update ()
		{

				if (Input.GetMouseButtonDown (0)) { // if left button pressed...
						Ray ray = camera.ScreenPointToRay (Input.mousePosition);
						RaycastHit hit;
			
						if (Physics.Raycast (ray, out hit)) {
								if (hit.transform.name == "S1") {
										if (PlayerPrefs.GetInt ("Hiker") == 1) {
												audio.clip = A1;
												audio.Play ();
										}
								}
								if (hit.transform.name == "S2") {
										if (PlayerPrefs.GetInt ("Nessie") == 1) {
												audio.clip = A2;
												audio.Play ();
										}
								}
								if (hit.transform.name == "S3") {
										if (PlayerPrefs.GetInt ("Deero") == 1) {
												audio.clip = A3;
												audio.Play ();
										}
								}
								if (hit.transform.name == "S4") {
										if (PlayerPrefs.GetInt ("Ghost") == 1) {
												audio.clip = A4;
												audio.Play ();
										}
								}
								if (hit.transform.name == "S5") {
										if (PlayerPrefs.GetInt ("Busker") == 1) {
												audio.clip = A5;
												audio.Play ();
										}
								}
						}
				}
		}
}