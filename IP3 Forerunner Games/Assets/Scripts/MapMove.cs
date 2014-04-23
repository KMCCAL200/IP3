using UnityEngine;
using System.Collections;

//Moves map/journal onto and off og the screen

public class MapMove : MonoBehaviour {
	public GameObject target;
	public float time = 5;
	public Vector3 goTo;
	public Vector3 goBack;
	// Use this for initialization
	void Start () {
		target = gameObject;
		goTo = GameObject.Find("target").transform.position;
		goBack = GameObject.Find("start").transform.position;
	}
	
	// Update is called once per frame
	void Update () {}

	public void GoTo()
	{
		iTween.MoveTo(target,goTo,time);
	}

	public void GoBack()
	{
		iTween.MoveTo(target,goBack,time);
	}
}
