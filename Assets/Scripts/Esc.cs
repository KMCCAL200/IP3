using UnityEngine;
using System.Collections;
//For the controls menu
public class Esc : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.Escape))
			Application.LoadLevel("Menu");
	}
}