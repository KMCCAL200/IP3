using UnityEngine;
using System.Collections;

//Resets all clues on new game

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Hiker",  2);
		PlayerPrefs.SetInt ("Nessie", 2);
		PlayerPrefs.SetInt ("Deero",  2);
		PlayerPrefs.SetInt ("Ghost",  2);
		PlayerPrefs.SetInt ("Busker", 2);
	}
	void Update () {
		if (Input.GetMouseButtonDown (0)) { // if left button pressed...
			Ray ray = camera.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.name == "GoTo1") {
					Application.LoadLevel ("Level1.3");
				}
			}
		}
	}
}