using UnityEngine;
using System.Collections;

//switches images on buttons when they are clicked

public class ButtonsSelect : MonoBehaviour {
	public GameObject B1;
	public GameObject B3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		B1.renderer.enabled = false;
		B3.renderer.enabled = true;

	}
}
