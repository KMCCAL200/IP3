using UnityEngine;
using System.Collections;

//switches images on buttons when they are clicked

public class Buttons : MonoBehaviour {
	public GameObject B1;
	public GameObject B2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		B1.renderer.enabled = false;
		B2.renderer.enabled = true;

	}
	
	void OnMouseUp(){
		B1.renderer.enabled = true;
		B2.renderer.enabled = false;
	}
}
